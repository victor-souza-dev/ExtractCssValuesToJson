namespace ConvertCssToJson;

public class Palette {
    public string? BackgroundCaixaLogin { get; set; }
    public string? Background1 { get; set; }
    public string? Background2 { get; set; }
    public string? CorFonte { get; set; }
    public string? InputCorBorda { get; set; }
    public string? BotaoCorFonte { get; set; }
    public string? BotaoBackground { get; set; }
    public string? HeaderBackground { get; set; }
    public string? SairCorFonte { get; set; }
    public string? HeaderCorFonte { get; set; }
    public string? ConteudoBackground { get; set; }
    public string? SanfonasCorFonte { get; set; }
    public string? SanfonasBackground { get; set; }
    public string? InformacoesCorFonte { get; set; }
    public string? SwitchOn { get; set; }
    public string? BotaoConfirmar { get; set; }
    public string? InformacoesInternasCorFonte { get; set; }
    public string? InformacoesInternasBackground { get; set; }
}

public class Typography {
    public string? EstiloFonte { get; set; }
    public string? InformacoesInternasEstiloFonte { get; set; }
    public string? SanfonasEstiloFonte { get; set; }
}

public class Section {
    public int Model { get; set; } = 0;
    public Palette Palette { get; set; } = new Palette();
    public Typography Typography { get; set; } = new Typography();
}

public class Root {
    public Section Login { get; set; } = new Section();
    public Section Produto { get; set; } = new Section();
}

