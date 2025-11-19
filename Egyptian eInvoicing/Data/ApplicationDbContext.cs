// Data/ApplicationDbContext.cs (الكود النهائي)
using Egyptian_eInvoicing.Models.Lines;
using Egyptian_eInvoicing.Models.Structures;
using Egyptian_eInvoicing.Models.Tax;
using Microsoft.EntityFrameworkCore;
using Egyptian_eInvoicing.Models;

namespace Egyptian_eInvoicing.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        // ... Constructors and DbSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- علاقات One-to-Many (Document <-> Lines) ---

            // 1. علاقة Document مع InvoiceLine
            modelBuilder.Entity<Document>()
                .HasMany(d => d.InvoiceLines)
                .WithOne(il => il.Document) // il.Document هي خاصية المرجع في InvoiceLine
                .HasForeignKey(il => il.DocumentId) // DocumentId هو المفتاح الخارجي في InvoiceLine
                .OnDelete(DeleteBehavior.Cascade);

            // 2. علاقة InvoiceLine مع TaxableItem
            modelBuilder.Entity<TaxableItem>()
                .HasOne(l => l.InvoiceLine)
                .WithMany(x => x.TaxableItems) // لا يوجد خاصية مرجع في TaxableItem
                .HasForeignKey(ti => ti.InvoiceLineId) // المفتاح الخارجي
                .OnDelete(DeleteBehavior.Cascade);

            // 3. علاقة Document مع TaxTotal
            modelBuilder.Entity<TaxTotal>()
                .HasOne(d => d.Document)
                .WithMany()
                .HasForeignKey(tt => tt.DocumentId) // المفتاح الخارجي
                .OnDelete(DeleteBehavior.Cascade);

            // --- علاقات One-to-One (Document <-> Parties) ---

            // 4. علاقة Document مع Issuer
            modelBuilder.Entity<Document>()
                .HasOne(d => d.Issuer)
                .WithMany()
                .HasForeignKey(x => x.IssureId)
                //.HasForeignKey<Issuer>(i => i.DocumentId) // FK موجود في Issuer
                .OnDelete(DeleteBehavior.Cascade);

            // 5. علاقة Document مع Receiver
            modelBuilder.Entity<Document>()
                .HasOne(d => d.Receiver)
                .WithMany()
                .HasForeignKey(x => x.ReceiverId)
                //.HasPrincipalKey(r => r.DocumentId) // FK موجود في Receiver
                .IsRequired(false) // لأن Receiver قد لا يكون إلزامياً
                .OnDelete(DeleteBehavior.Cascade);

            // --- علاقة One-to-One (InvoiceLine <-> UnitValue) ---

            // 6. علاقة InvoiceLine مع UnitValue
            modelBuilder.Entity<UnitValue>()
                .HasOne(x => x.InvoiceLine)
                .WithMany()
                .HasForeignKey(uv => uv.InvoiceLineId) // FK موجود في UnitValue
                .IsRequired();

            // 7. علاقة Issuer/Receiver Address (One-to-One)
            // (بافتراض أن Address هي كلاسات منفصلة ولها FKs تشير إلى Issuer/Receiver)
            // إذا كان Address هو Owned Type، لا حاجة لهذه الأسطر. لكن إذا كان DbSet، سنحتاجها.

            // مثال لـ Issuer Address (بافتراض أن IssuerAddress لها FK اسمه IssuerId)
            modelBuilder.Entity<Issuer>()
                .HasOne(i => i.Address)
                .WithMany()
                .HasForeignKey(fk => fk.AddressId)
                .IsRequired();
        }
    }
}