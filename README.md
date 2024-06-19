### Algorithm Explanation

#### Objective
The algorithm aims to extract the values of background-color, color, and font-family properties from specific classes in a CSS file and store these values in a defined JSON format called "Template".

#### Algorithm Steps
Reading the CSS File:

The algorithm starts by reading the content of a specific CSS file. This is done using the File.ReadAllText function to load the entire content of the file into a string.
Initializing the Mapping:

An object of type Root is initialized to store the extracted data. This object will serve as the base structure for the output JSON.
Property Extraction:

An instance of the ExtractProperty class is created, receiving the CSS content and the Root object as parameters.
The ExtractAllProperties method of the ExtractProperty class is invoked to process the CSS content and extract the desired properties (background-color, color, font-family).
Configuring JSON Serialization Options:

JSON serialization options are configured using the JsonSerializerOptions class. The defined options include formatted (indented) writing and omitting properties with null values. Additionally, the property naming policy is set to CamelCase to ensure consistency in the JSON format.
JSON Serialization and Saving:

The Root object filled with the extracted data is serialized into a JSON string using the JsonSerializer.Serialize method.
The resulting JSON string is saved to an output file, with the file name derived from the processed CSS file name, replacing the .css extension with .json and removing any occurrence of .min.
Handling Multiple CSS Files:

The algorithm can be extended to process multiple CSS files within a specific directory. All CSS files are read and processed iteratively, and the resulting JSON files are saved in an output directory.
