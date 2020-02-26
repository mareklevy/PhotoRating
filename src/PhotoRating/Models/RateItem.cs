using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoRating.Models
{
    public class RateItem
    {
        public RateItem(decimal rating)
        {
            this.Rating = rating;
        }

        public Guid Id { get; private set; } = Guid.NewGuid();

        public decimal Rating { get; set; }
    }
}
