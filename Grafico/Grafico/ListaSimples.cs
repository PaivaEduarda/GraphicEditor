using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace Grafico
{
    public class ListaSimples<Dado> where Dado : IComparable<Dado>
    {
        NoLista<Dado> primeiro, ultimo, atual, anterior;
        int quantosNos;
        bool primeiroAcessoDoPercurso;
        public ListaSimples()
        {
            primeiro = ultimo = atual = anterior = null;
            quantosNos = 0;
            primeiroAcessoDoPercurso = false;
        }

        public bool EstaVazia
        {
            get => primeiro == null;
        }
        public NoLista<Dado> Primeiro { get => primeiro; }
        public NoLista<Dado> Ultimo { get => ultimo; }
        public NoLista<Dado> Atual { get => atual; }
        public NoLista<Dado> Anterior { get => anterior; }
        
        public List<Dado>lista()
        {
            var lista = new List<Dado>();
            atual = primeiro;
            while(atual != null)
            {
                lista.Add(atual.Info);
                atual = atual.Prox;
            }
            return lista;
        }
        public void InserirAntesDoInicio(Dado novoDado)
        {
            var novoNo = new NoLista<Dado>(novoDado);
            if (EstaVazia)
                ultimo = novoNo;
            novoNo.Prox = primeiro;
            primeiro = novoNo;
            quantosNos++;
        }
        public void InserirAposFim(NoLista<Dado> noExistente)
        {
            if (EstaVazia)
                primeiro = noExistente;
            else
                ultimo.Prox = noExistente;
            ultimo = noExistente;
            quantosNos++;
        }

        public void InserirAposFim(Dado novoDado)
        {
            var novoNo = new NoLista<Dado>(novoDado);
            if (EstaVazia)
                primeiro = novoNo;
            else
                ultimo.Prox = novoNo;
            ultimo = novoNo;
            ultimo.Prox = novoNo;
            quantosNos++;
        }
        public bool ExisteDados(Dado procurado)
        {
            atual = anterior = null;
            if (EstaVazia)
                return false;
            if(primeiro.Info.CompareTo(procurado)>0)
            {
                atual = primeiro;
                return false;
            }

            if(ultimo.Info.CompareTo(procurado)<0)
            {
                anterior = ultimo;
                return false;
            }

            bool maiorOuFim = false;
            bool achou = false;
            atual = primeiro;
            while (!achou && !maiorOuFim)
                if (atual == null)
                    maiorOuFim = true;
                else
                    if (atual.Info.CompareTo(procurado) > 0)
                    maiorOuFim = true;
                else
                    if (atual.Info.CompareTo(procurado) == 0)
                    achou = true;
                else
                {
                    anterior = atual;
                    atual = atual.Prox;
                }
            return achou;
        }
        public void InserirEmOrdem(Dado dados)
        {
            if (EstaVazia)
                InserirAntesDoInicio(dados);
            else
                if (dados.CompareTo(primeiro.Info) < 0)
                InserirAntesDoInicio(dados);
            else if (dados.CompareTo(ultimo.Info) > 0)
                InserirAposFim(dados);
            else
                 if (!ExisteDados(dados))
            {
                var novo = new NoLista<Dado>(dados);
                anterior.Prox = novo;
                novo.Prox = atual;
                if (anterior == ultimo)
                    ultimo = novo;
                quantosNos++;
            }
            else
                throw new Exception("Já existe!");
        }
        public bool Remover(Dado dadoARemover)
        {
            if(ExisteDados(dadoARemover))
            {
                if(atual == primeiro)
                {
                    primeiro = primeiro.Prox;
                    atual = primeiro;
                    if (primeiro == null)
                        ultimo = null;
                }
                else
                    if(atual == ultimo)
                    {
                        ultimo = anterior.Prox;
                        ultimo.Prox = null;
                        atual = ultimo;
                    }
                else
                {
                    anterior.Prox = atual.Prox;
                    atual = atual.Prox;
                }
                quantosNos--;
                return true;
            }
            return false;
        }
        public void Ordenar()
        {
            var listaOrdenada = new ListaSimples<Dado>();
            while(!this.EstaVazia)
            {
                NoLista<Dado> anteriorAoMenor = null;
                NoLista<Dado> oMenor = this.primeiro;
                this.atual = primeiro;
                this.anterior = null;
                while(this.atual!=null)
                {
                    if(oMenor.Info.CompareTo( atual.Info ) > 0)
                    {
                        anteriorAoMenor = this.anterior;
                        oMenor = this.atual;
                    }
                    this.anterior = this.atual;
                    this.atual = this.atual.Prox;
                }
                if(anteriorAoMenor == null)
                {
                    primeiro = this.primeiro.Prox;
                }
                else
                {
                    anteriorAoMenor.Prox = oMenor.Prox;
                }
                this.quantosNos--;

                listaOrdenada.InserirAposFim(oMenor);
            }
            this.primeiro = listaOrdenada.primeiro;
            this.ultimo = listaOrdenada.ultimo;
            this.atual = listaOrdenada.atual;
            this.anterior = listaOrdenada.anterior;
            this.quantosNos = listaOrdenada.quantosNos;
        }
        public void IniciarPercursoSequencial()
        {
            atual = primeiro;
            while(PodePercorrer())
            {
                atual = atual.Prox;
            }
        }
        public bool PodePercorrer() 
        {
            return atual != null; 
        }
    }
}
