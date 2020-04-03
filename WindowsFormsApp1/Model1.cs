namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CHARACTER_WORK> CHARACTER_WORK { get; set; }
        public virtual DbSet<FAMILY_MEMBER> FAMILY_MEMBER { get; set; }
        public virtual DbSet<GENDER> GENDER { get; set; }
        public virtual DbSet<GRAZDAN> GRAZDAN { get; set; }
        public virtual DbSet<JOB_POSITION> JOB_POSITION { get; set; }
        public virtual DbSet<LANGUAGE> LANGUAGE { get; set; }
        public virtual DbSet<LANGUAGE_LVL> LANGUAGE_LVL { get; set; }
        public virtual DbSet<MARTIAL_STATUS> MARTIAL_STATUS { get; set; }
        public virtual DbSet<ONE_EDU> ONE_EDU { get; set; }
        public virtual DbSet<OUR_ORG> OUR_ORG { get; set; }
        public virtual DbSet<PEREVOD> PEREVOD { get; set; }
        public virtual DbSet<PERSONCARD> PERSONCARD { get; set; }
        public virtual DbSet<PLACE_EDU> PLACE_EDU { get; set; }
        public virtual DbSet<PLACE_TRIP> PLACE_TRIP { get; set; }
        public virtual DbSet<PODRAZDELORG> PODRAZDELORG { get; set; }
        public virtual DbSet<PRIEM> PRIEM { get; set; }
        public virtual DbSet<PRIKAZ> PRIKAZ { get; set; }
        public virtual DbSet<PROFESSION> PROFESSION { get; set; }
        public virtual DbSet<SHTAT_RASP> SHTAT_RASP { get; set; }
        public virtual DbSet<SPECIALTY> SPECIALTY { get; set; }
        public virtual DbSet<STR_SHTAT_RASP> STR_SHTAT_RASP { get; set; }
        public virtual DbSet<STR_TABEL> STR_TABEL { get; set; }
        public virtual DbSet<TABEL> TABEL { get; set; }
        public virtual DbSet<TRIP> TRIP { get; set; }
        public virtual DbSet<TRIP_ORG> TRIP_ORG { get; set; }
        public virtual DbSet<TYPE_EDU> TYPE_EDU { get; set; }
        public virtual DbSet<TYPE_PRIKAZ> TYPE_PRIKAZ { get; set; }
        public virtual DbSet<TYPE_WORK> TYPE_WORK { get; set; }
        public virtual DbSet<UVAL> UVAL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHARACTER_WORK>()
                .Property(e => e.PK_CHAR_WORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CHARACTER_WORK>()
                .Property(e => e.CHIPHER)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER_WORK>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER_WORK>()
                .HasMany(e => e.PRIEM)
                .WithRequired(e => e.CHARACTER_WORK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAMILY_MEMBER>()
                .Property(e => e.PK_MEMBER_FAMILY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FAMILY_MEMBER>()
                .Property(e => e.PK_PERSONCARD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FAMILY_MEMBER>()
                .Property(e => e.SURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<FAMILY_MEMBER>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<FAMILY_MEMBER>()
                .Property(e => e.MIDDLENAME)
                .IsUnicode(false);

            modelBuilder.Entity<GENDER>()
                .Property(e => e.PK_GENDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GENDER>()
                .Property(e => e.CIPHER)
                .IsUnicode(false);

            modelBuilder.Entity<GENDER>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GENDER>()
                .HasMany(e => e.PERSONCARD)
                .WithRequired(e => e.GENDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GRAZDAN>()
                .Property(e => e.PK_GRAZD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GRAZDAN>()
                .Property(e => e.CIPHER)
                .IsUnicode(false);

            modelBuilder.Entity<GRAZDAN>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB_POSITION>()
                .Property(e => e.PK_JOB_POS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<JOB_POSITION>()
                .Property(e => e.CIPHER)
                .IsUnicode(false);

            modelBuilder.Entity<JOB_POSITION>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB_POSITION>()
                .HasMany(e => e.PEREVOD)
                .WithRequired(e => e.JOB_POSITION)
                .HasForeignKey(e => e.PK_NEW_JOB_POS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JOB_POSITION>()
                .HasMany(e => e.PEREVOD1)
                .WithRequired(e => e.JOB_POSITION1)
                .HasForeignKey(e => e.PK_OLD_JOB_POS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JOB_POSITION>()
                .HasMany(e => e.PERSONCARD)
                .WithOptional(e => e.JOB_POSITION)
                .HasForeignKey(e => e.JOB_POSITION_PK_JOB_POS);

            modelBuilder.Entity<JOB_POSITION>()
                .HasMany(e => e.PRIEM)
                .WithRequired(e => e.JOB_POSITION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JOB_POSITION>()
                .HasMany(e => e.STR_SHTAT_RASP)
                .WithRequired(e => e.JOB_POSITION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JOB_POSITION>()
                .HasMany(e => e.UVAL)
                .WithRequired(e => e.JOB_POSITION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LANGUAGE>()
                .Property(e => e.PK_LANG_LVL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LANGUAGE>()
                .Property(e => e.CIPHER)
                .IsUnicode(false);

            modelBuilder.Entity<LANGUAGE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<LANGUAGE>()
                .Property(e => e.PK_LANG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LANGUAGE>()
                .HasMany(e => e.PERSONCARD)
                .WithOptional(e => e.LANGUAGE)
                .HasForeignKey(e => e.LANGUAGE_PK_LANG);

            modelBuilder.Entity<LANGUAGE_LVL>()
                .Property(e => e.PK_LANG_LVL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LANGUAGE_LVL>()
                .Property(e => e.CIPHER)
                .IsUnicode(false);

            modelBuilder.Entity<LANGUAGE_LVL>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<LANGUAGE_LVL>()
                .HasMany(e => e.LANGUAGE)
                .WithRequired(e => e.LANGUAGE_LVL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MARTIAL_STATUS>()
                .Property(e => e.PK_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MARTIAL_STATUS>()
                .Property(e => e.CIPHER)
                .IsUnicode(false);

            modelBuilder.Entity<MARTIAL_STATUS>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MARTIAL_STATUS>()
                .HasMany(e => e.PERSONCARD)
                .WithRequired(e => e.MARTIAL_STATUS)
                .HasForeignKey(e => e.PK_MARTIAL_STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ONE_EDU>()
                .Property(e => e.PK_PERSONCARD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ONE_EDU>()
                .Property(e => e.NUMDOC)
                .IsUnicode(false);

            modelBuilder.Entity<ONE_EDU>()
                .Property(e => e.PK_TYPE_EDU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ONE_EDU>()
                .Property(e => e.PK_PLACE_EDU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ONE_EDU>()
                .Property(e => e.PK_SPECIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ONE_EDU>()
                .Property(e => e.PK_ONE_EDU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OUR_ORG>()
                .Property(e => e.PK_OUR_ORG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OUR_ORG>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OUR_ORG>()
                .Property(e => e.INN)
                .IsUnicode(false);

            modelBuilder.Entity<OUR_ORG>()
                .Property(e => e.PAYMENTACC)
                .IsUnicode(false);

            modelBuilder.Entity<OUR_ORG>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<OUR_ORG>()
                .Property(e => e.OGRN)
                .IsUnicode(false);

            modelBuilder.Entity<OUR_ORG>()
                .Property(e => e.OKPO)
                .IsUnicode(false);

            modelBuilder.Entity<OUR_ORG>()
                .HasMany(e => e.PERSONCARD)
                .WithRequired(e => e.OUR_ORG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OUR_ORG>()
                .HasMany(e => e.PRIKAZ)
                .WithRequired(e => e.OUR_ORG)
                .WillCascadeOnDelete(false);
            
            modelBuilder.Entity<PERSONCARD>()
                .HasMany(e => e.PRIKAZ)
                .WithRequired(e => e.PERSONCARD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PEREVOD>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PEREVOD>()
                .Property(e => e.REASON)
                .IsUnicode(false);

            modelBuilder.Entity<PEREVOD>()
                .Property(e => e.PK_PERSONCARD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PEREVOD>()
                .Property(e => e.OLD_PODRAZDEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PEREVOD>()
                .Property(e => e.PK_OLD_JOB_POS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PEREVOD>()
                .Property(e => e.PK_NEW_JOB_POS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PEREVOD>()
                .Property(e => e.PK_NEW_PODRAZDEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.PK_PERSONCARD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.SURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.MIDDLENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.MOBTEL)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.DOPTEL)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.PK_OUR_ORG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.SERPASSPORT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.NUMPASSPORT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.PLACELIVE)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.PLACEREGISTER)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.PLACE_VIDACHI_PASSPORT)
                .IsUnicode(false);
            
            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.PLACEBIRTH)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.REASON_UVAL)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.DOPINFO)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.TABEL_NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.ALPHABET)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.INN)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.SNILS)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.PK_TABEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.PK_MARTIAL_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.PK_GENDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.PK_TYPE_WORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.PK_CHAR_WORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.PK_PROF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.PK_GRAZD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.JOB_POSITION_PK_JOB_POS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PERSONCARD>()
                .Property(e => e.LANGUAGE_PK_LANG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PERSONCARD>()
                .HasMany(e => e.FAMILY_MEMBER)
                .WithRequired(e => e.PERSONCARD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERSONCARD>()
                .HasMany(e => e.ONE_EDU)
                .WithRequired(e => e.PERSONCARD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERSONCARD>()
                .HasMany(e => e.PEREVOD)
                .WithRequired(e => e.PERSONCARD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERSONCARD>()
                .HasMany(e => e.TRIP)
                .WithMany(e => e.PERSONCARD)
                .Map(m => m.ToTable("PERSONCARD_TRIP", "ADMIN").MapLeftKey("PK_PERSONCARD").MapRightKey("PK_TRIP"));

            modelBuilder.Entity<PLACE_EDU>()
                .Property(e => e.PK_PLACE_EDU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PLACE_EDU>()
                .Property(e => e.CIPHER)
                .IsUnicode(false);

            modelBuilder.Entity<PLACE_EDU>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PLACE_EDU>()
                .HasMany(e => e.ONE_EDU)
                .WithRequired(e => e.PLACE_EDU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PLACE_TRIP>()
                .Property(e => e.PK_PLACE_TRIP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PLACE_TRIP>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PLACE_TRIP>()
                .HasMany(e => e.TRIP_ORG)
                .WithRequired(e => e.PLACE_TRIP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PLACE_TRIP>()
                .HasMany(e => e.TRIP)
                .WithMany(e => e.PLACE_TRIP)
                .Map(m => m.ToTable("TRIP_PLACETRIP", "ADMIN").MapLeftKey("PK_PLACE_TRIP").MapRightKey("PK_TRIP"));

            modelBuilder.Entity<PODRAZDELORG>()
                .Property(e => e.PK_PODRAZDEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PODRAZDELORG>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PODRAZDELORG>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PODRAZDELORG>()
                .HasMany(e => e.PEREVOD)
                .WithRequired(e => e.PODRAZDELORG)
                .HasForeignKey(e => e.OLD_PODRAZDEL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PODRAZDELORG>()
                .HasMany(e => e.PEREVOD1)
                .WithRequired(e => e.PODRAZDELORG1)
                .HasForeignKey(e => e.PK_NEW_PODRAZDEL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PODRAZDELORG>()
                .HasMany(e => e.PRIEM)
                .WithRequired(e => e.PODRAZDELORG)
                .HasForeignKey(e => e.PK_PODR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PODRAZDELORG>()
                .HasMany(e => e.STR_SHTAT_RASP)
                .WithRequired(e => e.PODRAZDELORG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PODRAZDELORG>()
                .HasMany(e => e.TABEL)
                .WithRequired(e => e.PODRAZDELORG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PODRAZDELORG>()
                .HasMany(e => e.UVAL)
                .WithRequired(e => e.PODRAZDELORG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRIEM>()
                .Property(e => e.REASON)
                .IsUnicode(false);

            modelBuilder.Entity<PRIEM>()
                .Property(e => e.PK_PODR)
                .HasPrecision(38, 0);
            

            modelBuilder.Entity<PRIEM>()
                .Property(e => e.TESTPERIOD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRIEM>()
                .Property(e => e.CONDITIONS)
                .IsUnicode(false);

            modelBuilder.Entity<PRIEM>()
                .Property(e => e.PK_JOB_POS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRIEM>()
                .Property(e => e.PK_PRIEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRIEM>()
                .Property(e => e.PK_CHAR_WORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRIEM>()
                .Property(e => e.PODRAZDELORG_PK_PODRAZDEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRIKAZ>()
                .Property(e => e.OKUD)
                .IsUnicode(false);

            modelBuilder.Entity<PRIKAZ>()
                .Property(e => e.OKPO)
                .IsUnicode(false);

            modelBuilder.Entity<PRIKAZ>()
                .Property(e => e.NUMDOC)
                .IsUnicode(false);

            modelBuilder.Entity<PRIKAZ>()
                .Property(e => e.PATH)
                .IsUnicode(false);

            modelBuilder.Entity<PRIKAZ>()
                .Property(e => e.PK_OUR_ORG)
                .HasPrecision(38, 0);
            
            modelBuilder.Entity<PRIKAZ>()
                .Property(e => e.PK_PERSONCARD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRIKAZ>()
                .Property(e => e.ISPROJECT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRIKAZ>()
                .Property(e => e.PK_TYPE_PRIKAZ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRIKAZ>()
                .HasMany(e => e.PEREVOD)
                .WithRequired(e => e.PRIKAZ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRIKAZ>()
                .HasMany(e => e.TRIP)
                .WithRequired(e => e.PRIKAZ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRIKAZ>()
                .HasMany(e => e.UVAL)
                .WithRequired(e => e.PRIKAZ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROFESSION>()
                .Property(e => e.PK_PROF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PROFESSION>()
                .Property(e => e.CIPHER)
                .IsUnicode(false);

            modelBuilder.Entity<PROFESSION>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SHTAT_RASP>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<SHTAT_RASP>()
                .HasMany(e => e.STR_SHTAT_RASP)
                .WithRequired(e => e.SHTAT_RASP)
                .HasForeignKey(e => e.SHTAT_RASP_PK_SHTAT_RASP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SPECIALTY>()
                .Property(e => e.PK_SPECIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SPECIALTY>()
                .Property(e => e.CIPHER)
                .IsUnicode(false);

            modelBuilder.Entity<SPECIALTY>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SPECIALTY>()
                .HasMany(e => e.ONE_EDU)
                .WithRequired(e => e.SPECIALTY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STR_SHTAT_RASP>()
                .Property(e => e.PK_PODRAZDEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STR_SHTAT_RASP>()
                .Property(e => e.PK_STROKA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STR_SHTAT_RASP>()
                .Property(e => e.COUNT_STUFF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STR_SHTAT_RASP>()
                .Property(e => e.TARIFF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STR_SHTAT_RASP>()
                .Property(e => e.NADBAVKA1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STR_SHTAT_RASP>()
                .Property(e => e.NADBAVKA2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STR_SHTAT_RASP>()
                .Property(e => e.NADBAVKA3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STR_SHTAT_RASP>()
                .Property(e => e.NOTE)
                .IsUnicode(false);

            modelBuilder.Entity<STR_SHTAT_RASP>()
                .Property(e => e.PK_JOB_POS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.PK_STR_TABEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY1)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY2)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY3)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY4)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY5)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY6)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.PK_TABEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY7)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY8)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY9)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY10)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY11)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY12)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY13)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY14)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY15)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY16)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY17)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY18)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY19)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY20)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY21)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY22)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY23)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY24)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY25)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY26)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY27)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY28)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY29)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY30)
                .IsUnicode(false);

            modelBuilder.Entity<STR_TABEL>()
                .Property(e => e.DAY31)
                .IsUnicode(false);

            modelBuilder.Entity<TABEL>()
                .Property(e => e.PK_TABEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABEL>()
                .Property(e => e.NUMDOC)
                .IsUnicode(false);

            modelBuilder.Entity<TABEL>()
                .Property(e => e.PK_PODRAZDEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABEL>()
                .HasMany(e => e.STR_TABEL)
                .WithRequired(e => e.TABEL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRIP>()
                .Property(e => e.PK_TRIP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRIP>()
                .Property(e => e.GOAL)
                .IsUnicode(false);

            modelBuilder.Entity<TRIP_ORG>()
                .Property(e => e.PK_TRIP_ORG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRIP_ORG>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TRIP_ORG>()
                .Property(e => e.PK_PLACE_TRIP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_EDU>()
                .Property(e => e.PK_TYPE_EDU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_EDU>()
                .Property(e => e.CIPHER)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_EDU>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_EDU>()
                .HasMany(e => e.ONE_EDU)
                .WithRequired(e => e.TYPE_EDU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TYPE_PRIKAZ>()
                .Property(e => e.PK_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_PRIKAZ>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_PRIKAZ>()
                .HasMany(e => e.PRIKAZ)
                .WithRequired(e => e.TYPE_PRIKAZ)
                .HasForeignKey(e => e.PK_TYPE_PRIKAZ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TYPE_WORK>()
                .Property(e => e.PK_TYPE_WORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_WORK>()
                .Property(e => e.PK_WORK)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_WORK>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<UVAL>()
                .Property(e => e.REASOM)
                .IsUnicode(false);

            modelBuilder.Entity<UVAL>()
                .Property(e => e.NUMWORKDOGOVOR)
                .IsUnicode(false);

            modelBuilder.Entity<UVAL>()
                .Property(e => e.PK_JOB_POS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<UVAL>()
                .Property(e => e.PK_PERSONCARD)
                .HasPrecision(38, 0);
        }
    }
}
