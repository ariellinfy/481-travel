using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace travel.Model
{
    public class StateModel
    {
        public bool isGuest { get; set; } = true;
        public bool ShowNav { get; set; } = false; 

        public bool OnSearch { get; set; } = false;

        public int OnTab { get; set; }

        public bool JustLogout { get; set; } = false;
    }
}
