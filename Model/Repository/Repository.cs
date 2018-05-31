using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository
{
    using Model.Entity;

    public abstract class Repository
    {
        protected Context Context { get; set; }

        public Repository()
        {
            this.Context = new Context();
        }
    }
}
