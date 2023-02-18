using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Otel.Core.Entities;//--------------
using System.ComponentModel.DataAnnotations.Schema;

namespace Otel.Entites.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] CustomerPicture { get; set; }
    }
}
