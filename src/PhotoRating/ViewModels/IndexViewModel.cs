using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoRating.ViewModels
{
    public class IndexViewModel
    {
        List<Models.RateItem> items;

        public IndexViewModel()
        {
            this.items = new List<Models.RateItem>();
            this.Items = this.items.AsReadOnly();

            var buttons = new List<decimal>();
            for (decimal i = 0; i < 10; i++)
            {
                buttons.Add(i);
                buttons.Add(i + 0.5M);
            }
            this.Buttons = buttons.AsReadOnly();
        }

        void Calc()
        {
            this.Items = this.items.AsReadOnly();
            
            if (this.items.Any())
            {
                this.Average = Math.Round(this.items.Sum(x => x.Rating) / this.items.Count, 2);
                this.Total = Math.Round(this.Average, 0, MidpointRounding.AwayFromZero);
            }
            else
            {
                this.Average = 0M;
                this.Total = 0M;
            }
        }

        public void ClearHandler()
        {
            this.items.Clear();
            this.Calc();
        }

        public void VoteHandler(decimal value)
        {
            this.items.Add(new Models.RateItem(value));

            this.Calc();
        }

        public void RemoveVoteHandler(Models.RateItem item)
        {
            this.items = this.items.Where(x => x.Id != item.Id).ToList();

            this.Calc();
        }

        public decimal Average { get; private set; }
        public decimal Total { get; private set; }

        public IReadOnlyList<Models.RateItem> Items { get; private set; }
        public IReadOnlyList<decimal> Buttons { get; private set; }
    }
}
