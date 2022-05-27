// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Program.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-03-30
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_022_009_CovarianceInterfaces
{
    interface BaseInterface
    {
    }

    class BaseClass : BaseInterface
    {
    }

    class ChildClass : BaseClass
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<ChildClass> collec_child_class = new List<ChildClass>();
            //autorisé car les interfaces sont covariantes
            IEnumerable<BaseClass> collec_base_class = collec_child_class;

            List<ChildClass> list_child_class = new List<ChildClass>();
            //non autorisé car les classes ne sont pas covariantes
            //List<BaseClass> list_base_class = list_child_class;

            //autorisé car List<ChildClass> implémente IEnumerable<ChildClass> et IEnumerable<> est covariante
            collec_base_class = list_child_class;
            //autorisé
            IEnumerable<BaseInterface> collec_base_interface = list_child_class;
        }
    }
}
