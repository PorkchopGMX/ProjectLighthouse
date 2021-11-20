﻿// <auto-generated />
using LBPUnion.ProjectLighthouse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ProjectLighthouse.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20211104040509_AddGameVersionToSlots")]
    partial class AddGameVersionToSlots
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.HeartedProfile", b =>
                {
                    b.Property<int>("HeartedProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HeartedUserId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("HeartedProfileId");

                    b.HasIndex("HeartedUserId");

                    b.HasIndex("UserId");

                    b.ToTable("HeartedProfiles");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.Levels.HeartedLevel", b =>
                {
                    b.Property<int>("HeartedLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SlotId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("HeartedLevelId");

                    b.HasIndex("SlotId");

                    b.HasIndex("UserId");

                    b.ToTable("HeartedLevels");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.Levels.QueuedLevel", b =>
                {
                    b.Property<int>("QueuedLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SlotId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("QueuedLevelId");

                    b.HasIndex("SlotId");

                    b.HasIndex("UserId");

                    b.ToTable("QueuedLevels");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.Levels.Slot", b =>
                {
                    b.Property<int>("SlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuthorLabels")
                        .HasColumnType("longtext");

                    b.Property<string>("BackgroundHash")
                        .HasColumnType("longtext");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<long>("FirstUploaded")
                        .HasColumnType("bigint");

                    b.Property<int>("GameVersion")
                        .HasColumnType("int");

                    b.Property<string>("IconHash")
                        .HasColumnType("longtext");

                    b.Property<bool>("InitiallyLocked")
                        .HasColumnType("tinyint(1)");

                    b.Property<long>("LastUpdated")
                        .HasColumnType("bigint");

                    b.Property<bool>("Lbp1Only")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("MaximumPlayers")
                        .HasColumnType("int");

                    b.Property<int>("MinimumPlayers")
                        .HasColumnType("int");

                    b.Property<bool>("MoveRequired")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("ResourceCollection")
                        .HasColumnType("longtext");

                    b.Property<string>("RootLevel")
                        .HasColumnType("longtext");

                    b.Property<int>("Shareable")
                        .HasColumnType("int");

                    b.Property<bool>("SubLevel")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("TeamPick")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("SlotId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LocationId");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.Profiles.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("longtext");

                    b.Property<int>("PosterUserId")
                        .HasColumnType("int");

                    b.Property<int>("TargetUserId")
                        .HasColumnType("int");

                    b.Property<int>("ThumbsDown")
                        .HasColumnType("int");

                    b.Property<int>("ThumbsUp")
                        .HasColumnType("int");

                    b.Property<long>("Timestamp")
                        .HasColumnType("bigint");

                    b.HasKey("CommentId");

                    b.HasIndex("PosterUserId");

                    b.HasIndex("TargetUserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.Profiles.LastMatch", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("Timestamp")
                        .HasColumnType("bigint");

                    b.HasKey("UserId");

                    b.ToTable("LastMatches");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.Profiles.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.Score", b =>
                {
                    b.Property<int>("ScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PlayerIdCollection")
                        .HasColumnType("longtext");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("SlotId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ScoreId");

                    b.HasIndex("SlotId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.GameToken", b =>
                {
                    b.Property<int>("TokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GameVersion")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserToken")
                        .HasColumnType("longtext");

                    b.HasKey("TokenId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Biography")
                        .HasColumnType("longtext");

                    b.Property<string>("BooHash")
                        .HasColumnType("longtext");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<bool>("CommentsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("FavouriteSlotCount")
                        .HasColumnType("int");

                    b.Property<int>("FavouriteUserCount")
                        .HasColumnType("int");

                    b.Property<int>("Game")
                        .HasColumnType("int");

                    b.Property<int>("HeartCount")
                        .HasColumnType("int");

                    b.Property<string>("IconHash")
                        .HasColumnType("longtext");

                    b.Property<int>("Lists")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("LolCatFtwCount")
                        .HasColumnType("int");

                    b.Property<int>("PhotosByMeCount")
                        .HasColumnType("int");

                    b.Property<int>("PhotosWithMeCount")
                        .HasColumnType("int");

                    b.Property<string>("Pins")
                        .HasColumnType("longtext");

                    b.Property<string>("PlanetHash")
                        .HasColumnType("longtext");

                    b.Property<int>("ReviewCount")
                        .HasColumnType("int");

                    b.Property<int>("StaffChallengeBronzeCount")
                        .HasColumnType("int");

                    b.Property<int>("StaffChallengeGoldCount")
                        .HasColumnType("int");

                    b.Property<int>("StaffChallengeSilverCount")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.Property<string>("YayHash")
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.HasIndex("LocationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.HeartedProfile", b =>
                {
                    b.HasOne("LBPUnion.ProjectLighthouse.Types.User", "HeartedUser")
                        .WithMany()
                        .HasForeignKey("HeartedUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LBPUnion.ProjectLighthouse.Types.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HeartedUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.Levels.HeartedLevel", b =>
                {
                    b.HasOne("LBPUnion.ProjectLighthouse.Types.Levels.Slot", "Slot")
                        .WithMany()
                        .HasForeignKey("SlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LBPUnion.ProjectLighthouse.Types.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Slot");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.Levels.QueuedLevel", b =>
                {
                    b.HasOne("LBPUnion.ProjectLighthouse.Types.Levels.Slot", "Slot")
                        .WithMany()
                        .HasForeignKey("SlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LBPUnion.ProjectLighthouse.Types.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Slot");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.Levels.Slot", b =>
                {
                    b.HasOne("LBPUnion.ProjectLighthouse.Types.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LBPUnion.ProjectLighthouse.Types.Profiles.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.Profiles.Comment", b =>
                {
                    b.HasOne("LBPUnion.ProjectLighthouse.Types.User", "Poster")
                        .WithMany()
                        .HasForeignKey("PosterUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LBPUnion.ProjectLighthouse.Types.User", "Target")
                        .WithMany()
                        .HasForeignKey("TargetUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poster");

                    b.Navigation("Target");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.Score", b =>
                {
                    b.HasOne("LBPUnion.ProjectLighthouse.Types.Levels.Slot", "Slot")
                        .WithMany()
                        .HasForeignKey("SlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Slot");
                });

            modelBuilder.Entity("LBPUnion.ProjectLighthouse.Types.User", b =>
                {
                    b.HasOne("LBPUnion.ProjectLighthouse.Types.Profiles.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });
#pragma warning restore 612, 618
        }
    }
}
