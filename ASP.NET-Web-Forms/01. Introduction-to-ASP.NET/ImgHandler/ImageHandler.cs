using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace ImgHandler
{
    public class ImageHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            var response = context.Response;
            string text = context.Request.Url.Segments[1];
            text = text.Remove(text.Length - 4);
            response.Write(text);
            //response.ContentType = "image/png";
        }
    }
}