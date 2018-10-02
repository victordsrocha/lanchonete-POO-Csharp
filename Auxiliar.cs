﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {
    class Auxiliar {

        public static int defineCodigo(string categoria) {
            if (categoria == "lanche") {
                return Program.listaLanche.Count + 101;
            }
            else if (categoria == "refeicao") {
                return Program.listaLanche.Count + 201;
            }
            else if (categoria == "bebida") {
                return Program.listaLanche.Count + 301;
            }
            else if (categoria == "sobremesa") {
                return Program.listaLanche.Count + 401;
            }
            else {
                return 0;
            }
        }
    }

}
