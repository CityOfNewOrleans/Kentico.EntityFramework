using Kentico.EntityFramework.Models.Analytics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentico.EntityFramework.Configuration.Analytics
{
    public class CampaignConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.HasKey(e => e.CampaignId)
                    .HasName("PK_Analytics_Campaign");

                entity.ToTable("Analytics_Campaign");

                entity.HasIndex(e => e.CampaignScheduledTaskId)
                    .HasName("IX_Analytics_Campaign_CampaignScheduledTaskID");

                entity.HasIndex(e => e.CampaignSiteId)
                    .HasName("IX_Analytics_Campaign_CampaignSiteID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.CampaignDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CampaignGuid).HasColumnName("CampaignGUID");

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CampaignScheduledTaskId).HasColumnName("CampaignScheduledTaskID");

                entity.Property(e => e.CampaignSiteId).HasColumnName("CampaignSiteID");

                entity.Property(e => e.CampaignUtmcode)
                    .HasColumnName("CampaignUTMCode")
                    .HasMaxLength(200);

                entity.HasOne(d => d.CampaignScheduledTask)
                    .WithMany(p => p.AnalyticsCampaigns)
                    .HasForeignKey(d => d.CampaignScheduledTaskId)
                    .HasConstraintName("FK_Analytics_Campaign_CampaignScheduledTaskID_ScheduledTask");

                entity.HasOne(d => d.CampaignSite)
                    .WithMany(p => p.AnalyticsCampaigns)
                    .HasForeignKey(d => d.CampaignSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_Campaign_StatisticsSiteID_CMS_Site");
            });
        }
    }
}
