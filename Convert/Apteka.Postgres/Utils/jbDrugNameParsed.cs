using System;
using System.Collections.Generic;
using System.Text;

namespace Apteka.Postgres.Utils
{
    public class jbDrugNameParsed
    {
        public Guid Id { get; set; }

        public string RealName { get; set; }

        public string Name { get; set; }

        public int Piece { get; set; }

        public string Unit { get; set; }

        public string Percent { get; set; }

        public string Mg { get; set; }

        public string Ml { get; set; }

        public string Ed { get; set; }

        public string Doz { get; set; }

        public string Nomer { get; set; }

        public string Skobki { get; set; }

        public Guid? RealId { get; set; }
    }
}
