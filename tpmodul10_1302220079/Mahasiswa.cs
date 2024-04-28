using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302220079;
public class Mahasiswa
{
    public string Nama { get; set; }
    public string Nim { get; set; }

    public Mahasiswa(string nama, string nim)
    {
        Nama = nama;
        Nim = nim;
    }
}

public static class StudentData
{
    public static List<Mahasiswa> Students { get; } = new List<Mahasiswa>()
    {
        new Mahasiswa("⁠Muhammad Hashfi Hadyan", "1302220079"),
        new Mahasiswa("Muhammad Daffa Fadillah", "1302223124"),
        new Mahasiswa("Muhammad Fauzan Majid", "1302220144"),
        new Mahasiswa("Arinza Aurelvia", "1302220022"),
        new Mahasiswa("Soraya Haidar Salma", "1302223006"),
        new Mahasiswa("Maulana Farras", "103022390001")
    };
}