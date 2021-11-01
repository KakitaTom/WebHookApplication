using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class akaBizAutoDbContext : DbContext
    {
        public akaBizAutoDbContext()
        {
        }

        public akaBizAutoDbContext(DbContextOptions<akaBizAutoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccCategory> AccCategories { get; set; }
        public virtual DbSet<AccDeposit> AccDeposits { get; set; }
        public virtual DbSet<AccPackage> AccPackages { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AkaBizSendEmailNoti> AkaBizSendEmailNotis { get; set; }
        public virtual DbSet<AkaBizSetting> AkaBizSettings { get; set; }
        public virtual DbSet<AkaBizSmtp> AkaBizSmtps { get; set; }
        public virtual DbSet<AkabizApiConnect> AkabizApiConnects { get; set; }
        public virtual DbSet<AutoAccount> AutoAccounts { get; set; }
        public virtual DbSet<AutoAutomate> AutoAutomates { get; set; }
        public virtual DbSet<AutoCampaign> AutoCampaigns { get; set; }
        public virtual DbSet<AutoCampaignAction> AutoCampaignActions { get; set; }
        public virtual DbSet<AutoCampaignDetail> AutoCampaignDetails { get; set; }
        public virtual DbSet<AutoCampaignDetailStatusByAction> AutoCampaignDetailStatusByActions { get; set; }
        public virtual DbSet<AutoGetDataType> AutoGetDataTypes { get; set; }
        public virtual DbSet<AutoLimit> AutoLimits { get; set; }
        public virtual DbSet<AutoLogApp> AutoLogApps { get; set; }
        public virtual DbSet<AutoShop> AutoShops { get; set; }
        public virtual DbSet<AutoShopCategory> AutoShopCategories { get; set; }
        public virtual DbSet<AutoShopContact> AutoShopContacts { get; set; }
        public virtual DbSet<AutoShopNotification> AutoShopNotifications { get; set; }
        public virtual DbSet<AutoShopType> AutoShopTypes { get; set; }
        public virtual DbSet<AutoTimeSetting> AutoTimeSettings { get; set; }
        public virtual DbSet<CampaignDetail> CampaignDetails { get; set; }
        public virtual DbSet<CampaignType> CampaignTypes { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<ConIndustry> ConIndustries { get; set; }
        public virtual DbSet<ConSplitDatum> ConSplitData { get; set; }
        public virtual DbSet<ConWork> ConWorks { get; set; }
        public virtual DbSet<Condition> Conditions { get; set; }
        public virtual DbSet<ConditionContact> ConditionContacts { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<CronLog> CronLogs { get; set; }
        public virtual DbSet<CusGroup> CusGroups { get; set; }
        public virtual DbSet<CusGroupDetail> CusGroupDetails { get; set; }
        public virtual DbSet<DeaAction> DeaActions { get; set; }
        public virtual DbSet<DeaActivity> DeaActivities { get; set; }
        public virtual DbSet<DeaHistory> DeaHistories { get; set; }
        public virtual DbSet<DeaPipeline> DeaPipelines { get; set; }
        public virtual DbSet<DeaReason> DeaReasons { get; set; }
        public virtual DbSet<DeaResult> DeaResults { get; set; }
        public virtual DbSet<Deal> Deals { get; set; }
        public virtual DbSet<DealTag> DealTags { get; set; }
        public virtual DbSet<DepositHistory> DepositHistories { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Error> Errors { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<FileDetail> FileDetails { get; set; }
        public virtual DbSet<FilterCondition> FilterConditions { get; set; }
        public virtual DbSet<FilterConditionField> FilterConditionFields { get; set; }
        public virtual DbSet<FilterCustomer> FilterCustomers { get; set; }
        public virtual DbSet<FilterField> FilterFields { get; set; }
        public virtual DbSet<FilterGroup> FilterGroups { get; set; }
        public virtual DbSet<GetNewId> GetNewIds { get; set; }
        public virtual DbSet<HubMapApi> HubMapApis { get; set; }
        public virtual DbSet<Keyword> Keywords { get; set; }
        public virtual DbSet<LatestShopOrder> LatestShopOrders { get; set; }
        public virtual DbSet<MailCampaign> MailCampaigns { get; set; }
        public virtual DbSet<MailComment> MailComments { get; set; }
        public virtual DbSet<MailConfigEmailParner> MailConfigEmailParners { get; set; }
        public virtual DbSet<MailConfigSmsPartner> MailConfigSmsPartners { get; set; }
        public virtual DbSet<MailConfigSmtp> MailConfigSmtps { get; set; }
        public virtual DbSet<MailContentTemplate> MailContentTemplates { get; set; }
        public virtual DbSet<MailDeviceMobile> MailDeviceMobiles { get; set; }
        public virtual DbSet<MailLink> MailLinks { get; set; }
        public virtual DbSet<MailLinkContentTemplate> MailLinkContentTemplates { get; set; }
        public virtual DbSet<MailMessageSm> MailMessageSms { get; set; }
        public virtual DbSet<MailPersonalized> MailPersonalizeds { get; set; }
        public virtual DbSet<MailSendSumOfDay> MailSendSumOfDays { get; set; }
        public virtual DbSet<MailSendSumOfMonth> MailSendSumOfMonths { get; set; }
        public virtual DbSet<MailSending> MailSendings { get; set; }
        public virtual DbSet<MailSendingConfigSmtp> MailSendingConfigSmtps { get; set; }
        public virtual DbSet<MailSendingContact> MailSendingContacts { get; set; }
        public virtual DbSet<MailSendingContactStatusByEventType> MailSendingContactStatusByEventTypes { get; set; }
        public virtual DbSet<MailSendingEventType> MailSendingEventTypes { get; set; }
        public virtual DbSet<MailSource> MailSources { get; set; }
        public virtual DbSet<MailTemplate> MailTemplates { get; set; }
        public virtual DbSet<MailTrigger> MailTriggers { get; set; }
        public virtual DbSet<MailTriggerType> MailTriggerTypes { get; set; }
        public virtual DbSet<MailTriggerTypeInput> MailTriggerTypeInputs { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<OrdDiscount> OrdDiscounts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<OrderUpdateStatus> OrderUpdateStatuses { get; set; }
        public virtual DbSet<PhoneNumberReceive> PhoneNumberReceives { get; set; }
        public virtual DbSet<PricePerMessage> PricePerMessages { get; set; }
        public virtual DbSet<ProCategory> ProCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductVariant> ProductVariants { get; set; }
        public virtual DbSet<Queue> Queues { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SdAction> SdActions { get; set; }
        public virtual DbSet<SdCampaign> SdCampaigns { get; set; }
        public virtual DbSet<SdFacebookActionType> SdFacebookActionTypes { get; set; }
        public virtual DbSet<SdFacebookType> SdFacebookTypes { get; set; }
        public virtual DbSet<SdTimeDivision> SdTimeDivisions { get; set; }
        public virtual DbSet<SdTimeType> SdTimeTypes { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<ShopChatbot> ShopChatbots { get; set; }
        public virtual DbSet<ShopConnectionType> ShopConnectionTypes { get; set; }
        public virtual DbSet<ShopEcomAuto> ShopEcomAutos { get; set; }
        public virtual DbSet<ShopFeedback> ShopFeedbacks { get; set; }
        public virtual DbSet<ShopReplyFeedback> ShopReplyFeedbacks { get; set; }
        public virtual DbSet<SmsSending> SmsSendings { get; set; }
        public virtual DbSet<SmsSendingContact> SmsSendingContacts { get; set; }
        public virtual DbSet<SmsTemplate> SmsTemplates { get; set; }
        public virtual DbSet<StaffRole> StaffRoles { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TagCompany> TagCompanies { get; set; }
        public virtual DbSet<TagContact> TagContacts { get; set; }
        public virtual DbSet<TagTable> TagTables { get; set; }
        public virtual DbSet<Webhook> Webhooks { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=13.212.88.90;Database=akabiz2;Trusted_Connection=False;user id=nhutlq;password=123456aA@;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AccCategory>(entity =>
            {
                entity.ToTable("accCategory");
            });

            modelBuilder.Entity<AccDeposit>(entity =>
            {
                entity.ToTable("accDeposit");

                entity.Property(e => e.AmountUsed).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateDeposit).HasColumnType("datetime");

                entity.Property(e => e.Describe).HasMaxLength(4000);

                entity.Property(e => e.MoneyDeposit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PaymentCode).HasMaxLength(50);

                entity.Property(e => e.ShopType).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<AccPackage>(entity =>
            {
                entity.ToTable("accPackage");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountCode).HasMaxLength(10);

                entity.Property(e => e.AccountPackage).HasMaxLength(50);

                entity.Property(e => e.ApiKey).HasMaxLength(50);

                entity.Property(e => e.Career).HasMaxLength(500);

                entity.Property(e => e.ContactAdress).HasMaxLength(1000);

                entity.Property(e => e.ContactEmail).HasMaxLength(50);

                entity.Property(e => e.ContactMobile).HasMaxLength(50);

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.DaiLyCode).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.EmailContactSub).HasMaxLength(100);

                entity.Property(e => e.EmailRecievedSmsReply).HasMaxLength(100);

                entity.Property(e => e.EmployeeSize).HasMaxLength(50);

                entity.Property(e => e.IddaiLy).HasColumnName("IDDaiLy");

                entity.Property(e => e.KeyMac).HasMaxLength(50);

                entity.Property(e => e.LoginKey).HasMaxLength(50);

                entity.Property(e => e.MacAdress).HasMaxLength(50);

                entity.Property(e => e.MacMobile).HasMaxLength(50);

                entity.Property(e => e.Money).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.OrderSize).HasMaxLength(50);

                entity.Property(e => e.Pass).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.ProductIdListString).HasMaxLength(50);

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.StoreAddress).HasMaxLength(1000);

                entity.Property(e => e.StoreHotline).HasMaxLength(20);

                entity.Property(e => e.StoreLazada).HasMaxLength(200);

                entity.Property(e => e.StoreLinkMessage).HasMaxLength(200);

                entity.Property(e => e.StoreName).HasMaxLength(500);

                entity.Property(e => e.StorePage).HasMaxLength(200);

                entity.Property(e => e.StoreSendo).HasMaxLength(200);

                entity.Property(e => e.StoreShopee).HasMaxLength(200);

                entity.Property(e => e.StoreWeb).HasMaxLength(200);

                entity.Property(e => e.StoreZalo).HasMaxLength(50);

                entity.Property(e => e.SumMoneyDepositSmsApi).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SumMoneyRestSmsApi).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TypeString).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.ZaloSocial).HasMaxLength(20);
            });

            modelBuilder.Entity<AkaBizSendEmailNoti>(entity =>
            {
                entity.ToTable("AkaBizSendEmailNoti");

                entity.Property(e => e.DateSendExpected).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);
            });

            modelBuilder.Entity<AkaBizSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AkaBizSetting");

                entity.Property(e => e.FacebookVersion).HasMaxLength(50);

                entity.Property(e => e.PackageMonthCombo).HasColumnName("PackageMonth_Combo");

                entity.Property(e => e.PackageMonthFacebook).HasColumnName("PackageMonth_Facebook");

                entity.Property(e => e.PackageMonthSms).HasColumnName("PackageMonth_Sms");

                entity.Property(e => e.PackageMonthZalo).HasColumnName("PackageMonth_Zalo");
            });

            modelBuilder.Entity<AkaBizSmtp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AkaBizSMTP");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.ServerName).HasMaxLength(150);

                entity.Property(e => e.Username).HasMaxLength(100);
            });

            modelBuilder.Entity<AkabizApiConnect>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AkabizApiConnect");

                entity.Property(e => e.KeyName).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<AutoAccount>(entity =>
            {
                entity.ToTable("autoAccount");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.MacAdress).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<AutoAutomate>(entity =>
            {
                entity.ToTable("autoAutomate");

                entity.Property(e => e.CampaignActionId).HasMaxLength(50);

                entity.HasOne(d => d.CampaignAction)
                    .WithMany(p => p.AutoAutomates)
                    .HasForeignKey(d => d.CampaignActionId)
                    .HasConstraintName("FK_autoAutomate_autoCampaignAction");

                entity.HasOne(d => d.ShopCategory)
                    .WithMany(p => p.AutoAutomates)
                    .HasForeignKey(d => d.ShopCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_autoAutomate_autoShopCategory");
            });

            modelBuilder.Entity<AutoCampaign>(entity =>
            {
                entity.ToTable("autoCampaign");

                entity.Property(e => e.CampaignActionId).HasMaxLength(50);

                entity.Property(e => e.CommentContent).HasColumnType("ntext");

                entity.Property(e => e.CommentMedia).HasMaxLength(4000);

                entity.Property(e => e.ContentMessage).HasColumnType("ntext");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateEdit).HasColumnType("datetime");

                entity.Property(e => e.EmailSubject).HasMaxLength(4000);

                entity.Property(e => e.FanpageUid).HasMaxLength(4000);

                entity.Property(e => e.FolderMedia).HasMaxLength(4000);

                entity.Property(e => e.Image).HasMaxLength(4000);

                entity.Property(e => e.Link).HasMaxLength(1000);

                entity.Property(e => e.LinkUidAutoGetContentPost).HasMaxLength(4000);

                entity.Property(e => e.Media).HasMaxLength(4000);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Schedule).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(200);

                entity.Property(e => e.TriggerType).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AutoCampaigns)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_autoCampaign_Account");

                entity.HasOne(d => d.CampaignAction)
                    .WithMany(p => p.AutoCampaigns)
                    .HasForeignKey(d => d.CampaignActionId)
                    .HasConstraintName("FK_autoCampaign_autoCampaignAction");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.AutoCampaigns)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_autoCampaign_Shop");
            });

            modelBuilder.Entity<AutoCampaignAction>(entity =>
            {
                entity.ToTable("autoCampaignAction");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ShopType).HasMaxLength(50);
            });

            modelBuilder.Entity<AutoCampaignDetail>(entity =>
            {
                entity.ToTable("autoCampaignDetail");

                entity.Property(e => e.DateClick).HasColumnType("datetime");

                entity.Property(e => e.DateOpen).HasColumnType("datetime");

                entity.Property(e => e.DateProcessed).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.DateSendExpected).HasColumnType("datetime");

                entity.Property(e => e.DateUpdateStatus).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.ErrorMessage).HasColumnType("ntext");

                entity.Property(e => e.Name).HasMaxLength(4000);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PostLink).HasMaxLength(4000);

                entity.Property(e => e.Uid).HasMaxLength(4000);
            });

            modelBuilder.Entity<AutoCampaignDetailStatusByAction>(entity =>
            {
                entity.HasKey(e => new { e.Status, e.CampaignActionId });

                entity.ToTable("autoCampaignDetailStatusByAction");

                entity.Property(e => e.CampaignActionId).HasMaxLength(50);
            });

            modelBuilder.Entity<AutoGetDataType>(entity =>
            {
                entity.ToTable("autoGetDataType");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.ShopType).HasMaxLength(50);
            });

            modelBuilder.Entity<AutoLimit>(entity =>
            {
                entity.ToTable("autoLimit");

                entity.Property(e => e.CampaignAction).HasMaxLength(50);
            });

            modelBuilder.Entity<AutoLogApp>(entity =>
            {
                entity.ToTable("autoLogApp");

                entity.Property(e => e.ActionName).HasMaxLength(500);

                entity.Property(e => e.ClassName).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Describe).HasMaxLength(4000);

                entity.Property(e => e.Exception).HasColumnType("ntext");

                entity.Property(e => e.FunctionName).HasMaxLength(50);

                entity.Property(e => e.ModuleName).HasMaxLength(50);
            });

            modelBuilder.Entity<AutoShop>(entity =>
            {
                entity.ToTable("autoShop");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Ho).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(200);

                entity.Property(e => e.PathProfileChrome).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProfileFolderName).HasMaxLength(50);

                entity.Property(e => e.Proxy).HasMaxLength(50);

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(200);

                entity.Property(e => e.Username).HasMaxLength(200);
            });

            modelBuilder.Entity<AutoShopCategory>(entity =>
            {
                entity.ToTable("autoShopCategory");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.ShopType).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AutoShopCategories)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_autoShopCategory_Account");
            });

            modelBuilder.Entity<AutoShopContact>(entity =>
            {
                entity.ToTable("autoShopContact");

                entity.Property(e => e.ContactKey).HasMaxLength(50);

                entity.Property(e => e.ContactName).HasMaxLength(500);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Uid).HasMaxLength(200);

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.AutoShopContacts)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_autoShopContact_Shop");
            });

            modelBuilder.Entity<AutoShopNotification>(entity =>
            {
                entity.ToTable("autoShopNotification");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Notify).HasColumnType("ntext");

                entity.Property(e => e.Type).HasMaxLength(100);
            });

            modelBuilder.Entity<AutoShopType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("autoShopType");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ShopType).HasMaxLength(50);
            });

            modelBuilder.Entity<AutoTimeSetting>(entity =>
            {
                entity.HasKey(e => e.TypeAction);

                entity.ToTable("autoTimeSetting");

                entity.Property(e => e.TypeAction).HasMaxLength(50);
            });

            modelBuilder.Entity<CampaignDetail>(entity =>
            {
                entity.ToTable("CampaignDetail");

                entity.Property(e => e.ActionCondition).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.CampaignDetails)
                    .HasForeignKey(d => d.CampaignId)
                    .HasConstraintName("FK_CampaignDetail_mailCampaigns");
            });

            modelBuilder.Entity<CampaignType>(entity =>
            {
                entity.ToTable("CampaignType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("City");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.Adress).HasMaxLength(1000);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.District).HasMaxLength(100);

                entity.Property(e => e.Domain).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Industry).HasMaxLength(200);

                entity.Property(e => e.LinkedIn).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Tag).HasMaxLength(1000);

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.Zipcode).HasMaxLength(10);

                entity.HasOne(d => d.StaffOwnerNavigation)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.StaffOwner)
                    .HasConstraintName("FK_Company_Staff");
            });

            modelBuilder.Entity<ConIndustry>(entity =>
            {
                entity.ToTable("conIndustry");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<ConSplitDatum>(entity =>
            {
                entity.Property(e => e.KeyWordSplit).HasMaxLength(500);
            });

            modelBuilder.Entity<ConWork>(entity =>
            {
                entity.ToTable("ConWork");

                entity.Property(e => e.DateCalendar).HasColumnType("datetime");

                entity.Property(e => e.DateComplete).HasColumnType("datetime");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Message).HasColumnType("ntext");

                entity.Property(e => e.Name).HasColumnType("ntext");

                entity.Property(e => e.Note).HasColumnType("ntext");
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.Property(e => e.ConditionFields).HasMaxLength(50);

                entity.Property(e => e.ConditionRelationship).HasMaxLength(50);

                entity.Property(e => e.ConditionTable).HasMaxLength(50);

                entity.Property(e => e.ConditionType).HasMaxLength(50);

                entity.Property(e => e.ConditionValue).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.HasOne(d => d.Sending)
                    .WithMany(p => p.Conditions)
                    .HasForeignKey(d => d.SendingId)
                    .HasConstraintName("FK_Conditions_mailSending");
            });

            modelBuilder.Entity<ConditionContact>(entity =>
            {
                entity.ToTable("ConditionContact");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateOrderAfter).HasColumnType("datetime");

                entity.Property(e => e.DateOrderBefore).HasColumnType("datetime");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.TagListStringContain).HasMaxLength(50);

                entity.Property(e => e.TagListStringNotContain).HasMaxLength(50);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.Adress).HasMaxLength(1000);

                entity.Property(e => e.AverragePageviews)
                    .HasMaxLength(50)
                    .HasColumnName("Averrage_Pageviews");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(50)
                    .HasColumnName("CMND");

                entity.Property(e => e.CompanyName).HasMaxLength(1000);

                entity.Property(e => e.ContactHubSpotId).HasMaxLength(50);

                entity.Property(e => e.ContactShopeeCode).HasMaxLength(50);

                entity.Property(e => e.ContentUpdateHubSpot).HasColumnType("ntext");

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DateNextWork).HasColumnType("datetime");

                entity.Property(e => e.DateRequest).HasColumnType("datetime");

                entity.Property(e => e.Describe).HasMaxLength(4000);

                entity.Property(e => e.District).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmailList).HasMaxLength(500);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FirstPageSeen)
                    .HasMaxLength(1000)
                    .HasColumnName("First_Page_Seen");

                entity.Property(e => e.FirstReferringSite)
                    .HasMaxLength(1000)
                    .HasColumnName("First_Referring_Site");

                entity.Property(e => e.KeyWordSplit).HasMaxLength(500);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LastPageSeen)
                    .HasMaxLength(1000)
                    .HasColumnName("Last_Page_Seen");

                entity.Property(e => e.LastReferringSite)
                    .HasMaxLength(1000)
                    .HasColumnName("Last_Referring_Site");

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.MobileList).HasMaxLength(500);

                entity.Property(e => e.NumberOfFormSubmissions).HasColumnName("Number_Of_Form_Submissions");

                entity.Property(e => e.OriginalSorce)
                    .HasMaxLength(500)
                    .HasColumnName("Original_Sorce");

                entity.Property(e => e.OriginalSorceDrillDown1)
                    .HasMaxLength(500)
                    .HasColumnName("Original_Sorce_Drill_Down_1");

                entity.Property(e => e.OriginalSorceDrillDown2)
                    .HasMaxLength(500)
                    .HasColumnName("Original_Sorce_Drill_Down_2");

                entity.Property(e => e.RecenConversion)
                    .HasMaxLength(50)
                    .HasColumnName("Recen_Conversion");

                entity.Property(e => e.RecenConversionData)
                    .HasColumnType("datetime")
                    .HasColumnName("Recen_Conversion_Data");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.StaffOwnerName).HasMaxLength(200);

                entity.Property(e => e.StatusInCrm)
                    .HasMaxLength(50)
                    .HasColumnName("StatusInCRM");

                entity.Property(e => e.SumSms).HasColumnName("SumSMS");

                entity.Property(e => e.Tag).HasMaxLength(1000);

                entity.Property(e => e.TagNameList).HasMaxLength(1000);

                entity.Property(e => e.Uid).HasMaxLength(4000);

                entity.Property(e => e.Vocative).HasMaxLength(50);

                entity.Property(e => e.Zalo).HasMaxLength(20);

                entity.Property(e => e.Zipcode).HasMaxLength(10);
            });

            modelBuilder.Entity<CronLog>(entity =>
            {
                entity.ToTable("CronLog");

                entity.Property(e => e.LatestTime).HasColumnType("datetime");

                entity.Property(e => e.ShopeType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<CusGroup>(entity =>
            {
                entity.ToTable("CusGroup");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CusGroupDetail>(entity =>
            {
                entity.ToTable("CusGroupDetail");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.HasOne(d => d.CusGroup)
                    .WithMany(p => p.CusGroupDetails)
                    .HasForeignKey(d => d.CusGroupId)
                    .HasConstraintName("FK_CusGroupDetail_CusGroup");
            });

            modelBuilder.Entity<DeaAction>(entity =>
            {
                entity.ToTable("deaAction");

                entity.Property(e => e.Id).HasMaxLength(50);
            });

            modelBuilder.Entity<DeaActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("deaActivity");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<DeaHistory>(entity =>
            {
                entity.ToTable("deaHistory");

                entity.Property(e => e.ActivityId).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateRequest).HasColumnType("datetime");

                entity.Property(e => e.DateRequestComplete).HasColumnType("datetime");

                entity.Property(e => e.Describe).HasMaxLength(4000);

                entity.HasOne(d => d.Deals)
                    .WithMany(p => p.DeaHistories)
                    .HasForeignKey(d => d.DealsId)
                    .HasConstraintName("FK_deaHistory_Deals");
            });

            modelBuilder.Entity<DeaPipeline>(entity =>
            {
                entity.ToTable("deaPipeline");

                entity.Property(e => e.ColorStage).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<DeaReason>(entity =>
            {
                entity.ToTable("deaReason");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<DeaResult>(entity =>
            {
                entity.ToTable("deaResult");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<Deal>(entity =>
            {
                entity.Property(e => e.DateAgain).HasColumnType("datetime");

                entity.Property(e => e.DateClose).HasColumnType("datetime");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DateNextPlan).HasColumnType("datetime");

                entity.Property(e => e.DateRequest).HasColumnType("datetime");

                entity.Property(e => e.DateRequestComplete).HasColumnType("datetime");

                entity.Property(e => e.Describe).HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Tag).HasMaxLength(1000);

                entity.Property(e => e.TagNameList).HasMaxLength(1000);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Deals)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Deals_Company");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Deals)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Deals_Contact");

                entity.HasOne(d => d.Pipeline)
                    .WithMany(p => p.DealPipelines)
                    .HasForeignKey(d => d.PipelineId)
                    .HasConstraintName("FK_Deals_deaPipeline1");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.Deals)
                    .HasForeignKey(d => d.ReasonId)
                    .HasConstraintName("FK_Deals_deaReason");

                entity.HasOne(d => d.StaffOwner)
                    .WithMany(p => p.Deals)
                    .HasForeignKey(d => d.StaffOwnerId)
                    .HasConstraintName("FK_Deals_Staff");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.DealStages)
                    .HasForeignKey(d => d.StageId)
                    .HasConstraintName("FK_Deals_deaPipeline");
            });

            modelBuilder.Entity<DealTag>(entity =>
            {
                entity.ToTable("DealTag");

                entity.HasOne(d => d.Deals)
                    .WithMany(p => p.DealTags)
                    .HasForeignKey(d => d.DealsId)
                    .HasConstraintName("FK_DealTag_Deals");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.DealTags)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_DealTag_Tag");
            });

            modelBuilder.Entity<DepositHistory>(entity =>
            {
                entity.ToTable("DepositHistory");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.ShopType).HasMaxLength(50);
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("Discount");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Error>(entity =>
            {
                entity.ToTable("Error");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<EventType>(entity =>
            {
                entity.ToTable("EventType");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<FileDetail>(entity =>
            {
                entity.ToTable("FileDetail");

                entity.Property(e => e.AzureUniquename)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(100);
            });

            modelBuilder.Entity<FilterCondition>(entity =>
            {
                entity.ToTable("FilterCondition");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FilterConditionField>(entity =>
            {
                entity.ToTable("FilterConditionField");

                entity.Property(e => e.ConditionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.FieldId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Condition)
                    .WithMany(p => p.FilterConditionFields)
                    .HasForeignKey(d => d.ConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilterConditionField_FilterCondition");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.FilterConditionFields)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilterConditionField_FilterField");
            });

            modelBuilder.Entity<FilterCustomer>(entity =>
            {
                entity.ToTable("FilterCustomer");

                entity.Property(e => e.ConditionId).HasMaxLength(50);

                entity.Property(e => e.FieldId).HasMaxLength(50);

                entity.Property(e => e.OnValue).HasMaxLength(200);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.FilterCustomers)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_FilterCustomer_FilterGroup");
            });

            modelBuilder.Entity<FilterField>(entity =>
            {
                entity.ToTable("FilterField");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.DataType).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(200);
            });

            modelBuilder.Entity<FilterGroup>(entity =>
            {
                entity.ToTable("FilterGroup");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Operation).HasMaxLength(50);
            });

            modelBuilder.Entity<GetNewId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Get_NewID");

                entity.Property(e => e.MyNewId).HasColumnName("MyNewID");
            });

            modelBuilder.Entity<HubMapApi>(entity =>
            {
                entity.ToTable("hubMapApi");

                entity.Property(e => e.HubspotValue).HasMaxLength(50);

                entity.Property(e => e.SubscriptionType).HasMaxLength(50);

                entity.Property(e => e.TagCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Keyword>(entity =>
            {
                entity.ToTable("Keyword");

                entity.Property(e => e.Keyword1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Keyword");
            });

            modelBuilder.Entity<LatestShopOrder>(entity =>
            {
                entity.ToTable("LatestShopOrder");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LatestOrder).HasColumnType("datetime");
            });

            modelBuilder.Entity<MailCampaign>(entity =>
            {
                entity.ToTable("mailCampaigns");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DeleyType).HasMaxLength(50);

                entity.Property(e => e.Describe).HasMaxLength(1000);

                entity.Property(e => e.LinkMedia).HasMaxLength(500);

                entity.Property(e => e.MessageFacebook).HasMaxLength(2000);

                entity.Property(e => e.MessageSms).HasMaxLength(2000);

                entity.Property(e => e.MessageZalo).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<MailComment>(entity =>
            {
                entity.ToTable("mailComment");

                entity.Property(e => e.BuyerUsername)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.CommentStatus).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateCreateComment).HasColumnType("datetime");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.OrderCode).HasMaxLength(50);

                entity.Property(e => e.Reply)
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.ReplyStatus).HasMaxLength(50);

                entity.Property(e => e.Source).HasMaxLength(50);
            });

            modelBuilder.Entity<MailConfigEmailParner>(entity =>
            {
                entity.ToTable("mailConfigEmailParner");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Server).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<MailConfigSmsPartner>(entity =>
            {
                entity.ToTable("mailConfigSmsPartner");

                entity.Property(e => e.ApiKey).HasMaxLength(50);

                entity.Property(e => e.PartnerName).HasMaxLength(50);

                entity.Property(e => e.SecretKey).HasMaxLength(50);
            });

            modelBuilder.Entity<MailConfigSmtp>(entity =>
            {
                entity.ToTable("mailConfigSmtp");

                entity.Property(e => e.BrandName).HasMaxLength(250);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmailType).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.Server).HasMaxLength(150);
            });

            modelBuilder.Entity<MailContentTemplate>(entity =>
            {
                entity.ToTable("mailContentTemplate");

                entity.Property(e => e.Message).HasColumnType("ntext");

                entity.Property(e => e.Name).HasMaxLength(4000);

                entity.Property(e => e.SendingType).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(100);
            });

            modelBuilder.Entity<MailDeviceMobile>(entity =>
            {
                entity.ToTable("mailDeviceMobile");

                entity.Property(e => e.Device).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);
            });

            modelBuilder.Entity<MailLink>(entity =>
            {
                entity.ToTable("mailLink");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccountCode).HasMaxLength(10);

                entity.Property(e => e.Link).HasMaxLength(300);

                entity.Property(e => e.Replaced).HasMaxLength(50);

                entity.Property(e => e.ShortenLink).HasMaxLength(100);
            });

            modelBuilder.Entity<MailLinkContentTemplate>(entity =>
            {
                entity.ToTable("mailLinkContentTemplate");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(100);

                entity.HasOne(d => d.ContentTemplate)
                    .WithMany(p => p.MailLinkContentTemplates)
                    .HasForeignKey(d => d.ContentTemplateId)
                    .HasConstraintName("FK_mailLinkContentTemplate_mailContentTemplate");
            });

            modelBuilder.Entity<MailMessageSm>(entity =>
            {
                entity.ToTable("mailMessageSMS");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Message).HasMaxLength(400);

                entity.Property(e => e.SenderPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShopPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.MailMessageSms)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_mailMessageSMS_Account");
            });

            modelBuilder.Entity<MailPersonalized>(entity =>
            {
                entity.ToTable("mailPersonalized");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.DataType).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Url).HasMaxLength(50);
            });

            modelBuilder.Entity<MailSendSumOfDay>(entity =>
            {
                entity.ToTable("mailSendSumOfDay");

                entity.Property(e => e.DateSend).HasColumnType("date");
            });

            modelBuilder.Entity<MailSendSumOfMonth>(entity =>
            {
                entity.ToTable("mailSendSumOfMonth");
            });

            modelBuilder.Entity<MailSending>(entity =>
            {
                entity.ToTable("mailSending");

                entity.Property(e => e.ActionTypeContact).HasMaxLength(20);

                entity.Property(e => e.Bcc).HasMaxLength(150);

                entity.Property(e => e.Cc).HasMaxLength(150);

                entity.Property(e => e.ConfigListId).HasMaxLength(20);

                entity.Property(e => e.ContactSource).HasMaxLength(50);

                entity.Property(e => e.ContentMail).HasColumnType("ntext");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DateOrderAfter).HasColumnType("datetime");

                entity.Property(e => e.DateOrderBefore).HasColumnType("datetime");

                entity.Property(e => e.DateSendExpected).HasColumnType("datetime");

                entity.Property(e => e.Event).HasMaxLength(50);

                entity.Property(e => e.EventType).HasMaxLength(50);

                entity.Property(e => e.IndexNo).HasMaxLength(200);

                entity.Property(e => e.Link).HasMaxLength(500);

                entity.Property(e => e.LinkImage).HasMaxLength(500);

                entity.Property(e => e.Replyto).HasMaxLength(50);

                entity.Property(e => e.TagIdListStringAdd).HasMaxLength(50);

                entity.Property(e => e.TagIdListStringContain).HasMaxLength(50);

                entity.Property(e => e.TagIdListStringNotContain).HasMaxLength(50);

                entity.Property(e => e.TagIdListStringRemove).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(2000);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.MailSendings)
                    .HasForeignKey(d => d.CampaignId)
                    .HasConstraintName("FK_mailSending_mailCampaigns");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_mailSending_mailSending");
            });

            modelBuilder.Entity<MailSendingConfigSmtp>(entity =>
            {
                entity.ToTable("mailSendingConfigSmtp");

                entity.HasOne(d => d.ConfigSmtp)
                    .WithMany(p => p.MailSendingConfigSmtps)
                    .HasForeignKey(d => d.ConfigSmtpId)
                    .HasConstraintName("FK_mailSendingConfig_mailConfig");

                entity.HasOne(d => d.Sending)
                    .WithMany(p => p.MailSendingConfigSmtps)
                    .HasForeignKey(d => d.SendingId)
                    .HasConstraintName("FK_mailSendingConfigSmtp_mailSending");
            });

            modelBuilder.Entity<MailSendingContact>(entity =>
            {
                entity.ToTable("mailSendingContact");

                entity.Property(e => e.ActionTypeContact).HasMaxLength(20);

                entity.Property(e => e.ContactEmail).HasMaxLength(50);

                entity.Property(e => e.ContactMobile).HasMaxLength(50);

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.DateActionContact).HasColumnType("datetime");

                entity.Property(e => e.DateClick).HasColumnType("datetime");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateOpen).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.DateReply).HasColumnType("datetime");

                entity.Property(e => e.DateSend).HasColumnType("datetime");

                entity.Property(e => e.DateSendExpected).HasColumnType("datetime");

                entity.Property(e => e.DeviceMobile).HasMaxLength(50);

                entity.Property(e => e.Link).HasMaxLength(1000);

                entity.Property(e => e.LinkImage).HasMaxLength(4000);

                entity.Property(e => e.Message).HasMaxLength(1000);

                entity.Property(e => e.MessageReply).HasColumnType("ntext");

                entity.Property(e => e.OrderCode).HasMaxLength(50);

                entity.Property(e => e.SendingEvent).HasMaxLength(50);

                entity.Property(e => e.SendingTitle).HasMaxLength(1000);

                entity.Property(e => e.SendingType).HasMaxLength(50);

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<MailSendingContactStatusByEventType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mailSendingContactStatusByEventType");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SendingEventTypeId).HasMaxLength(50);
            });

            modelBuilder.Entity<MailSendingEventType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mailSendingEventType");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(4000);

                entity.Property(e => e.ParentEventType).HasMaxLength(50);

                entity.Property(e => e.SendingEvent).HasMaxLength(50);

                entity.Property(e => e.SendingType).HasMaxLength(50);
            });

            modelBuilder.Entity<MailSource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mailSource");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<MailTemplate>(entity =>
            {
                entity.ToTable("mailTemplate");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.TemplateCategory).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(2000);

                entity.Property(e => e.Type).HasMaxLength(100);
            });

            modelBuilder.Entity<MailTrigger>(entity =>
            {
                entity.ToTable("mailTriggers");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateCreateContactAfter).HasColumnType("datetime");

                entity.Property(e => e.DateCreateContactBefore).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DateOrderAfter).HasColumnType("datetime");

                entity.Property(e => e.DateOrderBefore).HasColumnType("datetime");

                entity.Property(e => e.DateSend).HasColumnType("datetime");

                entity.Property(e => e.DeleyType).HasMaxLength(50);

                entity.Property(e => e.LinkMedia).HasMaxLength(500);

                entity.Property(e => e.MessageFacebook).HasMaxLength(2000);

                entity.Property(e => e.MessageSms).HasMaxLength(2000);

                entity.Property(e => e.MessageZalo).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.PhoneNumberReceived).HasMaxLength(20);

                entity.Property(e => e.Value).HasMaxLength(500);

                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.MailTriggers)
                    .HasForeignKey(d => d.KeywordId)
                    .HasConstraintName("FK_mailTriggers_Keyword");

                entity.HasOne(d => d.Sending)
                    .WithMany(p => p.MailTriggers)
                    .HasForeignKey(d => d.SendingId)
                    .HasConstraintName("FK_mailTriggers_mailSending");
            });

            modelBuilder.Entity<MailTriggerType>(entity =>
            {
                entity.ToTable("mailTriggerType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IdString).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<MailTriggerTypeInput>(entity =>
            {
                entity.ToTable("mailTriggerTypeInput");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Datatype).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.HasOne(d => d.TriggerType)
                    .WithMany(p => p.MailTriggerTypeInputs)
                    .HasForeignKey(d => d.TriggerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mailTriggerTypeInput_mailTriggerType");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.ToTable("Note");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Message).HasColumnType("ntext");
            });

            modelBuilder.Entity<OrdDiscount>(entity =>
            {
                entity.ToTable("OrdDiscount");

                entity.Property(e => e.DiscountName).HasMaxLength(200);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(100);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.ContactAdressDelivery).HasMaxLength(1000);

                entity.Property(e => e.ContactCityDelivery).HasMaxLength(100);

                entity.Property(e => e.ContactComment).HasMaxLength(1000);

                entity.Property(e => e.ContactCountryDelivery).HasMaxLength(50);

                entity.Property(e => e.ContactDistrictDelivery).HasMaxLength(100);

                entity.Property(e => e.ContactMobileDelivery).HasMaxLength(50);

                entity.Property(e => e.ContactNameDelivery).HasMaxLength(100);

                entity.Property(e => e.ContactShopeeCode).HasMaxLength(50);

                entity.Property(e => e.DateCompletedPayment).HasColumnType("datetime");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DateOrder).HasColumnType("datetime");

                entity.Property(e => e.DateShip).HasColumnType("datetime");

                entity.Property(e => e.DateShipCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateShipExpected).HasColumnType("datetime");

                entity.Property(e => e.Describe).HasMaxLength(1000);

                entity.Property(e => e.DiscountCash).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LinkInboxPage).HasMaxLength(2000);

                entity.Property(e => e.LogisticsStatus).HasMaxLength(50);

                entity.Property(e => e.OrderCode).HasMaxLength(50);

                entity.Property(e => e.OrderPay).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OrderSource).HasMaxLength(50);

                entity.Property(e => e.OrderStatusGeneral).HasMaxLength(50);

                entity.Property(e => e.OrderSumPay).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OrderType).HasMaxLength(50);

                entity.Property(e => e.PayType).HasMaxLength(200);

                entity.Property(e => e.PostCode).HasMaxLength(50);

                entity.Property(e => e.ProductListShopee).HasMaxLength(4000);

                entity.Property(e => e.ShipCode).HasMaxLength(50);

                entity.Property(e => e.ShipPay).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ShipType).HasMaxLength(200);

                entity.Property(e => e.ShipUnit).HasMaxLength(500);

                entity.Property(e => e.StatusOderShopee).HasMaxLength(100);

                entity.Property(e => e.StatusRefundShopee).HasMaxLength(100);

                entity.Property(e => e.TagIdStringList).HasMaxLength(50);

                entity.Property(e => e.TagNameList).HasMaxLength(1000);

                entity.Property(e => e.TrackingLogisticsStatus).HasMaxLength(50);

                entity.Property(e => e.VnPostStatus).HasMaxLength(50);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Orders_Contact");

                entity.HasOne(d => d.StaffOwner)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StaffOwnerId)
                    .HasConstraintName("FK_Orders_Staff");
            });

            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.ToTable("OrderProduct");

                entity.Property(e => e.DiscountCash).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PromotionType).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_OrderProduct_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderProduct_Product");
            });

            modelBuilder.Entity<OrderUpdateStatus>(entity =>
            {
                entity.ToTable("orderUpdateStatus");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderCode).HasMaxLength(50);

                entity.Property(e => e.OrderStatus).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<PhoneNumberReceive>(entity =>
            {
                entity.HasKey(e => e.Phone);

                entity.ToTable("PhoneNumberReceive");

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<PricePerMessage>(entity =>
            {
                entity.ToTable("PricePerMessage");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SendingType).HasMaxLength(50);
            });

            modelBuilder.Entity<ProCategory>(entity =>
            {
                entity.ToTable("proCategory");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Describe).HasMaxLength(4000);

                entity.Property(e => e.ItemShopeeSku).HasMaxLength(500);

                entity.Property(e => e.LinkProductLazada).HasMaxLength(200);

                entity.Property(e => e.LinkProductPage).HasMaxLength(200);

                entity.Property(e => e.LinkProductSendo).HasMaxLength(200);

                entity.Property(e => e.LinkProductShopee).HasMaxLength(200);

                entity.Property(e => e.LinkProductWeb).HasMaxLength(200);

                entity.Property(e => e.LinkProductZaloPage).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.SellingPriceDetail).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SellingPriceLazada).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SellingPricePage).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SellingPriceSendo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SellingPriceShopee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SellingPriceWeb).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sku).HasMaxLength(100);

                entity.Property(e => e.Tag).HasMaxLength(1000);
            });

            modelBuilder.Entity<ProductVariant>(entity =>
            {
                entity.ToTable("ProductVariant");

                entity.Property(e => e.SellingPriceLazada).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SellingPriceShopee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sku)
                    .HasMaxLength(100)
                    .HasColumnName("SKU");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ProductVariants)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_ProductVariant_Account");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVariants)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductVariant_Product");
            });

            modelBuilder.Entity<Queue>(entity =>
            {
                entity.Property(e => e.AckId)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Events).HasMaxLength(2000);

                entity.Property(e => e.QueueCode).HasMaxLength(50);

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.SubscriptionType)
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<SdAction>(entity =>
            {
                entity.ToTable("sdAction");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<SdCampaign>(entity =>
            {
                entity.ToTable("sdCampaign");

                entity.Property(e => e.ActionId).HasMaxLength(50);

                entity.Property(e => e.CommentMessage).HasColumnType("ntext");

                entity.Property(e => e.CommentTimeDivision).HasMaxLength(50);

                entity.Property(e => e.FacebookActionType).HasMaxLength(50);

                entity.Property(e => e.FacebookType).HasMaxLength(50);

                entity.Property(e => e.Message).HasColumnType("ntext");

                entity.Property(e => e.TimeAction).HasColumnType("datetime");

                entity.Property(e => e.TimeDivision).HasMaxLength(50);

                entity.Property(e => e.TimeType).HasMaxLength(50);

                entity.Property(e => e.Uid).HasColumnType("ntext");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.SdCampaigns)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_sdCampaign_sdAction");

                entity.HasOne(d => d.FacebookActionTypeNavigation)
                    .WithMany(p => p.SdCampaigns)
                    .HasForeignKey(d => d.FacebookActionType)
                    .HasConstraintName("FK_sdCampaign_sdFacebookActionType");

                entity.HasOne(d => d.FacebookTypeNavigation)
                    .WithMany(p => p.SdCampaigns)
                    .HasForeignKey(d => d.FacebookType)
                    .HasConstraintName("FK_sdCampaign_sdFacebookType");

                entity.HasOne(d => d.TimeDivisionNavigation)
                    .WithMany(p => p.SdCampaigns)
                    .HasForeignKey(d => d.TimeDivision)
                    .HasConstraintName("FK_sdCampaign_sdTimeDivision");

                entity.HasOne(d => d.TimeTypeNavigation)
                    .WithMany(p => p.SdCampaigns)
                    .HasForeignKey(d => d.TimeType)
                    .HasConstraintName("FK_sdCampaign_sdTimeType");
            });

            modelBuilder.Entity<SdFacebookActionType>(entity =>
            {
                entity.ToTable("sdFacebookActionType");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SdFacebookType>(entity =>
            {
                entity.ToTable("sdFacebookType");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SdTimeDivision>(entity =>
            {
                entity.ToTable("sdTimeDivision");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SdTimeType>(entity =>
            {
                entity.ToTable("sdTimeType");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.ToTable("Shop");

                entity.Property(e => e.AccessToken).HasMaxLength(150);

                entity.Property(e => e.AppId).HasMaxLength(100);

                entity.Property(e => e.AppKey).HasMaxLength(100);

                entity.Property(e => e.AuthCode).HasMaxLength(100);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateCreateAccessToken).HasColumnType("datetime");

                entity.Property(e => e.DateCreateAuthCode).HasColumnType("datetime");

                entity.Property(e => e.DateCreateRefreshToken).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.IsOnlyOpenBrowserWhenRunning).HasColumnName("Is_only_Open_browser_when_running");

                entity.Property(e => e.IsSsl).HasColumnName("IsSSL");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PathProfileChrome).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProfileFolderName).HasMaxLength(500);

                entity.Property(e => e.Proxy).HasMaxLength(50);

                entity.Property(e => e.RefreshToken).HasMaxLength(4000);

                entity.Property(e => e.ServerName).HasMaxLength(1000);

                entity.Property(e => e.ShopName).HasMaxLength(100);

                entity.Property(e => e.ShopType).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Shops)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shop_Account");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Shops)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Shop_autoShopCategory");
            });

            modelBuilder.Entity<ShopChatbot>(entity =>
            {
                entity.ToTable("ShopChatbot");

                entity.Property(e => e.Keyword).HasMaxLength(500);

                entity.Property(e => e.LinkImage).HasMaxLength(500);

                entity.Property(e => e.ResponseMessage).HasMaxLength(1000);
            });

            modelBuilder.Entity<ShopConnectionType>(entity =>
            {
                entity.ToTable("ShopConnectionType");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.AuthorityType).HasMaxLength(50);

                entity.Property(e => e.LinkAuthority).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<ShopEcomAuto>(entity =>
            {
                entity.ToTable("ShopEcomAuto");

                entity.Property(e => e.DeleyType).HasMaxLength(50);

                entity.Property(e => e.LinkMedia).HasMaxLength(500);

                entity.Property(e => e.MessageFacebook).HasMaxLength(2000);

                entity.Property(e => e.MessageShopee).HasMaxLength(2000);

                entity.Property(e => e.MessageSms).HasMaxLength(2000);

                entity.Property(e => e.MessageZalo).HasMaxLength(2000);

                entity.Property(e => e.OrderStatus).HasMaxLength(50);
            });

            modelBuilder.Entity<ShopFeedback>(entity =>
            {
                entity.ToTable("ShopFeedback");

                entity.Property(e => e.CustomerCode).HasMaxLength(50);

                entity.Property(e => e.Feedback).HasMaxLength(1000);
            });

            modelBuilder.Entity<ShopReplyFeedback>(entity =>
            {
                entity.ToTable("ShopReplyFeedback");

                entity.Property(e => e.FeedbackReview).HasMaxLength(2000);

                entity.Property(e => e.MessageShopee).HasMaxLength(2000);

                entity.Property(e => e.MessageSms).HasMaxLength(2000);

                entity.Property(e => e.MessageZalo).HasMaxLength(2000);
            });

            modelBuilder.Entity<SmsSending>(entity =>
            {
                entity.ToTable("smsSending");

                entity.Property(e => e.ContentSms).HasMaxLength(200);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DateSendExpected).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<SmsSendingContact>(entity =>
            {
                entity.ToTable("smsSendingContact");

                entity.Property(e => e.DateActionContact).HasColumnType("datetime");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateSend).HasColumnType("datetime");

                entity.Property(e => e.DateSendExpected).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.SmsSendingContacts)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_smsSendingContact_Contact");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.SmsSendingContacts)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_smsSendingContact_Orders");

                entity.HasOne(d => d.Sending)
                    .WithMany(p => p.SmsSendingContacts)
                    .HasForeignKey(d => d.SendingId)
                    .HasConstraintName("FK_smsSendingContact_smsSending");
            });

            modelBuilder.Entity<SmsTemplate>(entity =>
            {
                entity.ToTable("smsTemplate");

                entity.Property(e => e.ContentSms).HasMaxLength(1000);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<StaffRole>(entity =>
            {
                entity.ToTable("StaffRole");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.StaffRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_StaffRole_Role");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.StaffRoles)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_StaffRole_Staff");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tag");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TagCompany>(entity =>
            {
                entity.ToTable("TagCompany");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TagCompanies)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TagCompany_Company");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TagCompanies)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_TagCompany_Tag");
            });

            modelBuilder.Entity<TagContact>(entity =>
            {
                entity.ToTable("TagContact");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.TagContacts)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TagContact_Contact");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TagContacts)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_TagContact_Tag");
            });

            modelBuilder.Entity<TagTable>(entity =>
            {
                entity.ToTable("TagTable");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.TagTables)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TagTable_Contact");

                entity.HasOne(d => d.Deal)
                    .WithMany(p => p.TagTables)
                    .HasForeignKey(d => d.DealId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TagTable_Deals");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TagTables)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TagTable_Orders");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TagTables)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_TagTable_Tag");
            });

            modelBuilder.Entity<Webhook>(entity =>
            {
                entity.ToTable("Webhook");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Message).HasColumnType("ntext");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.SourceCategory).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.KeyMac).HasMaxLength(50);

                entity.Property(e => e.MacAdress).HasMaxLength(50);

                entity.Property(e => e.MacMobile).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.PasswordHash).HasMaxLength(50);

                entity.Property(e => e.SeedingDayType).HasMaxLength(50);

                entity.Property(e => e.UserKey).HasMaxLength(500);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
