<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using ManejoDeEventos;
using ManejoDeEventos.API.Consumer;

namespace ManejoDeEventosTest
=======
﻿namespace ManejoDeEventosTest
>>>>>>> b2e9dc3 (Add version 1.1)
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            ProbarParticipantes();
            ProbarEventos();
            ProbarPonentes();
            //ProbarCertificados();
            Console.ReadLine();
        }

        private static void ProbarParticipantes()
        {
            Crud<Participante>.EndPoint = "https://localhost:7201/api/Participantes";

            var participante = Crud<Participante>.Create(new Participante
            {
                IdParticipante = 0,
                Nombre = "Ana",
                Apellido = "González",
                Email = "ana.gonzalez@example.com",
                Telefono = "0991234567",
                Institucion = "UTN"
            });

            participante.Nombre = "Ana Actualizada";
            Crud<Participante>.Update(participante.IdParticipante, participante);

            var participantes = Crud<Participante>.GetAll();

            foreach (var p in participantes)
            {
                Console.WriteLine($"Id: {p.IdParticipante}, Nombre: {p.Nombre}, Apellido: {p.Apellido}, Email: {p.Email}, Teléfono: {p.Telefono}, Institución: {p.Institucion}");
            }
        }


        private static void ProbarEventos()
        {
            Crud<Evento>.EndPoint = "https://localhost:7201/api/Eventos";

            var evento = Crud<Evento>.Create(new Evento
            {
                IdEvento = 0,
                Nombre = "Ciencia",
                FechaInicio = "09/05/2025",
                FechaFin = "12/12/2030",
                Tipo = "Académico",
                Lugar = "Auditorio UTN"
            });

            evento.Nombre = "Ciencia Actualizado";
            Crud<Evento>.Update(evento.IdEvento, evento);

            var eventos = Crud<Evento>.GetAll();

            foreach (var e in eventos)
            {
                Console.WriteLine($"IdEvento: {e.IdEvento}, Nombre: {e.Nombre}, FechaInicio: {e.FechaInicio}, FechaFin: {e.FechaFin}, Tipo: {e.Tipo}, Lugar: {e.Lugar}");
            }
        }

        private static void ProbarPonentes()
        {
            Crud<Ponente>.EndPoint = "https://localhost:7201/api/Ponentes";

            var ponente = Crud<Ponente>.Create(new Ponente
            {
                IdPonente = 0,
                Nombre = "Juan",
                Apellido = "Pérez",
                Institucion = "UTN",
                Email = "juan.perez@example.com"
            });

            ponente.Nombre = "Juan Actualizado";
            Crud<Ponente>.Update(ponente.IdPonente, ponente);

            var ponentes = Crud<Ponente>.GetAll();

            foreach (var p in ponentes)
            {
                Console.WriteLine($"IdPonente: {p.IdPonente}, Nombre: {p.Nombre}, Apellido: {p.Apellido}, Institucion: {p.Institucion}, Email: {p.Email}");
            }
        }



        private static void ProbarCertificados()
        {
            Crud<Certificado>.EndPoint = "https://localhost:7201/api/Certificados";

            var certificado = Crud<Certificado>.Create(new Certificado
            {
                IdCertificado = 0,
                FechaEmision = DateTime.Now,
                IdInscripcion = 1 // Asumiendo que ya existe una inscripción con Id = 1
            });

            certificado.FechaEmision = DateTime.Now.AddMonths(1);
            Crud<Certificado>.Update(certificado.IdCertificado, certificado);

            var certificados = Crud<Certificado>.GetAll();

            foreach (var c in certificados)
            {
                Console.WriteLine($"IdCertificado: {c.IdCertificado}, FechaEmision: {c.FechaEmision}, IdInscripcion: {c.IdInscripcion}");
            }
        }

=======
            Console.WriteLine("Hello, World!");
        }
>>>>>>> b2e9dc3 (Add version 1.1)
    }
}
