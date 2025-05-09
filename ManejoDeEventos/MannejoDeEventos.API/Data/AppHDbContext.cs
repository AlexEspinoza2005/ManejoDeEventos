using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManejoDeEventos;

    public class AppHDbContext : DbContext
    {
        public AppHDbContext (DbContextOptions<AppHDbContext> options)
            : base(options)
        {
        }

        public DbSet<ManejoDeEventos.Certificado> Certificados { get; set; } = default!;

public DbSet<ManejoDeEventos.Evento> Eventos { get; set; } = default!;

public DbSet<ManejoDeEventos.Inscripcion> Inscripciones { get; set; } = default!;

public DbSet<ManejoDeEventos.Pago> Pagos { get; set; } = default!;

public DbSet<ManejoDeEventos.Participante> Participantes { get; set; } = default!;

public DbSet<ManejoDeEventos.EventoPonente> EventoSPonenteS { get; set; } = default!;

public DbSet<ManejoDeEventos.Ponente> Ponentes { get; set; } = default!;

public DbSet<ManejoDeEventos.Sesion> Sesiones { get; set; } = default!;
    }
