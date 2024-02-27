using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class PhoneBook : Phone //class PhoneBook ke thua tu class Phone
    {
        private List<(string name, string phoneNumber)> phoneList = new List<(string , string)>(); //kieu du lieu List
        public override void InsertPhone(string name, string phone)
        {
            var existingTest = phoneList.FirstOrDefault(x => x.name == name);
            if (existingTest == default((string, string)))
            { phoneList.Add((name, phone)); }
            else {
                existingTest = phoneList.FirstOrDefault(x => x.phoneNumber == phone);
                if (existingTest == default((string, string))) phoneList.Add((name, phone)); }
        }

        public override void RemovePhone(string name)
        {
            phoneList.RemoveAll(x => x.name == name);
        }

        public override void SearchPhone(string name)
        {
            var searchName = phoneList.Where(x => x.name == name).ToList();
            if (searchName.Count > 0) {
                foreach (var result in searchName) {
                    Console.WriteLine($"Name: {result.name}, Phone Number: {result.phoneNumber}");
                }
            } else { Console.WriteLine("NOT FOUND 404!"); }
        }

        public override void Sort()
        {
            phoneList.Sort();
        }

        public override void UpdatePhone(string name, string newphone)
        {
            var updateSth = phoneList.Where(x => x.name == name).ToList();
            if(updateSth.Count == 0) {Console.WriteLine("NOT FOUND 404!");}
            else if(updateSth.Count > 0) {
                foreach (var x in updateSth)
                {
                    int sth = phoneList.IndexOf(x);
                    phoneList[sth] = (name, newphone); 
                }
            }
        }
    }
}
