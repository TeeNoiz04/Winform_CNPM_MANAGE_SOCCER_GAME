using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;

namespace MANAGE_SOCCER_GAME.Services
{
    
    public  class CloudService
    {
        private readonly Cloudinary _cloudinary;
        public CloudService()
        {
            var cloudinaryConfig = new Account(
                "611761596872118",      // API Key
                "AdX5vAQVHg-8lhY4NNhChB0_cK4",   // API Secret
                "dqp5kvzi1"    // Cloud Name
            );

            _cloudinary = new Cloudinary(cloudinaryConfig);
        }

    }
}
