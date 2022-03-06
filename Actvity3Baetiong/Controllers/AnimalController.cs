using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Actvity3Baetiong.Models;

namespace Actvity3Baetiong.Controllers
{
    public class AnimalController : ApiController
    {
        static List<Animal> collections = new List<Animal>();


        public AnimalController()
        {
            Animal a = new Animal();
            a.Size = 14;
            a.Color = "brown";
            a.Name = "lion";
            a.Type = "mamal";
            collections.Add(a);

            Animal b = new Animal();
            b.Size = 14;
            b.Color = "brown";
            b.Name = "lion";
            b.Type = "mamal";
            collections.Add(b);
        }
        public Animal Get()
        {
            Animal a = new Animal();
            a.Size = 20;
            a.Color = "brown";
            a.Name = "Maze";
            a.Type = "bear";
            return a;
        }

        public Animal Get(string name)
        {
            Animal a = new Animal();
            a.Size = 14;
            a.Color = "brown";
            a.Name = "Scar";
            a.Type = "Lion";
            return a;
        }

        public Animal Get(float size, string color, string name)
        {
            Animal a = new Animal();
            a.Size = size;
            a.Color = color;
            a.Name = name;
            return a;
        }
        public void Post()
        { }
        public void Put()
        {

        }
        public void Delete()
        {

        }
    }
}
