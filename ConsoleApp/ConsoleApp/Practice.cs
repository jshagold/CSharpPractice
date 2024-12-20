﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Algorithm.baekjoon;
using ConsoleApp.Language;
using ConsoleApp.Language.Inheritance;
using ConsoleApp.Language.MVCPractice.Controller;
using ConsoleApp.Language.MVCPractice.Model;

namespace ConsoleApp
{
    internal class Practice
    {
        //static void Main(string[] args)
        //{
             
        //}

        static async Task LanguageLaunch()
        {
            Console.WriteLine("StringPractice2");
            StringPractice2 sp2 = new();
            sp2.Main();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("DateTimePractice");
            DateTimePractice dtp = new DateTimePractice();
            dtp.Main();


            PropertyPractice propertyPractice = new PropertyPractice("name", "value");
            propertyPractice.Main();
            Console.WriteLine(propertyPractice.Name);


            new DelegatePractice().Main();


            Program inheritancePractice = new Program();
            inheritancePractice.Main();


            DeepCopyPractice copy = new DeepCopyPractice();
            copy.Main();


            //Actor actor = new Actor("Valll");
            Actor.Info info = new Actor.Info(optionType: 1, moveDirection: 2);


            LinQPractice linQP = new LinQPractice();
            linQP.Main();

            GenericPractice genericPractice = new GenericPractice();
            genericPractice.Main();


            AsyncPractice asyncPractice = new AsyncPractice();
            await asyncPractice.Main();

            ReflectionPractice reflectionPractice = new ReflectionPractice();
            reflectionPractice.Main();



            Console.WriteLine("\n\n\nMVC Practice");
            UserRepository userRepo = new UserRepository();
            UserEntity userEntity = new UserEntity(id: 123, name: "Jin", password: "qwer", desc: "employee");
            userRepo.Save(userEntity);

            UserAPIController userAPIController = new UserAPIController();
            userAPIController.PrintAPI(userEntity.ToDto().ToAPI());


            OperatorPractice operatorPractice = new OperatorPractice();
            operatorPractice.Main();


            EnumeratorPractice enumeratorPractice = new EnumeratorPractice();
            enumeratorPractice.Main();

            EtcPractice1 etcPractice1 = new EtcPractice1();
            etcPractice1.Main();

            EtcPractice2 etcPractice2 = new EtcPractice2();
            etcPractice2.Main();

            EtcPractice3 etcPractice3 = new EtcPractice3();
            etcPractice3.Main();

            EtcPractice4 etcPractice4 = new EtcPractice4();
            etcPractice4.Main();
        }
    }
}
