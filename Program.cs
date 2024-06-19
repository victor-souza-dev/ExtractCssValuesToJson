using ConvertCssToJson;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program {
    static void Main() {
        string currentDirectory = Directory.GetCurrentDirectory();
        string cssDirectory = Path.Combine(currentDirectory, "css");

        string outputDirectory = Path.Combine(currentDirectory, "json");

        ProcessJson(cssDirectory, outputDirectory);
    }

    static void ProcessJson(string cssDirectory, string outputDirectory) {

        if (!Directory.Exists(outputDirectory)) {
            Directory.CreateDirectory(outputDirectory);
        }

        string[] cssFiles = Directory.GetFiles(cssDirectory, "*.css");

        int successLength = 0;

        foreach (string cssFilePath in cssFiles) {
            string cssContent = File.ReadAllText(cssFilePath);
            string outputFileName = Path.GetFileNameWithoutExtension(cssFilePath).Replace(".min", "") + ".json";
            string outputFilePath = Path.Combine(outputDirectory, outputFileName);

            if (File.Exists(outputFilePath)) {
                Console.WriteLine($"Arquivo {outputFileName} já existe!");
                continue;
            }

            Root mapping = new Root();

            ExtractProperty extractProperty = new ExtractProperty(cssContent, mapping);
            extractProperty.ExtractAllProperties();

            JsonSerializerOptions options = new JsonSerializerOptions {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            string jsonString = JsonSerializer.Serialize(mapping, options);

            try {
                File.WriteAllText(outputFilePath, jsonString);
                Console.WriteLine($"{outputFileName} salvo com sucesso!");
                successLength++;
            } catch (Exception ex) {
                Console.WriteLine($"Erro ao salvar {outputFileName}: {ex.Message}");
            }
        }

        Console.WriteLine("\nÊxito: " + successLength);
        Console.WriteLine("Erros: " + (cssFiles.Length - successLength));
    }

    static void ListNameFile(string directory) {
        string[] fileNames = Directory.GetFiles(directory)
                              .Select(filePath => Path.GetFileNameWithoutExtension(filePath))
                              .ToArray();

        foreach (string fileName in fileNames) {
            Console.WriteLine($"\"{fileName.Replace("isp_", "")}\",");
        }
    }
}