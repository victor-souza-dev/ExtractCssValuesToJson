using System.Reflection;
using System.Text.RegularExpressions;

namespace ConvertCssToJson; 
public class ExtractProperty {
    private readonly string cssContent = "";
    private readonly Root mapping;

    public ExtractProperty(string cssContent, Root mapping) {
        this.cssContent = cssContent;
        this.mapping = mapping;
    }

    public void ExtractAllProperties() {
        LoginPage();
        LoginPagePaperContainer();
        LoginPageMuiFormLabelRoot();
        LoginPageMuiFormLabelRootMuiFocused();
        LoginPageButtonPrimary();
        PacotePage();
        PacotePageContentHeader();
        PacotePageHeaderContainer();
        PacotePageBotaoSair();
        PacotePageContentContainer();
        PacotePageMuiSwitchColorSecondaryMuiCheckedMuiSwitchTrack();
        PacotePageButtonPrimary();
        PacotePageButtonConfirm();
        PacotePageAccordionHeaderTitle();
        PacotePageAccordionHeaderExpandIcon();
        SearchAvatar();
    }
    public void LoginPage() {
        Match match = Regex.Match(cssContent, @"\.login-page\s*{(.*?)}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;

            ExFontFamily(contentMatch, "Login.Typography.EstiloFonte");

            string patternLinearGradient = @"linear-gradient\(180deg,([^)]+)\)";

            Match matchLinearGradient = Regex.Match(contentMatch, patternLinearGradient);
            if (matchLinearGradient.Success) {
                string linearGradientColors = matchLinearGradient.Groups[1].Value.Replace("50%", "").Replace(" ", "").Trim();

                string[] colors = linearGradientColors.Split(',');

                mapping.Login.Palette.Background2 = colors[0];
                mapping.Login.Palette.Background1 = colors[1];
            }

        }
    }
    public void LoginPagePaperContainer() {
        Match match = Regex.Match(cssContent, @"\.login-page\s*\.paper-container\s*{(.*?)}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;
            ExBgColor(contentMatch, "Login.Palette.BackgroundCaixaLogin");
        }
    }
    public void LoginPageMuiFormLabelRoot() {
        Match match = Regex.Match(cssContent, @"\.login-page\s*\.MuiFormLabel-root\s*{\s*(.*?)\s*}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;
            ExColor(contentMatch, "Login.Palette.CorFonte");
        }
    }
    public void LoginPageMuiFormLabelRootMuiFocused() {
        Match match = Regex.Match(cssContent, @"\.login-page\s*\.MuiFormLabel-root\s*\.Mui-focused\s*{\s*(.*?)\s*}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;
            ExColor(contentMatch, "Login.Palette.InputCorBorda");
        }
    }
    public void LoginPageButtonPrimary() {
        Match match = Regex.Match(cssContent, @"\.login-page\s*\.button-primary\s*{\s*(.*?)\s*}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;

            ExColor(contentMatch, "Login.Palette.BotaoCorFonte");
            ExBgColor(contentMatch, "Login.Palette.BotaoBackground");
        }
    }
    public void PacotePage() {
        Match match = Regex.Match(cssContent, @"\.pacote-page\s*{(.*?)}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;
            ExFontFamily(contentMatch, "Produto.Typography.EstiloFonte");
        }
    }
    public void PacotePageContentHeader() {
        Match match = Regex.Match(cssContent, @"\.pacote-page\s*\.content-header\s*{(.*?)}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;

            ExBgColor(contentMatch, "Produto.Palette.InformacoesInternasBackground");
            ExFontFamily(contentMatch, "Produto.Typography.InformacoesInternasEstiloFonte");
            ExColor(contentMatch, "Produto.Palette.InformacoesInternasCorFonte");
        }
    }
    public void PacotePageHeaderContainer() {
        Match match = Regex.Match(cssContent, @"\.pacote-page\s*\.header-container\s*{(.*?)}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;

            ExBgColor(contentMatch, "Produto.Palette.HeaderBackground");
            ExColor(contentMatch, "Produto.Palette.HeaderCorFonte");
        }
    }
    public void PacotePageBotaoSair() {
        Match match = Regex.Match(cssContent, @"\.pacote-page\s*\.botao-sair\s*{(.*?)}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;
            ExColor(contentMatch, "Produto.Palette.SairCorFonte");
        }
    }
    public void PacotePageContentContainer() {
        Match match = Regex.Match(cssContent, @"\.pacote-page\s*\.content-container\s*{(.*?)}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;

            ExBgColor(contentMatch, "Produto.Palette.ConteudoBackground");
            ExColor(contentMatch, "Produto.Palette.InformacoesCorFonte");
        }
    }
    public void PacotePageMuiSwitchColorSecondaryMuiCheckedMuiSwitchTrack() {
        Match match = Regex.Match(cssContent, @"\.pacote-page\s*\.MuiSwitch-colorSecondary\.Mui-checked\s*\+\s*\.MuiSwitch-track\s*{\s*(.*?)\s*}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;
            ExBgColor(contentMatch, "Produto.Palette.SwitchOn");
        }
    }
    public void PacotePageButtonPrimary() {
        Match match = Regex.Match(cssContent, @"\.pacote-page\s*\.button-primary\s*{(.*?)}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;

            ExBgColor(contentMatch, "Produto.Palette.BotaoBackground");
            ExColor(contentMatch, "Produto.Palette.BotaoCorFonte");
        }
    }
    public void PacotePageButtonConfirm() {
        Match match = Regex.Match(cssContent, @"\.pacote-page\s*\.button-confirm\s*{(.*?)}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;
            ExColor(contentMatch, "Produto.Palette.BotaoConfirmar");
        }
    }
    public void PacotePageAccordionHeaderTitle() {
        Match match = Regex.Match(cssContent, @"\.pacote-page\s*\.accordion-header-background\s*{(.*?)}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;
            ExBgColor(contentMatch, "Produto.Palette.SanfonasBackground");
        }
    }
    public void PacotePageAccordionHeaderExpandIcon() {
        Match match = Regex.Match(cssContent, @"\.pacote-page\s*\.accordion-header-expand-icon\s*{(.*?)}", RegexOptions.Singleline);

        if (match.Success) {
            string contentMatch = match.Groups[1].Value;

            ExColor(contentMatch, "Produto.Palette.SanfonasCorFonte");
            ExFontFamily(contentMatch, "Produto.Typography.SanfonasEstiloFonte");
        }
    }
    public void SearchAvatar() {
        Match match1 = Regex.Match(cssContent, @"\.login-page\s*\.avatar-container-login\s*{(.*?)}", RegexOptions.Singleline);
        Match match2 = Regex.Match(cssContent, @"\.login-page\s*\.avatar-container-login-new-model\s*{(.*?)}", RegexOptions.Singleline);

        if (match1.Success) mapping.Login.Model = 1;
        if (match2.Success) mapping.Login.Model = 2;
    }

