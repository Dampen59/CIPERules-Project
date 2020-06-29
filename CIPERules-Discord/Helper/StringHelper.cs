using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;

namespace AntiCaptcha.Helper
{
    public class StringHelper
    {
        public static string ImageFileToBase64String(string path)
        {
            try
            {
                using (var image = Image.Load(path))
                {
                    using (var m = new MemoryStream())
                    {
                        image.Save(m, new PngEncoder());
                        var imageBytes = m.ToArray();
                        var base64String = Convert.ToBase64String(imageBytes);
                        return base64String;
                    }
                }
            }
            catch
            {
                return null;
            }
        }
    }
}