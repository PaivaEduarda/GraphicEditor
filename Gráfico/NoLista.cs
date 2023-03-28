using System;
using System.Reflection;

namespace Grafico
{
    public class NoLista<Dado> where Dado : IComparable<Dado>
    {
        Dado info;
        NoLista<Dado> prox;

        public Dado Info 
        { 
            get => info;
            set 
            { 
                if(value != null)
                    info = value; 
            }
        }
        internal NoLista<Dado> Prox 
        { 
            get => prox; 
            set => prox = value; 
        }

        public NoLista(Dado novaInfo, NoLista<Dado> proximo)
        {
            Info = novaInfo;
            Prox = proximo;
        }

        public NoLista(Dado novaInfo)
        {
            Info = novaInfo;
            Prox = null;
        }

    }
}