    public void ExBgColor(string content, string index) {
        string pattern = @"background-color:\s*([^;!]+)\s*(;|!)?";

        Match matchProp = Regex.Match(content, pattern);
        if (matchProp.Success) {
            string prop = matchProp.Groups[1].Value.Replace(" ", "").Trim();
            SetNestedProperty(mapping, index, prop);
        }
    }
    public void ExFontFamily(string content, string index) {
        string pattern = @"font-family:\s*([^;!]+)\s*(;|!)?";

        Match matchProp = Regex.Match(content, pattern, RegexOptions.Singleline);
        if (matchProp.Success) {
            string prop = matchProp.Groups[1].Value.Replace("\"Roboto\"", "").Replace(" ", "").Trim();
            SetNestedProperty(mapping, index, prop);
        }
    }
    public void ExColor(string content, string index) {
        string pattern = @"color:\s*([^;!]+)\s*(;|!)?";

        string contentModify = content.Replace("background-color", "").Replace("border-color", "");

        Match matchProp = Regex.Match(contentModify, pattern, RegexOptions.Singleline);
        if (matchProp.Success) {
            string prop = matchProp.Groups[1].Value.Replace("!important", "").Trim();
            SetNestedProperty(mapping, index, prop);
        }
    }
    public void SetNestedProperty(object obj, string propertyPath, object value) {
        var properties = propertyPath.Split('.');
        for (int i = 0; i < properties.Length - 1; i++) {
            PropertyInfo propertyInfo = obj.GetType().GetProperty(properties[i]);
            obj = propertyInfo.GetValue(obj, null);
        }
        PropertyInfo finalProperty = obj.GetType().GetProperty(properties[^1]);
        finalProperty.SetValue(obj, value, null);
    }
}
