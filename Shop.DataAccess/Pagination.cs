using Shop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DataAccess
{
    public class Pagination<T>
    {
        private List<T> entities = new List<T>();
        private int counter;

        public Pagination(List<T> entities)
        {
            this.entities = entities;
        }

        public void Skip(int number)
        {
            counter += number;
        }

        public List<T> Take(int number)
        {
            List<T> results = new List<T>();

            for(int i = 0; i < number; i++)
            {
                results.Add(entities[i + counter]);
            }

            return results;
        }
    }
}
