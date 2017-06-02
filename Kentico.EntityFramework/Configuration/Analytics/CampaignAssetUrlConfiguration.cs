using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Kentico.EntityFramework.Configuration.Analytics
{
    public class CampaignAssetUrlConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CampaignAssetUrl>(entity =>
            {
                entity.HasKey(e => e.CampaignAssetUrlId)
                    .HasName("PK_Analytics_CampaignAssetUrl");

                entity.ToTable("Analytics_CampaignAssetUrl");

                entity.HasIndex(e => e.CampaignAssetUrlCampaignAssetId)
                    .HasName("IX_Analytics_CampaignAssetUrl_CampaignAssetUrlCampaignAssetID");

                entity.Property(e => e.CampaignAssetUrlId).HasColumnName("CampaignAssetUrlID");

                entity.Property(e => e.CampaignAssetUrlCampaignAssetId)
                    .HasColumnName("CampaignAssetUrlCampaignAssetID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CampaignAssetUrlGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.CampaignAssetUrlPageTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CampaignAssetUrlTarget)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.HasOne(d => d.CampaignAssetUrlCampaignAsset)
                    .WithMany(p => p.AnalyticsCampaignAssetUrl)
                    .HasForeignKey(d => d.CampaignAssetUrlCampaignAssetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_CampaignAssetUrl_CampaignAssetUrlCampaignAssetID_Analytics_CampaignAsset");
            });
        }
    }
}
