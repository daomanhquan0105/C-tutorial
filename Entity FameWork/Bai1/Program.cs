using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Bai1.Controller;
using Bai1.Model;
using Bai1.Helper;
using Bai1.View;
namespace Bai1
{

    class Program
    {
        static void Main(string[] args)
        {
            Repository rep = new Repository();
            rep.Menu();
            Console.ReadKey();
        }
    }
}
