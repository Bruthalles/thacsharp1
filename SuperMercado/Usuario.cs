using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace SuperMercado
{
    public class Usuario
    {
        private string _nome;
        private int _id;
        public string Nome { 
            
            get => _nome;  
            
            set{if(!string.IsNullOrEmpty(value)) _nome = value;
                
                else Console.WriteLine("Nome não pode ser nulo");
                
                } 
            }
        public int Id { 
            get ;
            set; }
    }
}