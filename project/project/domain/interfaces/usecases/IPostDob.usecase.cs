﻿using project.domain.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.interfaces.usecases
{

    public interface IPostDob
    {
        void insertDob(string idClient);
    }

}
