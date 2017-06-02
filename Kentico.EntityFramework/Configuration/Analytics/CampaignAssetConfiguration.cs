using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kentico.EntityFramework.Models.Analytics;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kentico.EntityFramework.Configuration.Analytics
{
    public class CampaignAssetConfiguration
    {
    public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CampaignAsset>(entity =>
            {
                entity.HasKey(e => e.CampaignAssetId)
                    .HasName("PK_Analytics_CampaignAsset");

                entity.ToTable("Analytics_CampaignAsset");

                entity.HasIndex(e => e.CampaignAssetCampaignId)
                    .HasName("IX_Analytics_CampaignAsset_CampaignAssetCampaignID");

                entity.Property(e => e.CampaignAssetId).HasColumnName("CampaignAssetID");

                entity.Property(e => e.CampaignAssetAssetGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.CampaignAssetCampaignId)
                    .HasColumnName("CampaignAssetCampaignID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CampaignAssetGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.CampaignAssetLastModified).HasDefaultValueSql("'1/1/0001 12:00:00 AM'");

                entity.Property(e => e.CampaignAssetSiteName).HasMaxLength(200);

                entity.Property(e => e.CampaignAssetType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.AnalyticsCampaignAsset)
                    .HasForeignKey(d => d.CampaignAssetCampaignId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_CampaignAsset_CampaignAssetCampaignID_Analytics_Campaign");
            });
        }
    }
}
