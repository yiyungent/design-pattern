﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式
{
    class PersonDirector
    {
        private PersonBuilder pb;
        public PersonDirector(PersonBuilder pb)
        {
            this.pb = pb;
        }

        public void CreatePerson()
        {
            pb.BuildHead();
            pb.BuildBody();
            pb.BuildArmLeft();
            pb.BuildArmRight();
            pb.BuildLegLeft();
            pb.BuildLegRight();
        }
    }
}
