using System;
using System.Collections.Generic;
using FluorineFx;


namespace IntegracaoFlex
{

    /// <summary>
    /// A class representation for a Person
    /// </summary>
    /// 
    [RemotingService]
    public class Person
    {
        private static List<Person> people = people = new List<Person>();  
        public Person()
        {
            
        }

        #region Fields
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String phone;

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        #endregion

        public Person(int anId, String aName, String aPhone)
        {

            this.name = aName;
            this.phone = aPhone;
            this.id = anId;
                                   
        }


        public string insert(Person aPerson)
        {
            people.Add(aPerson);
            string message = "--- Pessoa Inserida ---\n";
            message += "Id_Pessoa: " + aPerson.id.ToString() + "\n";
            message += "Nome: " + aPerson.name + "\n";
            message += "Telefone: " + aPerson.phone + "\n";
            message += "Essa é a : " + people.Count.ToString() + "° pessoa inserida";
            return message;
        }

        public void loadList()
        {
            people.Add(new Person(1, "Vinicius", "(16)3711-1111"));
            people.Add(new Person(5, "Cristian", "(16)3722-2222"));
            people.Add(new Person(9, "Juliano", "(16)3733-3333"));
            people.Add(new Person(15, "Ricardo", "(16)3744-4444"));
            people.Add(new Person(3, "Euripedes", "(16)3755-5555"));   
        }

         public List<Person> Lista()        
         {                                
             return people;        
         }

         public string remove(Person personToRemove)
         {
             int personToRemovePosition = findPersonToRemove(personToRemove);
             if (personToRemovePosition > -1)
             {
                 people.RemoveAt(personToRemovePosition);
                 return "person removed";
             }
             else
             {
                 return "person not removed";
             }
             
             
         }

         private int findPersonToRemove(Person personToRemove)
         {
             foreach(Person person in people)
             {
                 if(person.id.Equals(personToRemove.id))
                 {
                     return people.IndexOf(person);
                 }
             }
             return -1;
         }
    }
}