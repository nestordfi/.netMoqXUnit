using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestWithMoqExample
{
    public class BlogService
    {
        IHtmlValidator _htmlValidator;
        ILog _log;

        public BlogService(IHtmlValidator htmlValidator, ILog log)
        {
            _htmlValidator = htmlValidator;
        }

        private void Log(string message, int numero)
        {
            if (_log != null)
                _log.Log(message,numero);
        }

        public bool PublicPost(string html)
        {
            if (_htmlValidator.IsValid(html))
            {
                Log("Post has published",20);

                return true;
            }
            else
            {
                Log("publish error, html not valid",01);

                throw new ArgumentException("html not valid");
            }
        }
    }
}
