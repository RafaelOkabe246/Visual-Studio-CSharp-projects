using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Facade
{
    internal class Player
    {
        public float viewRange;
        public int hp;

        public void SetPlayerHp( int _hp)
        {
            hp = _hp;
        }
        public void SetViewRange( float _viewRange )
        {
            viewRange = _viewRange;
        }
    }
}
