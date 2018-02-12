using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace Picsor.Compressor
{   
    public class ImageCompressor
    { 
        private Bitmap _image;

        public int ImageWidth
        {
            get { return _image.Width; }
        }

        public int ImageHeight
        {
            get { return _image.Height; }
        }
        

        public ImageCompressor(Bitmap image)
        {
            _image = image;
        }

        public ImageCodecInfo GetCodec(ImageFormat imageFormat)
        {
            return ImageCodecInfo
                    .GetImageDecoders()
                    .FirstOrDefault(c => c.FormatID == imageFormat.Guid);
        }

        public ImageCodecInfo GetCurrentCodec()
        {
            if (_image.RawFormat.Equals(ImageFormat.Jpeg))
            {
                return ImageCodecInfo
                    .GetImageDecoders()
                    .FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid);
            }
            else if (_image.RawFormat.Equals(ImageFormat.Png))
            {
                return ImageCodecInfo
                    .GetImageDecoders()
                    .FirstOrDefault(c => c.FormatID == ImageFormat.Png.Guid);
            }
            else
            {
                return ImageCodecInfo
                    .GetImageDecoders()
                    .FirstOrDefault(c => c.FormatID == _image.RawFormat.Guid);
            }
        }

        public void EncodeAndSave(ImageCodecInfo codecInfo, string destinationPath, int quality, Bitmap resizedImage = null)
        {
            if (resizedImage == null)
            {
                resizedImage = _image;
            }

            using (var output = File.Open(destinationPath, FileMode.Create))
            {
                var qualityParamId = Encoder.Quality;
                var encoderParameters = new EncoderParameters(1);
                encoderParameters.Param[0] = new EncoderParameter(qualityParamId, quality);

                resizedImage.Save(output, codecInfo, encoderParameters);
            }
        }

        public Bitmap Resize(int width, int height)
        {            
            var resizedImage = new Bitmap(width, height);
            using (var graphics = Graphics.FromImage(resizedImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.CompositingMode = CompositingMode.SourceOver;
                graphics.DrawImage(_image, 0, 0, width, height);

                return resizedImage;
            }
        }
    }
}
