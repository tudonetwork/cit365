using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_RamonAndrade
{

    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rossewood,
        Veneer
    };

    public class Desk
    {
        public List<int> drawerList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7 };
        public List<int> rushList = new List<int>() {3, 5, 7 };

        public int width { get; set; }
        public int depth { get; set; }
        public int drawers { get; set; }
        public int rush { get; set; }
        public DesktopMaterial surface { get; set; }
        public int size { get; set; }

        public Desk(int width, int depth, int drawers, int rush, DesktopMaterial surface)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawerList[drawers];
            this.rush = rushList[rush];
            this.surface = surface;
        }


        public Desk()
        {
            
        }



    }

}
