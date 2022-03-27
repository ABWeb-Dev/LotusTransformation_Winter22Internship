using System.IO;
//figure out how to import LibSass
namespace LotusTransformation.Services
{
    public static class CompileScss
    {
        public static string pathToScss = @"C:\Users\natsu\Music\OneDrive\Desktop\Bethany's Site\LotusTransformation\LotusTransformation\wwwroot\CustomScss\LayoutCustom.scss";
        public static string pathToCss = @"C:\Users\natsu\Music\OneDrive\Desktop\Bethany's Site\LotusTransformation\LotusTransformation\wwwroot\CustomCss\CSSReset.css";

        public static string CompiledFile()
        {

            TextReader reader = new StreamReader(pathToScss);

            string CompiledCss = reader.ReadToEnd();

            //CompiledCss

            return CompiledCss;
        }


    }
}
