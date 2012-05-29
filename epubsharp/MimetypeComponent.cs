using System;
using System.IO;
using System.IO.Packaging;

namespace EPubSharp
{
    class MimetypeComponent : Component
    {
        //TODO: Constructor is doing too much
        public MimetypeComponent()
        {
            _uriString = "mimetype";
            _partUri = PackUriHelper.CreatePartUri(new Uri(UriString, UriKind.Relative));

            BuildContent();
        }

        private void BuildContent()
        {
            _content = "application/epub+zip";
        }

        public override Stream ToStream()
        {
            return new MemoryStream(Util.StringToByteArray(_content));
        }
    }
}
