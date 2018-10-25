using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamUWP.Entity
{
    class FileEntity
    {
        private string _name;
        private string _content;

        public string name { get => _name; set => _name = value; }
        public string content { get => _content; set => _content = value; }

    }
}
