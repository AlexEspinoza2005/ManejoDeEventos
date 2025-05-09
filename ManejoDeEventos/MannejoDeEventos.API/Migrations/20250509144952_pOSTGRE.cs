using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MannejoDeEventos.API.Migrations
{
    /// <inheritdoc />
    public partial class pOSTGRE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    IdEvento = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    FechaInicio = table.Column<string>(type: "text", nullable: false),
                    FechaFin = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Lugar = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.IdEvento);
                });

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    IdParticipante = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Apellido = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: false),
                    Institucion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.IdParticipante);
                });

            migrationBuilder.CreateTable(
                name: "Ponentes",
                columns: table => new
                {
                    IdPonente = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Apellido = table.Column<string>(type: "text", nullable: false),
                    Institucion = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ponentes", x => x.IdPonente);
                });

            migrationBuilder.CreateTable(
                name: "Sesiones",
                columns: table => new
                {
                    IdSesion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    HoraInicio = table.Column<string>(type: "text", nullable: false),
                    HoraFin = table.Column<string>(type: "text", nullable: false),
                    Sala = table.Column<string>(type: "text", nullable: false),
                    IdEvento = table.Column<int>(type: "integer", nullable: false),
                    EventoIdEvento = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sesiones", x => x.IdSesion);
                    table.ForeignKey(
                        name: "FK_Sesiones_Eventos_EventoIdEvento",
                        column: x => x.EventoIdEvento,
                        principalTable: "Eventos",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inscripciones",
                columns: table => new
                {
                    IdInscripcion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FechaInscripcion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    IdParticipante = table.Column<int>(type: "integer", nullable: false),
                    ParticipanteIdParticipante = table.Column<int>(type: "integer", nullable: false),
                    IdEvento = table.Column<int>(type: "integer", nullable: false),
                    EventoIdEvento = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripciones", x => x.IdInscripcion);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Eventos_EventoIdEvento",
                        column: x => x.EventoIdEvento,
                        principalTable: "Eventos",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Participantes_ParticipanteIdParticipante",
                        column: x => x.ParticipanteIdParticipante,
                        principalTable: "Participantes",
                        principalColumn: "IdParticipante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventoSPonenteS",
                columns: table => new
                {
                    IdEventoPonente = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdEvento = table.Column<int>(type: "integer", nullable: false),
                    EventoIdEvento = table.Column<int>(type: "integer", nullable: false),
                    IdPonente = table.Column<int>(type: "integer", nullable: false),
                    PonenteIdPonente = table.Column<int>(type: "integer", nullable: false),
                    EventoPonenteIdEventoPonente = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventoSPonenteS", x => x.IdEventoPonente);
                    table.ForeignKey(
                        name: "FK_EventoSPonenteS_EventoSPonenteS_EventoPonenteIdEventoPonente",
                        column: x => x.EventoPonenteIdEventoPonente,
                        principalTable: "EventoSPonenteS",
                        principalColumn: "IdEventoPonente");
                    table.ForeignKey(
                        name: "FK_EventoSPonenteS_Eventos_EventoIdEvento",
                        column: x => x.EventoIdEvento,
                        principalTable: "Eventos",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventoSPonenteS_Ponentes_PonenteIdPonente",
                        column: x => x.PonenteIdPonente,
                        principalTable: "Ponentes",
                        principalColumn: "IdPonente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certificados",
                columns: table => new
                {
                    IdCertificado = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FechaEmision = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IdInscripcion = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificados", x => x.IdCertificado);
                    table.ForeignKey(
                        name: "FK_Certificados_Inscripciones_IdInscripcion",
                        column: x => x.IdInscripcion,
                        principalTable: "Inscripciones",
                        principalColumn: "IdInscripcion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    IdPago = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FechaPago = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Monto = table.Column<decimal>(type: "numeric", nullable: false),
                    MedioPago = table.Column<string>(type: "text", nullable: false),
                    IdInscripcion = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.IdPago);
                    table.ForeignKey(
                        name: "FK_Pagos_Inscripciones_IdInscripcion",
                        column: x => x.IdInscripcion,
                        principalTable: "Inscripciones",
                        principalColumn: "IdInscripcion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certificados_IdInscripcion",
                table: "Certificados",
                column: "IdInscripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventoSPonenteS_EventoIdEvento",
                table: "EventoSPonenteS",
                column: "EventoIdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_EventoSPonenteS_EventoPonenteIdEventoPonente",
                table: "EventoSPonenteS",
                column: "EventoPonenteIdEventoPonente");

            migrationBuilder.CreateIndex(
                name: "IX_EventoSPonenteS_PonenteIdPonente",
                table: "EventoSPonenteS",
                column: "PonenteIdPonente");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_EventoIdEvento",
                table: "Inscripciones",
                column: "EventoIdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_ParticipanteIdParticipante",
                table: "Inscripciones",
                column: "ParticipanteIdParticipante");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdInscripcion",
                table: "Pagos",
                column: "IdInscripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sesiones_EventoIdEvento",
                table: "Sesiones",
                column: "EventoIdEvento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificados");

            migrationBuilder.DropTable(
                name: "EventoSPonenteS");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Sesiones");

            migrationBuilder.DropTable(
                name: "Ponentes");

            migrationBuilder.DropTable(
                name: "Inscripciones");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Participantes");
        }
    }
}
