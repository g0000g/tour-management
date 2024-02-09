﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TourManagement.DAL;

namespace TourManagement.Migrations
{
    [DbContext(typeof(TourContext))]
    [Migration("20221005045747_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TourManagement.Models.BangGia", b =>
                {
                    b.Property<int>("BangGiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("GiaTour")
                        .HasColumnType("decimal(18,0)");

                    b.Property<DateTime>("ThoiGianBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("BangGiaId");

                    b.HasIndex("TourId");

                    b.ToTable("BangGias");

                    b.HasData(
                        new
                        {
                            BangGiaId = 1,
                            GiaTour = 3000000m,
                            ThoiGianBatDau = new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            ThoiGianKetThuc = new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            TourId = 1
                        },
                        new
                        {
                            BangGiaId = 2,
                            GiaTour = 3500000m,
                            ThoiGianBatDau = new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            ThoiGianKetThuc = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            TourId = 2
                        },
                        new
                        {
                            BangGiaId = 3,
                            GiaTour = 4000000m,
                            ThoiGianBatDau = new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            ThoiGianKetThuc = new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            TourId = 3
                        });
                });

            modelBuilder.Entity("TourManagement.Models.ChiPhi", b =>
                {
                    b.Property<int>("ChiPhiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoanId")
                        .HasColumnType("int");

                    b.Property<int>("LoaiChiPhiId")
                        .HasColumnType("int");

                    b.Property<decimal>("ThanhTien")
                        .HasColumnType("decimal(18,0)");

                    b.HasKey("ChiPhiId");

                    b.HasIndex("DoanId");

                    b.HasIndex("LoaiChiPhiId");

                    b.ToTable("ChiPhis");

                    b.HasData(
                        new
                        {
                            ChiPhiId = 1,
                            DoanId = 1,
                            LoaiChiPhiId = 1,
                            ThanhTien = 1000000m
                        },
                        new
                        {
                            ChiPhiId = 2,
                            DoanId = 1,
                            LoaiChiPhiId = 2,
                            ThanhTien = 1000000m
                        },
                        new
                        {
                            ChiPhiId = 3,
                            DoanId = 1,
                            LoaiChiPhiId = 3,
                            ThanhTien = 1000000m
                        },
                        new
                        {
                            ChiPhiId = 4,
                            DoanId = 2,
                            LoaiChiPhiId = 1,
                            ThanhTien = 700000m
                        },
                        new
                        {
                            ChiPhiId = 5,
                            DoanId = 2,
                            LoaiChiPhiId = 2,
                            ThanhTien = 500000m
                        },
                        new
                        {
                            ChiPhiId = 6,
                            DoanId = 2,
                            LoaiChiPhiId = 3,
                            ThanhTien = 1000000m
                        },
                        new
                        {
                            ChiPhiId = 7,
                            DoanId = 3,
                            LoaiChiPhiId = 1,
                            ThanhTien = 1200000m
                        },
                        new
                        {
                            ChiPhiId = 8,
                            DoanId = 3,
                            LoaiChiPhiId = 2,
                            ThanhTien = 700000m
                        },
                        new
                        {
                            ChiPhiId = 9,
                            DoanId = 3,
                            LoaiChiPhiId = 3,
                            ThanhTien = 50000m
                        });
                });

            modelBuilder.Entity("TourManagement.Models.ChiTietDoan", b =>
                {
                    b.Property<int>("ChiTietDoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoanId")
                        .HasColumnType("int");

                    b.Property<int>("KhachId")
                        .HasColumnType("int");

                    b.HasKey("ChiTietDoanId");

                    b.HasIndex("DoanId");

                    b.HasIndex("KhachId");

                    b.ToTable("ChiTietDoans");

                    b.HasData(
                        new
                        {
                            ChiTietDoanId = 1,
                            DoanId = 1,
                            KhachId = 1
                        },
                        new
                        {
                            ChiTietDoanId = 2,
                            DoanId = 1,
                            KhachId = 2
                        },
                        new
                        {
                            ChiTietDoanId = 3,
                            DoanId = 1,
                            KhachId = 3
                        },
                        new
                        {
                            ChiTietDoanId = 4,
                            DoanId = 1,
                            KhachId = 4
                        },
                        new
                        {
                            ChiTietDoanId = 5,
                            DoanId = 2,
                            KhachId = 3
                        },
                        new
                        {
                            ChiTietDoanId = 6,
                            DoanId = 2,
                            KhachId = 4
                        },
                        new
                        {
                            ChiTietDoanId = 7,
                            DoanId = 2,
                            KhachId = 5
                        },
                        new
                        {
                            ChiTietDoanId = 8,
                            DoanId = 2,
                            KhachId = 6
                        },
                        new
                        {
                            ChiTietDoanId = 9,
                            DoanId = 3,
                            KhachId = 7
                        },
                        new
                        {
                            ChiTietDoanId = 10,
                            DoanId = 3,
                            KhachId = 8
                        });
                });

            modelBuilder.Entity("TourManagement.Models.ChiTietTour", b =>
                {
                    b.Property<int>("ChiTietTourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiaDiemId")
                        .HasColumnType("int");

                    b.Property<int>("ThuTuDiaDiem")
                        .HasColumnType("int");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("ChiTietTourId");

                    b.HasIndex("DiaDiemId");

                    b.HasIndex("TourId");

                    b.ToTable("ChiTietTours");

                    b.HasData(
                        new
                        {
                            ChiTietTourId = 1,
                            DiaDiemId = 1,
                            ThuTuDiaDiem = 1,
                            TourId = 1
                        },
                        new
                        {
                            ChiTietTourId = 2,
                            DiaDiemId = 2,
                            ThuTuDiaDiem = 2,
                            TourId = 1
                        },
                        new
                        {
                            ChiTietTourId = 3,
                            DiaDiemId = 3,
                            ThuTuDiaDiem = 3,
                            TourId = 1
                        },
                        new
                        {
                            ChiTietTourId = 4,
                            DiaDiemId = 4,
                            ThuTuDiaDiem = 4,
                            TourId = 1
                        },
                        new
                        {
                            ChiTietTourId = 5,
                            DiaDiemId = 6,
                            ThuTuDiaDiem = 1,
                            TourId = 2
                        },
                        new
                        {
                            ChiTietTourId = 6,
                            DiaDiemId = 5,
                            ThuTuDiaDiem = 2,
                            TourId = 2
                        },
                        new
                        {
                            ChiTietTourId = 7,
                            DiaDiemId = 4,
                            ThuTuDiaDiem = 3,
                            TourId = 2
                        },
                        new
                        {
                            ChiTietTourId = 8,
                            DiaDiemId = 3,
                            ThuTuDiaDiem = 1,
                            TourId = 3
                        },
                        new
                        {
                            ChiTietTourId = 9,
                            DiaDiemId = 6,
                            ThuTuDiaDiem = 2,
                            TourId = 3
                        });
                });

            modelBuilder.Entity("TourManagement.Models.DiaDiem", b =>
                {
                    b.Property<int>("DiaDiemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenDiaDiem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiaDiemId");

                    b.ToTable("DiaDiems");

                    b.HasData(
                        new
                        {
                            DiaDiemId = 1,
                            TenDiaDiem = "Sài Gòn"
                        },
                        new
                        {
                            DiaDiemId = 2,
                            TenDiaDiem = "Nha Trang"
                        },
                        new
                        {
                            DiaDiemId = 3,
                            TenDiaDiem = "Đà Lạt"
                        },
                        new
                        {
                            DiaDiemId = 4,
                            TenDiaDiem = "Phú Quốc"
                        },
                        new
                        {
                            DiaDiemId = 5,
                            TenDiaDiem = "Phan Thiết"
                        },
                        new
                        {
                            DiaDiemId = 6,
                            TenDiaDiem = "Sapa"
                        });
                });

            modelBuilder.Entity("TourManagement.Models.Doan", b =>
                {
                    b.Property<int>("DoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("NgayDi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayVe")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("DoanId");

                    b.HasIndex("TourId");

                    b.ToTable("Doans");

                    b.HasData(
                        new
                        {
                            DoanId = 1,
                            NgayDi = new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            NgayVe = new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            TenDoan = "Đoàn 1",
                            TourId = 1
                        },
                        new
                        {
                            DoanId = 2,
                            NgayDi = new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            NgayVe = new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            TenDoan = "Đoàn 2",
                            TourId = 1
                        },
                        new
                        {
                            DoanId = 3,
                            NgayDi = new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            NgayVe = new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            TenDoan = "Đoàn 3",
                            TourId = 1
                        },
                        new
                        {
                            DoanId = 4,
                            NgayDi = new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            NgayVe = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            TenDoan = "Đoàn 4",
                            TourId = 2
                        },
                        new
                        {
                            DoanId = 5,
                            NgayDi = new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            NgayVe = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            TenDoan = "Đoàn 5",
                            TourId = 2
                        },
                        new
                        {
                            DoanId = 6,
                            NgayDi = new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            NgayVe = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            TenDoan = "Đoàn 6",
                            TourId = 2
                        },
                        new
                        {
                            DoanId = 7,
                            NgayDi = new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            NgayVe = new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            TenDoan = "Đoàn 7",
                            TourId = 3
                        },
                        new
                        {
                            DoanId = 8,
                            NgayDi = new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            NgayVe = new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            TenDoan = "Đoàn 8",
                            TourId = 3
                        });
                });

            modelBuilder.Entity("TourManagement.Models.Khach", b =>
                {
                    b.Property<int>("KhachId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cmnd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuocTich")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KhachId");

                    b.ToTable("Khachs");

                    b.HasData(
                        new
                        {
                            KhachId = 1,
                            Cmnd = "121234567",
                            DiaChi = "Long An",
                            GioiTinh = "Nữ",
                            HoTen = "Nguyễn Văn A",
                            QuocTich = "Vietnam",
                            SoDienThoai = "0123456789"
                        },
                        new
                        {
                            KhachId = 2,
                            Cmnd = "121234566",
                            DiaChi = "Kiên Giang",
                            GioiTinh = "Nam",
                            HoTen = "Nguyễn Văn B",
                            QuocTich = "Vietnam",
                            SoDienThoai = "0123456788"
                        },
                        new
                        {
                            KhachId = 3,
                            Cmnd = "121234565",
                            DiaChi = "Mỹ Tho",
                            GioiTinh = "Nữ",
                            HoTen = "Nguyễn Văn C",
                            QuocTich = "Vietnam",
                            SoDienThoai = "0123456787"
                        },
                        new
                        {
                            KhachId = 4,
                            Cmnd = "121234564",
                            DiaChi = "Củ Chi",
                            GioiTinh = "Nam",
                            HoTen = "Nguyễn Văn D",
                            QuocTich = "Vietnam",
                            SoDienThoai = "0123456786"
                        },
                        new
                        {
                            KhachId = 5,
                            Cmnd = "121234563",
                            DiaChi = "Bến Tre",
                            GioiTinh = "Nữ",
                            HoTen = "Nguyễn Văn E",
                            QuocTich = "Vietnam",
                            SoDienThoai = "0123456785"
                        },
                        new
                        {
                            KhachId = 6,
                            Cmnd = "121234562",
                            DiaChi = "Long An",
                            GioiTinh = "Nữ",
                            HoTen = "Nguyễn Văn F",
                            QuocTich = "Vietnam",
                            SoDienThoai = "0123456784"
                        },
                        new
                        {
                            KhachId = 7,
                            Cmnd = "121234561",
                            DiaChi = "Kiên Giang",
                            GioiTinh = "Nam",
                            HoTen = "Nguyễn Văn G",
                            QuocTich = "Vietnam",
                            SoDienThoai = "0123456783"
                        },
                        new
                        {
                            KhachId = 8,
                            Cmnd = "121234560",
                            DiaChi = "Bến Tre",
                            GioiTinh = "Nữ",
                            HoTen = "Nguyễn Văn H",
                            QuocTich = "Vietnam",
                            SoDienThoai = "0123456782"
                        },
                        new
                        {
                            KhachId = 9,
                            Cmnd = "121234559",
                            DiaChi = "Củ Chi",
                            GioiTinh = "Nam",
                            HoTen = "Nguyễn Văn I",
                            QuocTich = "Vietnam",
                            SoDienThoai = "0123456781"
                        },
                        new
                        {
                            KhachId = 10,
                            Cmnd = "121234558",
                            DiaChi = "Mỹ Tho",
                            GioiTinh = "Nữ",
                            HoTen = "Nguyễn Văn K",
                            QuocTich = "Vietnam",
                            SoDienThoai = "0123456780"
                        });
                });

            modelBuilder.Entity("TourManagement.Models.LoaiChiPhi", b =>
                {
                    b.Property<int>("LoaiChiPhiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLoaiChiPhi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoaiChiPhiId");

                    b.ToTable("LoaiChiPhis");

                    b.HasData(
                        new
                        {
                            LoaiChiPhiId = 1,
                            TenLoaiChiPhi = "Chi phí ăn uống"
                        },
                        new
                        {
                            LoaiChiPhiId = 2,
                            TenLoaiChiPhi = "Chi phí phương tiện"
                        },
                        new
                        {
                            LoaiChiPhiId = 3,
                            TenLoaiChiPhi = "Chi phí khác"
                        });
                });

            modelBuilder.Entity("TourManagement.Models.LoaiTour", b =>
                {
                    b.Property<int>("LoaiTourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLoaiTour")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoaiTourId");

                    b.ToTable("LoaiTours");

                    b.HasData(
                        new
                        {
                            LoaiTourId = 1,
                            TenLoaiTour = "Du lịch di động"
                        },
                        new
                        {
                            LoaiTourId = 2,
                            TenLoaiTour = "Du lịch kết hợp nghề nghiệp"
                        },
                        new
                        {
                            LoaiTourId = 3,
                            TenLoaiTour = "Du lịch xã hội và gia đình"
                        },
                        new
                        {
                            LoaiTourId = 4,
                            TenLoaiTour = "Du lịch ẩm thực"
                        });
                });

            modelBuilder.Entity("TourManagement.Models.NhanVien", b =>
                {
                    b.Property<int>("NhanVienId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NhanVienId");

                    b.ToTable("NhanViens");

                    b.HasData(
                        new
                        {
                            NhanVienId = 1,
                            GioiTinh = "Nam",
                            HoTen = "Lê Văn A",
                            SoDienThoai = "0198765432"
                        },
                        new
                        {
                            NhanVienId = 2,
                            GioiTinh = "Nữ",
                            HoTen = "Lê Văn B",
                            SoDienThoai = "0198765433"
                        },
                        new
                        {
                            NhanVienId = 3,
                            GioiTinh = "Nam",
                            HoTen = "Lê Văn C",
                            SoDienThoai = "0198765434"
                        },
                        new
                        {
                            NhanVienId = 4,
                            GioiTinh = "Nữ",
                            HoTen = "Lê Văn D",
                            SoDienThoai = "0198765435"
                        },
                        new
                        {
                            NhanVienId = 5,
                            GioiTinh = "Nam",
                            HoTen = "Lê Văn E",
                            SoDienThoai = "0198765436"
                        },
                        new
                        {
                            NhanVienId = 6,
                            GioiTinh = "Nữ",
                            HoTen = "Lê Văn F",
                            SoDienThoai = "0198765437"
                        },
                        new
                        {
                            NhanVienId = 7,
                            GioiTinh = "Nam",
                            HoTen = "Lê Văn G",
                            SoDienThoai = "0198765438"
                        });
                });

            modelBuilder.Entity("TourManagement.Models.PhanCong", b =>
                {
                    b.Property<int>("PhanCongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoanId")
                        .HasColumnType("int");

                    b.Property<int>("NhanVienId")
                        .HasColumnType("int");

                    b.Property<string>("NhiemVu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhanCongId");

                    b.HasIndex("DoanId");

                    b.HasIndex("NhanVienId");

                    b.ToTable("PhanCongs");

                    b.HasData(
                        new
                        {
                            PhanCongId = 1,
                            DoanId = 1,
                            NhanVienId = 1,
                            NhiemVu = "Lái xe"
                        },
                        new
                        {
                            PhanCongId = 2,
                            DoanId = 1,
                            NhanVienId = 2,
                            NhiemVu = "Hướng dẫn viên"
                        },
                        new
                        {
                            PhanCongId = 3,
                            DoanId = 1,
                            NhanVienId = 3,
                            NhiemVu = "Thông dịch viên"
                        },
                        new
                        {
                            PhanCongId = 4,
                            DoanId = 1,
                            NhanVienId = 4,
                            NhiemVu = "Phục vụ"
                        },
                        new
                        {
                            PhanCongId = 5,
                            DoanId = 2,
                            NhanVienId = 5,
                            NhiemVu = "Lái xe"
                        },
                        new
                        {
                            PhanCongId = 6,
                            DoanId = 2,
                            NhanVienId = 6,
                            NhiemVu = "Hướng dẫn viên"
                        },
                        new
                        {
                            PhanCongId = 7,
                            DoanId = 3,
                            NhanVienId = 3,
                            NhiemVu = "Lái xe"
                        },
                        new
                        {
                            PhanCongId = 8,
                            DoanId = 3,
                            NhanVienId = 4,
                            NhiemVu = "Phục vụ"
                        });
                });

            modelBuilder.Entity("TourManagement.Models.Tour", b =>
                {
                    b.Property<int>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DacDiem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoaiTourId")
                        .HasColumnType("int");

                    b.Property<string>("TenTour")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TourId");

                    b.HasIndex("LoaiTourId");

                    b.ToTable("Tours");

                    b.HasData(
                        new
                        {
                            TourId = 1,
                            DacDiem = "4 ngày 3 đêm",
                            LoaiTourId = 4,
                            TenTour = "Tour A"
                        },
                        new
                        {
                            TourId = 2,
                            LoaiTourId = 3,
                            TenTour = "Tour B"
                        },
                        new
                        {
                            TourId = 3,
                            DacDiem = "3 ngày 2 đêm",
                            LoaiTourId = 2,
                            TenTour = "Tour C"
                        });
                });

            modelBuilder.Entity("TourManagement.Models.BangGia", b =>
                {
                    b.HasOne("TourManagement.Models.Tour", "Tour")
                        .WithMany("BangGias")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("TourManagement.Models.ChiPhi", b =>
                {
                    b.HasOne("TourManagement.Models.Doan", "Doan")
                        .WithMany("ChiPhis")
                        .HasForeignKey("DoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourManagement.Models.LoaiChiPhi", "LoaiChiPhi")
                        .WithMany("ChiPhis")
                        .HasForeignKey("LoaiChiPhiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doan");

                    b.Navigation("LoaiChiPhi");
                });

            modelBuilder.Entity("TourManagement.Models.ChiTietDoan", b =>
                {
                    b.HasOne("TourManagement.Models.Doan", "Doan")
                        .WithMany("ChiTietDoans")
                        .HasForeignKey("DoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourManagement.Models.Khach", "Khach")
                        .WithMany("ChiTietDoans")
                        .HasForeignKey("KhachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doan");

                    b.Navigation("Khach");
                });

            modelBuilder.Entity("TourManagement.Models.ChiTietTour", b =>
                {
                    b.HasOne("TourManagement.Models.DiaDiem", "DiaDiem")
                        .WithMany("ChiTietTours")
                        .HasForeignKey("DiaDiemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourManagement.Models.Tour", "Tour")
                        .WithMany("ChiTietTours")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiaDiem");

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("TourManagement.Models.Doan", b =>
                {
                    b.HasOne("TourManagement.Models.Tour", "Tour")
                        .WithMany("Doans")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("TourManagement.Models.PhanCong", b =>
                {
                    b.HasOne("TourManagement.Models.Doan", "Doan")
                        .WithMany("PhanCongs")
                        .HasForeignKey("DoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourManagement.Models.NhanVien", "NhanVien")
                        .WithMany("PhanCongs")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doan");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("TourManagement.Models.Tour", b =>
                {
                    b.HasOne("TourManagement.Models.LoaiTour", "LoaiTour")
                        .WithMany("Tours")
                        .HasForeignKey("LoaiTourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiTour");
                });

            modelBuilder.Entity("TourManagement.Models.DiaDiem", b =>
                {
                    b.Navigation("ChiTietTours");
                });

            modelBuilder.Entity("TourManagement.Models.Doan", b =>
                {
                    b.Navigation("ChiPhis");

                    b.Navigation("ChiTietDoans");

                    b.Navigation("PhanCongs");
                });

            modelBuilder.Entity("TourManagement.Models.Khach", b =>
                {
                    b.Navigation("ChiTietDoans");
                });

            modelBuilder.Entity("TourManagement.Models.LoaiChiPhi", b =>
                {
                    b.Navigation("ChiPhis");
                });

            modelBuilder.Entity("TourManagement.Models.LoaiTour", b =>
                {
                    b.Navigation("Tours");
                });

            modelBuilder.Entity("TourManagement.Models.NhanVien", b =>
                {
                    b.Navigation("PhanCongs");
                });

            modelBuilder.Entity("TourManagement.Models.Tour", b =>
                {
                    b.Navigation("BangGias");

                    b.Navigation("ChiTietTours");

                    b.Navigation("Doans");
                });
#pragma warning restore 612, 618
        }
    }
}