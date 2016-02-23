﻿using ContosoMoments.Common;

namespace ContosoMoments.Web.Models
{
    public class ConfigModel
    {
        public string DefaultAlbumId
        {
            get { return AppSettings.DefaultAlbumId; }
        }
        public string DefaultUserId
        {
            get { return AppSettings.DefaultUserId; }
        }

        public string DefaultServiceUrl
        {
            get { return AppSettings.DefaultServiceUrl; }
        }
    }
}