using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Core.Models
{
    public class Team:TEntity
    {
        public string Name { get; set; }
        public string Profession {  get; set; }
        public string TwitterUrl {  get; set; }
        public string FBUrl {  get; set; }
        public string InstaUrl {  get; set; }
        public string LNUrl {  get; set; }
    }
}
