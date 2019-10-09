using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares.Controller
{
    // 1 - Usar Model
    // 2 - Criar uma instência nova da nossa Context
    public class CelularesControllerr
    {
        CelularesContextDB contextDB = new CelularesContextDB();//Instanciando
        //LIstagem
        /// <summary>
        /// Método que retorna apenas nossa lista de celulares ativos 
        /// </summary>
        /// <returns>QUeryList de Celulares Filtrado por Ativos</returns>
        public IQueryable<Celular> GetCelularer()
        {
            return contextDB.Celulares.Where<Celular>(x => x.Ativo == true);
        }
        //Atualização
        /// <summary>
        /// Método que Atualiza um registro válido no nosso sistema
        /// </summary>
        /// <param name="item">Item que vamos atualizar </parrram>
        /// <returns>Retorna verdadeiro caso exista o item</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular = contextDB.Celulares.FirstOrDefault(x => x.Id == item.Id);// FirstOrDefault => Buscamos em nossa tabela o celular, onde tem aquele Id
            if (celular == null)//Verificamos se ele realmente encontrou um Id que esxite
                return false;
            else
            {
                celular.DataAlteracao = DateTime.Now; // Atualizamos a data da alteração do nosso celular
                contextDB.SaveChanges();
                return true;
            }
        }
        //insercação
        /// <summary>
        /// Método que valida e insere os registros dentro do sistema
        /// </summary>
        /// <param name="item">Nosso Novo Celular</param>
        /// <returns>Retorna verdadeiro para um item válido</returns>
        public bool InserirCelular(Celular item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca)) //IsNullOrWhiteSpace => Método que identifica espaçoes em branco apenas, ou valor null
                return false;
            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;
            if (item.Preco <= 0)
                return false;

            contextDB.Celulares.Add(item);
            contextDB.SaveChanges();
            return true;
        }
        //'Remoção'
        /// <summary>
        /// Método Utilizado apenas para desativar um item dentro do nosso sistema
        /// </summary>
        /// <param name="id">Id que vamos desativar</param>
        /// <returns>Retorna Verdadeiro em Caso de Sucesso</returns>
        public bool RemoverCelular(int id)
        {
            var celular = contextDB.Celulares.FirstOrDefault<Celular>(x => x.Id == id);
            if (celular == null)
                return false;

            celular.Ativo = false;
            contextDB.SaveChanges();
            return true;
        }
    }
}
