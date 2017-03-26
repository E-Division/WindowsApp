﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Divison.Classes
{
    class Category
    {
        //VARIABLES
        public int pageID { get; set; }
        public int categoryID { get; set; }
        public int categoryParentID { get; set; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
        public byte[] categoryImage { get; set; }

        public Category()
        {

        }

        //Constructor
        public Category(int pageID, int categoryID, int categoryParentID, string categoryName, string categoryDescription, byte[] categoryImage)
        {
            this.pageID = pageID;
            this.categoryID = categoryID;
            this.categoryParentID = categoryParentID;
            this.categoryName = categoryName;
            this.categoryDescription = categoryDescription;
            this.categoryImage = categoryImage;
        }

        public void InsertCategories(SQLite.Net.SQLiteConnection con)
        {
            byte[] categoryImage = new byte[] { 137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 0, 13, 73, 72, 68, 82, 0, 0, 0, 167, 0, 0, 0, 75, 8, 6, 0, 0, 0, 21, 144, 151, 21, 0, 0, 0, 4, 103, 65, 77, 65, 0, 0, 177, 143, 11, 252, 97, 5, 0, 0, 29, 119, 73, 68, 65, 84, 120, 94, 237, 93, 137, 123, 29, 213, 117, 239, 255, 211, 98, 188, 129, 49, 46, 129, 66, 2, 113, 88, 2, 132, 52, 44, 161, 41, 91, 62, 2, 217, 128, 176, 180, 144, 239, 131, 144, 47, 105, 73, 218, 52, 45, 105, 210, 16, 150, 15, 154, 18, 47, 146, 44, 47, 2, 239, 198, 6, 239, 198, 11, 120, 183, 188, 225, 69, 126, 210, 91, 164, 183, 234, 45, 58, 61, 191, 179, 204, 204, 123, 150, 37, 129, 244, 164, 167, 229, 218, 231, 205, 157, 59, 119, 238, 250, 187, 191, 115, 238, 157, 59, 163, 191, 154, 190, 184, 139, 26, 89, 46, 111, 138, 209, 244, 133, 157, 116, 249, 194, 56, 77, 95, 148, 160, 25, 139, 186, 68, 36, 12, 215, 250, 185, 103, 84, 133, 203, 52, 144, 92, 190, 136, 203, 105, 130, 248, 181, 71, 247, 7, 225, 139, 237, 94, 246, 75, 61, 45, 206, 100, 148, 134, 7, 231, 244, 8, 40, 113, 126, 217, 194, 24, 77, 227, 142, 156, 177, 56, 37, 0, 189, 40, 126, 163, 9, 0, 202, 117, 144, 193, 21, 9, 247, 193, 214, 223, 160, 139, 198, 155, 204, 210, 248, 204, 9, 17, 102, 185, 192, 160, 4, 171, 36, 181, 19, 205, 223, 223, 61, 141, 36, 51, 22, 41, 243, 67, 102, 8, 8, 141, 25, 89, 192, 146, 1, 40, 45, 190, 51, 232, 20, 80, 199, 11, 56, 23, 66, 205, 153, 122, 55, 21, 56, 139, 195, 0, 216, 254, 238, 105, 36, 241, 242, 10, 123, 154, 31, 225, 14, 190, 139, 24, 149, 235, 228, 113, 4, 196, 145, 107, 147, 77, 26, 31, 156, 220, 121, 96, 27, 116, 216, 180, 69, 236, 111, 50, 21, 201, 172, 57, 109, 113, 227, 131, 51, 96, 201, 8, 48, 163, 225, 174, 5, 4, 188, 38, 85, 247, 79, 98, 105, 124, 155, 147, 59, 78, 64, 41, 234, 15, 236, 201, 157, 135, 78, 228, 107, 222, 177, 99, 42, 181, 229, 173, 21, 99, 123, 196, 13, 212, 122, 68, 3, 92, 190, 232, 60, 199, 139, 105, 28, 14, 215, 122, 90, 221, 250, 75, 111, 18, 73, 227, 131, 147, 101, 70, 147, 177, 38, 119, 24, 58, 17, 19, 162, 153, 11, 153, 53, 135, 2, 142, 49, 22, 1, 25, 6, 20, 151, 85, 152, 17, 32, 180, 107, 240, 207, 92, 108, 97, 168, 139, 1, 87, 4, 113, 198, 65, 253, 234, 41, 13, 15, 206, 175, 45, 79, 208, 166, 115, 69, 58, 155, 171, 208, 137, 238, 10, 157, 234, 41, 83, 123, 166, 44, 199, 227, 61, 37, 58, 201, 199, 177, 20, 148, 105, 32, 105, 239, 46, 210, 201, 116, 145, 206, 115, 249, 207, 101, 181, 220, 135, 146, 21, 218, 22, 171, 208, 202, 211, 5, 122, 237, 96, 47, 189, 184, 189, 155, 30, 88, 155, 160, 175, 174, 72, 208, 156, 150, 72, 253, 29, 164, 147, 84, 198, 28, 156, 194, 134, 50, 107, 181, 53, 75, 102, 11, 159, 225, 94, 214, 148, 160, 127, 88, 151, 162, 82, 165, 76, 161, 171, 16, 245, 201, 255, 17, 113, 125, 85, 233, 177, 63, 112, 37, 150, 138, 134, 203, 143, 198, 131, 243, 48, 59, 29, 220, 33, 98, 228, 94, 145, 190, 240, 238, 190, 62, 212, 175, 66, 29, 249, 50, 173, 252, 172, 151, 94, 218, 153, 161, 191, 111, 75, 209, 244, 230, 11, 210, 22, 208, 20, 194, 188, 220, 78, 51, 23, 165, 104, 218, 194, 115, 178, 198, 59, 209, 237, 211, 49, 7, 103, 160, 210, 220, 238, 50, 85, 166, 118, 87, 140, 94, 220, 145, 13, 58, 86, 157, 2, 72, 64, 101, 254, 225, 56, 7, 103, 149, 179, 243, 234, 96, 128, 149, 157, 4, 50, 104, 237, 56, 152, 187, 40, 233, 154, 0, 156, 106, 82, 122, 1, 7, 128, 53, 150, 39, 90, 212, 94, 160, 135, 214, 247, 104, 91, 241, 96, 69, 251, 200, 10, 5, 128, 234, 43, 24, 145, 182, 156, 104, 210, 24, 106, 221, 108, 49, 177, 207, 184, 225, 221, 190, 188, 130, 217, 225, 221, 35, 189, 53, 61, 172, 96, 18, 78, 171, 10, 255, 162, 142, 211, 19, 68, 224, 63, 192, 230, 194, 231, 81, 36, 5, 217, 85, 248, 31, 51, 29, 162, 68, 46, 95, 202, 85, 71, 169, 73, 31, 34, 121, 88, 152, 1, 84, 245, 132, 178, 118, 178, 80, 161, 119, 219, 243, 116, 211, 114, 101, 73, 180, 11, 52, 138, 60, 136, 176, 129, 60, 81, 165, 49, 152, 211, 207, 193, 8, 118, 62, 115, 113, 146, 174, 94, 146, 160, 173, 23, 10, 218, 137, 210, 97, 230, 248, 164, 234, 124, 152, 206, 148, 119, 144, 102, 52, 237, 254, 252, 14, 90, 195, 210, 32, 78, 129, 136, 60, 52, 159, 8, 16, 131, 4, 213, 171, 167, 94, 154, 106, 119, 32, 94, 162, 71, 54, 36, 213, 14, 229, 118, 130, 86, 25, 15, 235, 188, 195, 145, 177, 103, 78, 31, 253, 145, 70, 151, 117, 205, 5, 93, 116, 115, 91, 23, 93, 200, 69, 186, 10, 222, 154, 78, 29, 182, 147, 52, 20, 64, 114, 12, 210, 4, 67, 226, 68, 195, 130, 96, 120, 130, 115, 191, 111, 0, 23, 220, 88, 237, 170, 210, 195, 1, 128, 55, 191, 48, 51, 114, 143, 48, 55, 84, 125, 138, 45, 139, 31, 109, 238, 214, 246, 193, 32, 158, 178, 57, 235, 43, 106, 71, 169, 138, 242, 37, 34, 181, 167, 186, 232, 193, 141, 61, 84, 224, 126, 42, 148, 43, 148, 43, 245, 17, 207, 23, 40, 95, 97, 127, 185, 44, 126, 92, 147, 176, 97, 136, 166, 239, 254, 10, 21, 24, 0, 121, 206, 43, 205, 130, 137, 88, 212, 38, 13, 161, 2, 167, 192, 4, 128, 6, 147, 40, 23, 74, 24, 142, 114, 130, 31, 164, 143, 124, 194, 107, 226, 12, 247, 14, 84, 57, 231, 139, 169, 222, 62, 122, 116, 3, 236, 80, 102, 206, 70, 216, 248, 82, 71, 105, 12, 155, 83, 24, 83, 129, 234, 118, 39, 194, 111, 109, 139, 211, 11, 219, 210, 244, 79, 91, 211, 244, 220, 150, 30, 122, 150, 143, 181, 130, 107, 195, 17, 79, 227, 153, 45, 25, 122, 118, 91, 119, 112, 254, 244, 214, 12, 45, 56, 150, 143, 128, 72, 15, 10, 53, 176, 26, 207, 172, 79, 23, 232, 55, 123, 114, 3, 202, 191, 237, 45, 176, 100, 232, 213, 253, 89, 122, 243, 80, 78, 38, 57, 107, 206, 246, 210, 158, 174, 162, 44, 43, 245, 148, 251, 1, 43, 126, 217, 47, 3, 195, 156, 95, 7, 88, 207, 100, 43, 116, 227, 178, 137, 109, 111, 66, 198, 28, 156, 2, 74, 219, 0, 33, 139, 212, 216, 50, 230, 11, 236, 6, 82, 132, 131, 89, 17, 71, 5, 113, 70, 78, 165, 133, 233, 162, 44, 26, 134, 129, 242, 251, 79, 124, 165, 64, 1, 41, 126, 195, 11, 230, 238, 119, 173, 28, 188, 12, 174, 130, 61, 125, 212, 9, 231, 115, 152, 245, 230, 183, 37, 233, 169, 15, 187, 233, 237, 195, 5, 218, 215, 197, 19, 63, 118, 204, 215, 114, 244, 124, 163, 14, 28, 234, 171, 6, 239, 243, 192, 144, 118, 232, 39, 207, 137, 34, 141, 193, 156, 99, 40, 178, 86, 104, 64, 215, 71, 162, 218, 225, 87, 54, 119, 210, 218, 207, 10, 2, 132, 254, 220, 249, 108, 159, 44, 154, 71, 211, 250, 162, 130, 60, 49, 27, 255, 233, 246, 12, 29, 74, 49, 4, 29, 152, 193, 192, 176, 115, 249, 85, 166, 45, 113, 180, 199, 55, 169, 253, 121, 25, 212, 187, 47, 216, 27, 248, 125, 201, 169, 54, 175, 241, 36, 83, 224, 228, 142, 196, 35, 68, 95, 71, 244, 14, 157, 223, 150, 160, 67, 9, 229, 42, 216, 130, 181, 110, 235, 133, 34, 93, 215, 58, 124, 246, 150, 7, 14, 240, 67, 91, 176, 124, 181, 173, 155, 85, 127, 78, 129, 25, 100, 91, 205, 160, 14, 220, 77, 29, 69, 154, 189, 88, 31, 237, 206, 194, 236, 93, 210, 179, 201, 18, 251, 199, 251, 34, 253, 164, 7, 39, 196, 65, 233, 106, 23, 97, 15, 173, 79, 80, 182, 104, 64, 112, 199, 128, 112, 188, 188, 125, 180, 64, 87, 24, 8, 134, 35, 51, 22, 38, 5, 92, 98, 78, 88, 222, 88, 223, 125, 253, 64, 134, 21, 120, 56, 65, 210, 1, 162, 101, 113, 91, 52, 94, 232, 163, 123, 215, 165, 204, 236, 137, 201, 250, 167, 212, 193, 210, 114, 144, 142, 87, 153, 244, 224, 244, 206, 4, 64, 36, 204, 58, 245, 165, 157, 105, 67, 162, 3, 194, 1, 162, 238, 133, 29, 61, 35, 194, 76, 200, 31, 123, 83, 67, 80, 37, 37, 93, 72, 203, 113, 152, 21, 200, 223, 108, 94, 43, 11, 64, 171, 101, 35, 250, 239, 253, 153, 144, 245, 35, 233, 142, 119, 214, 132, 76, 49, 39, 58, 145, 1, 233, 79, 165, 224, 135, 170, 124, 243, 72, 196, 222, 228, 169, 115, 48, 115, 102, 127, 182, 216, 71, 223, 89, 199, 44, 103, 76, 55, 44, 193, 96, 112, 63, 64, 105, 126, 236, 250, 255, 242, 210, 36, 157, 78, 243, 4, 72, 70, 70, 56, 56, 228, 212, 152, 116, 227, 217, 2, 93, 213, 172, 233, 160, 252, 1, 72, 237, 60, 200, 103, 28, 202, 20, 56, 1, 48, 6, 5, 58, 82, 58, 151, 195, 174, 105, 233, 164, 245, 220, 233, 129, 99, 28, 96, 9, 71, 160, 193, 63, 237, 221, 101, 186, 229, 61, 5, 117, 191, 105, 126, 14, 81, 149, 172, 160, 146, 141, 212, 11, 220, 6, 85, 230, 251, 197, 199, 25, 205, 215, 93, 228, 4, 203, 77, 71, 187, 251, 184, 44, 250, 234, 138, 216, 175, 82, 31, 102, 210, 72, 26, 227, 85, 166, 192, 201, 226, 19, 34, 63, 191, 117, 69, 23, 157, 206, 234, 100, 40, 234, 124, 222, 188, 246, 92, 153, 174, 110, 29, 153, 103, 219, 72, 3, 44, 41, 44, 199, 96, 138, 190, 126, 2, 54, 159, 191, 44, 78, 231, 121, 156, 232, 206, 37, 117, 90, 10, 81, 238, 242, 212, 232, 225, 13, 221, 10, 72, 176, 166, 131, 211, 253, 53, 249, 141, 39, 153, 178, 57, 5, 20, 10, 76, 95, 111, 125, 120, 125, 70, 88, 9, 112, 84, 97, 167, 136, 144, 195, 155, 135, 178, 202, 116, 35, 210, 249, 33, 219, 97, 66, 3, 198, 67, 186, 194, 130, 12, 214, 43, 154, 186, 104, 233, 73, 221, 95, 16, 186, 72, 153, 250, 42, 244, 204, 86, 158, 20, 113, 217, 197, 206, 196, 172, 31, 233, 46, 136, 152, 11, 227, 84, 26, 30, 156, 194, 0, 14, 30, 3, 4, 142, 34, 178, 96, 143, 107, 214, 193, 210, 169, 218, 73, 190, 7, 178, 54, 189, 139, 196, 226, 104, 218, 26, 246, 203, 61, 60, 25, 10, 28, 243, 37, 219, 119, 10, 142, 138, 44, 129, 63, 191, 213, 182, 177, 13, 37, 253, 225, 10, 215, 239, 223, 173, 60, 81, 46, 135, 13, 236, 128, 253, 245, 94, 45, 207, 172, 69, 29, 145, 118, 208, 123, 47, 74, 111, 28, 201, 184, 97, 78, 221, 34, 22, 158, 139, 159, 59, 1, 225, 2, 82, 132, 27, 107, 40, 160, 141, 65, 6, 17, 164, 35, 241, 57, 45, 28, 103, 49, 83, 253, 249, 104, 222, 186, 253, 98, 23, 203, 150, 232, 193, 117, 225, 140, 186, 191, 52, 71, 84, 120, 246, 142, 205, 30, 130, 68, 153, 152, 177, 99, 148, 250, 96, 193, 241, 119, 159, 102, 3, 80, 138, 112, 221, 101, 105, 105, 113, 227, 191, 58, 61, 144, 140, 11, 230, 116, 245, 233, 170, 238, 114, 52, 58, 179, 194, 172, 133, 88, 134, 225, 56, 54, 137, 16, 192, 8, 88, 213, 63, 20, 181, 43, 224, 132, 159, 227, 226, 136, 199, 138, 123, 187, 76, 157, 59, 53, 137, 83, 6, 197, 19, 156, 175, 224, 185, 246, 16, 210, 30, 9, 65, 29, 238, 95, 159, 162, 94, 217, 132, 162, 229, 8, 202, 37, 182, 71, 133, 222, 58, 152, 149, 245, 82, 196, 175, 174, 187, 182, 203, 120, 149, 198, 7, 39, 142, 0, 142, 129, 206, 215, 1, 167, 55, 171, 106, 151, 201, 4, 131, 181, 122, 173, 80, 129, 54, 20, 102, 67, 26, 114, 4, 176, 249, 248, 181, 21, 113, 234, 169, 217, 223, 236, 175, 81, 192, 173, 63, 91, 214, 151, 210, 134, 144, 246, 72, 201, 221, 43, 83, 148, 233, 53, 112, 86, 228, 201, 0, 60, 42, 28, 248, 214, 225, 188, 150, 39, 170, 57, 172, 205, 106, 211, 26, 79, 50, 46, 192, 137, 109, 116, 193, 50, 9, 4, 215, 204, 158, 66, 184, 216, 151, 60, 1, 192, 250, 36, 194, 5, 104, 248, 56, 193, 16, 0, 228, 235, 155, 222, 145, 223, 255, 48, 35, 29, 30, 5, 39, 64, 224, 231, 127, 130, 10, 229, 120, 193, 64, 168, 183, 112, 125, 190, 181, 166, 135, 114, 145, 253, 32, 58, 89, 51, 199, 254, 215, 14, 100, 172, 60, 104, 11, 29, 56, 82, 167, 81, 28, 64, 245, 144, 198, 7, 39, 55, 176, 168, 110, 246, 67, 85, 205, 88, 208, 33, 175, 10, 171, 122, 119, 118, 192, 115, 101, 246, 115, 216, 204, 5, 108, 6, 52, 13, 189, 115, 124, 82, 133, 116, 32, 191, 221, 203, 224, 140, 128, 81, 157, 110, 60, 198, 158, 210, 103, 182, 232, 94, 202, 209, 236, 252, 123, 215, 116, 202, 214, 58, 20, 170, 204, 179, 115, 224, 20, 0, 149, 133, 120, 254, 255, 95, 159, 102, 164, 236, 211, 22, 132, 102, 138, 12, 216, 154, 116, 198, 155, 52, 60, 56, 149, 25, 227, 116, 235, 123, 221, 244, 195, 15, 211, 244, 253, 77, 41, 122, 116, 67, 138, 190, 189, 182, 135, 174, 91, 98, 118, 150, 1, 84, 58, 164, 137, 213, 62, 108, 80, 97, 216, 193, 109, 46, 220, 43, 246, 153, 49, 241, 170, 147, 89, 197, 35, 59, 127, 34, 227, 174, 35, 91, 161, 187, 214, 116, 107, 126, 0, 116, 77, 90, 245, 16, 128, 237, 42, 174, 231, 125, 107, 19, 116, 247, 154, 20, 221, 199, 249, 223, 187, 38, 78, 247, 173, 78, 208, 183, 87, 119, 211, 253, 107, 83, 116, 195, 114, 107, 3, 174, 135, 12, 24, 46, 27, 204, 156, 169, 69, 248, 122, 139, 128, 172, 131, 154, 219, 133, 47, 116, 57, 69, 204, 191, 10, 29, 79, 21, 229, 53, 90, 216, 128, 232, 68, 5, 178, 170, 247, 33, 3, 135, 77, 6, 116, 168, 0, 148, 229, 72, 79, 184, 217, 194, 61, 122, 168, 80, 123, 170, 143, 254, 118, 73, 68, 109, 246, 151, 222, 72, 11, 231, 229, 192, 155, 206, 26, 193, 7, 145, 171, 112, 109, 31, 99, 76, 1, 100, 184, 128, 31, 164, 49, 78, 101, 236, 193, 25, 105, 124, 93, 46, 210, 137, 205, 237, 239, 199, 233, 158, 53, 105, 217, 208, 11, 198, 248, 36, 206, 19, 129, 42, 34, 11, 103, 173, 175, 126, 146, 161, 123, 214, 50, 163, 48, 155, 124, 107, 117, 146, 238, 94, 155, 166, 123, 87, 241, 125, 171, 51, 28, 150, 26, 80, 144, 246, 61, 28, 23, 242, 131, 143, 210, 148, 49, 244, 215, 102, 133, 159, 85, 103, 138, 50, 249, 66, 121, 69, 140, 153, 176, 23, 243, 63, 247, 101, 233, 142, 149, 40, 187, 153, 26, 124, 156, 195, 96, 122, 126, 123, 150, 158, 252, 8, 251, 46, 149, 221, 126, 177, 35, 67, 15, 172, 79, 179, 95, 95, 71, 113, 80, 125, 143, 181, 194, 207, 118, 166, 197, 44, 249, 107, 25, 108, 0, 154, 46, 159, 97, 176, 61, 185, 37, 69, 203, 78, 20, 233, 181, 67, 121, 250, 242, 82, 5, 165, 131, 211, 95, 107, 249, 6, 215, 255, 87, 123, 122, 233, 218, 37, 170, 57, 112, 111, 216, 206, 157, 116, 107, 91, 146, 94, 63, 148, 163, 214, 246, 156, 236, 5, 245, 61, 159, 136, 135, 1, 142, 246, 7, 227, 62, 189, 181, 135, 94, 217, 157, 163, 121, 77, 186, 67, 234, 229, 237, 108, 54, 216, 128, 68, 90, 24, 148, 94, 247, 122, 202, 152, 131, 19, 13, 12, 27, 18, 29, 39, 149, 231, 145, 143, 15, 41, 116, 228, 251, 216, 190, 42, 81, 119, 169, 66, 137, 124, 153, 138, 130, 22, 65, 137, 204, 158, 195, 5, 105, 13, 75, 229, 43, 20, 99, 65, 220, 174, 124, 137, 58, 11, 125, 20, 207, 85, 100, 91, 217, 64, 210, 197, 247, 32, 62, 226, 98, 150, 46, 168, 140, 10, 28, 31, 97, 235, 253, 254, 83, 128, 10, 204, 165, 239, 216, 107, 121, 227, 244, 40, 155, 26, 136, 250, 252, 246, 180, 212, 9, 225, 176, 101, 103, 54, 93, 160, 141, 231, 139, 116, 180, 167, 72, 215, 46, 237, 164, 107, 91, 147, 242, 110, 210, 79, 119, 116, 211, 180, 133, 29, 146, 142, 50, 97, 140, 150, 159, 202, 201, 87, 77, 102, 240, 61, 33, 51, 43, 232, 158, 224, 65, 131, 205, 38, 187, 98, 5, 42, 178, 2, 217, 155, 236, 165, 171, 154, 117, 41, 77, 226, 217, 102, 227, 151, 119, 101, 168, 151, 227, 221, 193, 3, 244, 111, 12, 108, 158, 206, 188, 214, 4, 237, 141, 247, 74, 61, 247, 197, 185, 189, 10, 37, 122, 112, 131, 150, 23, 34, 96, 195, 39, 37, 185, 253, 183, 116, 234, 235, 41, 207, 108, 203, 242, 253, 49, 74, 244, 86, 164, 190, 2, 74, 171, 63, 64, 61, 115, 65, 125, 1, 58, 246, 204, 9, 6, 144, 142, 82, 63, 30, 225, 221, 177, 50, 69, 239, 28, 42, 176, 42, 207, 139, 28, 74, 232, 115, 100, 89, 210, 129, 199, 22, 163, 195, 39, 55, 240, 155, 39, 0, 48, 126, 109, 138, 59, 128, 115, 187, 82, 143, 118, 111, 68, 220, 225, 37, 56, 176, 13, 64, 32, 172, 39, 19, 41, 168, 208, 14, 250, 199, 117, 61, 146, 223, 115, 219, 114, 65, 61, 192, 128, 240, 255, 102, 111, 154, 184, 111, 233, 155, 171, 96, 47, 38, 5, 28, 243, 219, 186, 105, 54, 15, 74, 237, 104, 180, 67, 140, 90, 142, 23, 233, 88, 18, 224, 180, 141, 195, 198, 76, 136, 183, 242, 179, 18, 29, 77, 22, 4, 184, 143, 127, 208, 67, 239, 159, 46, 210, 151, 150, 132, 12, 237, 130, 157, 244, 24, 160, 183, 173, 196, 70, 16, 158, 180, 201, 218, 167, 190, 205, 250, 147, 143, 184, 140, 92, 143, 167, 55, 119, 179, 105, 210, 73, 39, 210, 101, 250, 224, 92, 78, 191, 212, 39, 12, 141, 244, 216, 191, 32, 65, 107, 207, 233, 114, 213, 154, 211, 121, 154, 209, 156, 162, 131, 60, 24, 102, 44, 212, 186, 59, 163, 35, 191, 176, 252, 245, 145, 6, 80, 235, 92, 97, 44, 170, 71, 42, 139, 134, 197, 57, 212, 25, 174, 189, 113, 48, 203, 13, 107, 170, 214, 80, 83, 169, 40, 240, 60, 60, 16, 160, 4, 30, 59, 31, 212, 113, 36, 77, 193, 85, 57, 31, 35, 64, 117, 151, 98, 86, 157, 255, 126, 138, 203, 102, 229, 230, 242, 161, 156, 232, 80, 124, 149, 3, 55, 63, 199, 170, 23, 225, 232, 96, 1, 7, 251, 191, 187, 81, 159, 238, 124, 119, 67, 15, 253, 114, 119, 150, 14, 39, 203, 129, 166, 208, 58, 171, 106, 197, 32, 4, 56, 193, 134, 222, 6, 136, 115, 5, 15, 130, 63, 124, 154, 19, 230, 124, 227, 0, 171, 108, 102, 224, 153, 220, 46, 178, 214, 202, 109, 131, 60, 68, 251, 112, 185, 94, 216, 158, 162, 11, 5, 98, 147, 72, 215, 130, 117, 119, 188, 150, 5, 230, 0, 190, 215, 132, 87, 75, 112, 190, 234, 116, 73, 54, 148, 204, 105, 225, 251, 25, 160, 194, 176, 194, 216, 9, 90, 119, 38, 207, 246, 124, 159, 216, 223, 143, 109, 76, 209, 158, 88, 73, 6, 13, 202, 131, 120, 238, 247, 254, 170, 151, 140, 57, 56, 101, 82, 97, 44, 161, 29, 206, 170, 94, 190, 187, 9, 85, 21, 167, 121, 45, 93, 180, 233, 28, 86, 197, 163, 140, 104, 142, 253, 18, 140, 48, 102, 213, 112, 67, 174, 3, 109, 112, 23, 238, 246, 225, 251, 36, 13, 117, 209, 93, 64, 112, 7, 19, 101, 177, 191, 28, 156, 206, 108, 232, 124, 60, 206, 132, 195, 219, 155, 0, 10, 0, 166, 246, 96, 146, 110, 106, 75, 208, 217, 76, 47, 253, 203, 158, 156, 188, 148, 214, 210, 174, 155, 131, 5, 152, 2, 6, 77, 111, 241, 241, 60, 29, 101, 28, 131, 137, 193, 120, 65, 199, 115, 156, 27, 88, 37, 111, 56, 87, 98, 6, 238, 163, 206, 222, 162, 168, 111, 176, 182, 47, 23, 9, 192, 249, 8, 251, 54, 145, 39, 186, 237, 61, 110, 71, 0, 72, 210, 215, 65, 223, 116, 44, 71, 39, 186, 75, 60, 179, 199, 231, 202, 227, 124, 94, 16, 150, 197, 135, 43, 20, 232, 218, 254, 72, 103, 227, 217, 94, 90, 120, 60, 35, 54, 46, 88, 26, 246, 62, 210, 18, 64, 114, 125, 161, 21, 70, 99, 50, 216, 16, 54, 167, 50, 136, 54, 52, 30, 31, 222, 190, 42, 33, 170, 233, 230, 21, 73, 122, 132, 39, 15, 231, 101, 223, 131, 1, 14, 128, 100, 132, 6, 208, 225, 115, 92, 241, 107, 129, 136, 83, 64, 15, 228, 252, 190, 224, 54, 243, 8, 208, 37, 64, 221, 146, 19, 172, 218, 132, 13, 185, 220, 50, 136, 180, 35, 97, 119, 61, 204, 182, 27, 202, 240, 207, 219, 116, 189, 241, 50, 158, 72, 72, 253, 22, 157, 167, 89, 77, 41, 218, 204, 118, 231, 150, 142, 94, 97, 162, 103, 183, 153, 150, 64, 103, 115, 93, 49, 153, 65, 71, 55, 31, 207, 154, 234, 54, 118, 66, 62, 102, 54, 92, 217, 204, 128, 231, 52, 127, 180, 57, 45, 95, 168, 195, 187, 245, 119, 172, 212, 114, 8, 208, 145, 23, 203, 139, 156, 63, 108, 232, 219, 217, 44, 2, 96, 69, 173, 139, 42, 142, 209, 219, 135, 243, 116, 42, 93, 161, 155, 86, 48, 56, 121, 224, 47, 61, 153, 23, 112, 206, 109, 225, 246, 231, 56, 40, 183, 130, 61, 70, 91, 206, 21, 232, 141, 35, 25, 250, 49, 79, 210, 186, 217, 46, 135, 214, 208, 178, 40, 97, 160, 207, 28, 164, 158, 119, 61, 100, 204, 193, 169, 29, 174, 54, 22, 42, 139, 165, 33, 56, 224, 2, 118, 94, 170, 168, 140, 232, 192, 9, 30, 37, 50, 139, 148, 17, 142, 11, 114, 209, 226, 152, 211, 123, 134, 0, 78, 79, 207, 226, 58, 99, 186, 45, 234, 238, 103, 187, 178, 202, 48, 96, 15, 116, 162, 15, 40, 62, 62, 176, 65, 39, 68, 186, 64, 111, 172, 10, 208, 48, 48, 113, 124, 237, 80, 86, 158, 141, 39, 217, 148, 187, 153, 153, 212, 235, 141, 14, 71, 26, 0, 34, 152, 237, 104, 55, 30, 141, 130, 53, 85, 213, 35, 30, 118, 185, 227, 125, 119, 180, 11, 238, 193, 14, 124, 60, 45, 250, 33, 155, 11, 254, 141, 82, 103, 201, 23, 118, 100, 40, 206, 204, 249, 117, 102, 78, 153, 220, 88, 27, 35, 143, 151, 119, 162, 12, 125, 116, 255, 58, 181, 29, 247, 198, 75, 180, 151, 181, 1, 84, 191, 150, 7, 90, 64, 227, 126, 212, 81, 166, 119, 142, 176, 9, 209, 26, 167, 79, 217, 222, 71, 219, 200, 96, 89, 160, 102, 139, 175, 50, 8, 88, 45, 143, 122, 200, 216, 171, 117, 238, 8, 89, 10, 65, 165, 153, 73, 30, 98, 27, 167, 229, 88, 47, 171, 185, 94, 106, 59, 153, 147, 209, 30, 162, 46, 2, 54, 14, 3, 126, 244, 82, 109, 156, 193, 39, 66, 238, 228, 54, 75, 75, 142, 114, 127, 56, 24, 220, 97, 5, 65, 64, 199, 101, 150, 142, 4, 48, 185, 115, 208, 161, 223, 251, 0, 212, 94, 145, 9, 137, 51, 170, 118, 158, 154, 40, 79, 109, 78, 73, 90, 120, 229, 2, 54, 158, 2, 211, 213, 36, 199, 101, 134, 123, 239, 84, 158, 206, 164, 139, 2, 78, 233, 116, 128, 142, 211, 0, 107, 174, 56, 221, 75, 229, 114, 159, 188, 71, 191, 153, 213, 59, 24, 239, 43, 216, 137, 207, 247, 74, 26, 86, 174, 151, 119, 245, 80, 119, 169, 76, 119, 174, 242, 157, 241, 0, 28, 202, 211, 65, 183, 176, 22, 138, 51, 170, 119, 116, 22, 232, 127, 143, 246, 74, 125, 95, 218, 97, 131, 9, 101, 64, 92, 78, 7, 71, 168, 241, 182, 147, 189, 82, 142, 63, 236, 215, 199, 185, 202, 150, 208, 20, 168, 119, 71, 16, 23, 247, 215, 75, 198, 126, 66, 100, 34, 141, 19, 105, 104, 176, 2, 88, 99, 195, 217, 200, 135, 188, 228, 7, 78, 193, 8, 85, 251, 36, 171, 158, 168, 60, 245, 81, 166, 90, 54, 247, 12, 40, 79, 108, 226, 227, 150, 28, 29, 102, 123, 204, 31, 90, 251, 164, 202, 179, 75, 228, 251, 232, 134, 54, 101, 34, 1, 165, 1, 80, 192, 201, 231, 119, 177, 9, 178, 254, 92, 94, 118, 164, 227, 28, 117, 9, 234, 195, 242, 213, 21, 113, 106, 61, 145, 231, 153, 59, 30, 24, 232, 36, 38, 172, 55, 212, 122, 66, 246, 144, 254, 185, 189, 32, 105, 70, 239, 7, 184, 175, 95, 150, 148, 151, 221, 186, 178, 125, 178, 99, 234, 241, 141, 150, 6, 196, 84, 50, 206, 31, 249, 32, 69, 203, 25, 84, 55, 45, 227, 114, 88, 89, 61, 47, 144, 0, 38, 55, 251, 152, 45, 99, 153, 10, 253, 241, 64, 65, 76, 40, 180, 55, 246, 129, 58, 27, 66, 94, 219, 95, 164, 127, 253, 88, 55, 84, 99, 149, 97, 245, 25, 124, 192, 65, 175, 137, 234, 71, 153, 113, 180, 58, 212, 75, 26, 2, 156, 168, 168, 52, 36, 171, 39, 175, 56, 216, 101, 222, 178, 30, 218, 211, 85, 144, 87, 116, 51, 172, 22, 241, 141, 36, 54, 203, 228, 253, 30, 236, 254, 6, 171, 244, 151, 222, 231, 17, 116, 14, 22, 181, 247, 243, 44, 26, 46, 156, 169, 43, 123, 66, 118, 94, 192, 186, 162, 150, 19, 247, 56, 112, 60, 13, 0, 96, 30, 151, 5, 19, 38, 204, 160, 149, 85, 192, 142, 186, 168, 141, 248, 184, 126, 37, 242, 179, 251, 180, 142, 0, 14, 0, 146, 160, 57, 205, 41, 186, 186, 57, 252, 12, 183, 196, 99, 213, 140, 123, 145, 6, 86, 46, 110, 92, 214, 69, 215, 180, 106, 158, 58, 105, 100, 63, 167, 225, 54, 46, 118, 205, 95, 195, 54, 36, 102, 243, 184, 79, 24, 24, 131, 29, 38, 134, 237, 230, 186, 110, 89, 76, 30, 119, 202, 138, 1, 159, 99, 96, 136, 125, 42, 241, 53, 61, 172, 161, 206, 110, 177, 250, 241, 249, 213, 75, 184, 62, 194, 232, 124, 142, 193, 192, 245, 244, 25, 187, 132, 213, 73, 26, 150, 57, 209, 8, 104, 228, 235, 87, 232, 231, 168, 239, 100, 53, 118, 231, 202, 52, 93, 191, 180, 155, 27, 207, 88, 131, 227, 13, 183, 129, 144, 47, 22, 209, 195, 119, 212, 21, 148, 106, 24, 168, 31, 54, 159, 15, 28, 185, 207, 216, 10, 231, 56, 74, 217, 57, 220, 89, 69, 0, 102, 0, 213, 112, 220, 11, 160, 169, 141, 38, 231, 150, 55, 0, 42, 157, 205, 126, 181, 55, 57, 109, 228, 97, 121, 205, 110, 78, 210, 85, 124, 223, 204, 38, 108, 120, 81, 85, 58, 151, 227, 225, 139, 36, 0, 150, 220, 239, 109, 198, 96, 68, 218, 178, 56, 143, 201, 16, 95, 11, 102, 244, 12, 112, 47, 147, 134, 235, 160, 145, 122, 160, 110, 2, 96, 206, 147, 53, 22, 210, 212, 129, 163, 101, 4, 248, 161, 206, 37, 28, 32, 149, 116, 248, 186, 197, 169, 151, 52, 128, 205, 169, 141, 87, 37, 94, 105, 110, 48, 217, 192, 192, 231, 216, 204, 33, 141, 233, 113, 208, 152, 96, 6, 111, 164, 75, 136, 176, 195, 0, 130, 56, 47, 179, 10, 83, 87, 81, 205, 30, 21, 14, 195, 199, 189, 16, 15, 29, 130, 206, 70, 57, 80, 6, 156, 99, 0, 73, 29, 144, 30, 119, 156, 119, 62, 196, 63, 114, 32, 249, 112, 124, 7, 138, 135, 105, 90, 28, 23, 236, 137, 73, 144, 213, 13, 215, 1, 130, 215, 247, 231, 228, 147, 56, 171, 207, 20, 105, 245, 103, 101, 90, 113, 138, 143, 240, 179, 188, 117, 216, 77, 4, 157, 80, 42, 51, 34, 173, 14, 1, 158, 48, 38, 31, 193, 176, 0, 171, 130, 43, 108, 111, 132, 41, 99, 170, 106, 87, 160, 251, 117, 14, 227, 1, 35, 32, 100, 144, 79, 91, 124, 158, 175, 113, 91, 242, 53, 196, 245, 117, 90, 175, 87, 189, 164, 97, 212, 122, 237, 185, 135, 5, 157, 199, 141, 167, 12, 164, 29, 31, 101, 151, 97, 9, 131, 28, 203, 44, 33, 107, 170, 61, 235, 179, 117, 60, 54, 197, 147, 29, 148, 71, 58, 8, 247, 224, 40, 231, 97, 89, 221, 102, 147, 114, 243, 117, 204, 130, 5, 100, 230, 215, 188, 184, 252, 198, 186, 94, 47, 128, 10, 245, 18, 102, 150, 151, 210, 80, 191, 36, 79, 106, 226, 148, 46, 151, 116, 69, 66, 30, 56, 84, 155, 26, 239, 30, 193, 163, 69, 173, 131, 151, 101, 246, 130, 144, 189, 61, 12, 126, 73, 223, 226, 234, 0, 65, 121, 144, 183, 198, 147, 50, 153, 122, 247, 39, 87, 126, 143, 131, 18, 126, 28, 161, 21, 124, 144, 225, 126, 57, 214, 73, 26, 70, 173, 247, 39, 104, 12, 128, 1, 162, 91, 192, 180, 113, 194, 37, 152, 234, 198, 145, 248, 53, 34, 13, 56, 128, 96, 151, 209, 214, 243, 165, 128, 49, 245, 96, 32, 101, 193, 95, 204, 152, 207, 54, 26, 242, 246, 14, 18, 166, 65, 218, 156, 167, 3, 214, 175, 129, 241, 176, 231, 84, 65, 172, 203, 54, 154, 151, 170, 67, 116, 44, 212, 164, 222, 167, 54, 165, 148, 221, 152, 74, 6, 34, 199, 193, 115, 124, 148, 73, 224, 136, 255, 54, 88, 224, 199, 71, 188, 238, 94, 221, 195, 247, 106, 92, 228, 41, 118, 167, 45, 45, 73, 25, 57, 77, 31, 32, 209, 182, 145, 178, 240, 32, 240, 120, 126, 205, 1, 231, 247, 138, 176, 31, 31, 9, 19, 150, 5, 120, 5, 192, 214, 238, 162, 254, 109, 208, 213, 73, 26, 14, 156, 1, 0, 172, 177, 68, 156, 113, 130, 115, 111, 200, 80, 21, 214, 74, 144, 6, 26, 114, 0, 249, 230, 170, 4, 157, 77, 235, 100, 8, 29, 31, 56, 172, 119, 242, 57, 158, 107, 3, 192, 146, 166, 131, 146, 239, 11, 192, 200, 126, 61, 90, 222, 40, 91, 19, 38, 15, 29, 1, 99, 250, 125, 106, 175, 241, 0, 99, 21, 171, 75, 70, 12, 98, 187, 87, 69, 203, 132, 9, 201, 238, 152, 238, 39, 16, 199, 30, 43, 33, 187, 10, 237, 138, 23, 105, 86, 51, 180, 9, 167, 1, 117, 142, 50, 33, 93, 75, 31, 44, 172, 107, 160, 58, 107, 151, 246, 179, 114, 58, 248, 17, 15, 215, 0, 74, 31, 96, 170, 230, 217, 84, 249, 139, 154, 48, 90, 79, 221, 134, 24, 0, 93, 30, 205, 106, 157, 100, 192, 33, 253, 58, 201, 152, 131, 83, 42, 138, 198, 66, 3, 73, 67, 105, 24, 174, 225, 60, 184, 102, 106, 19, 141, 41, 170, 15, 141, 83, 147, 86, 84, 130, 123, 251, 185, 22, 149, 199, 54, 102, 168, 172, 154, 92, 193, 192, 63, 170, 60, 53, 16, 107, 139, 82, 70, 196, 151, 206, 178, 142, 1, 224, 56, 204, 5, 231, 210, 201, 8, 199, 117, 171, 143, 196, 147, 114, 24, 40, 56, 28, 162, 187, 214, 189, 206, 202, 154, 202, 126, 157, 242, 182, 101, 94, 247, 94, 176, 3, 131, 71, 93, 69, 182, 214, 121, 89, 132, 61, 145, 63, 202, 17, 73, 191, 122, 54, 109, 192, 242, 107, 118, 68, 94, 126, 212, 114, 104, 221, 148, 197, 195, 7, 4, 136, 3, 191, 230, 3, 155, 214, 210, 197, 253, 150, 119, 61, 164, 161, 213, 250, 72, 72, 208, 41, 220, 144, 226, 143, 28, 97, 87, 253, 124, 103, 228, 115, 47, 230, 209, 131, 66, 244, 201, 205, 250, 100, 6, 105, 161, 211, 164, 243, 208, 105, 152, 13, 215, 228, 213, 159, 72, 167, 122, 103, 214, 8, 202, 161, 162, 19, 23, 73, 151, 65, 181, 252, 84, 248, 41, 28, 148, 65, 202, 99, 158, 243, 153, 34, 221, 180, 220, 103, 245, 92, 175, 126, 210, 157, 40, 50, 225, 193, 169, 157, 24, 57, 7, 184, 248, 8, 80, 96, 93, 240, 255, 142, 213, 126, 77, 35, 116, 105, 102, 175, 239, 172, 197, 179, 104, 190, 23, 0, 151, 251, 156, 237, 134, 6, 140, 75, 1, 83, 202, 101, 101, 147, 244, 236, 239, 199, 63, 188, 73, 159, 103, 139, 26, 23, 64, 26, 115, 178, 31, 143, 86, 255, 116, 16, 207, 248, 113, 15, 171, 109, 174, 75, 127, 105, 79, 20, 153, 20, 224, 84, 96, 65, 85, 49, 24, 34, 224, 252, 187, 165, 9, 218, 19, 235, 173, 1, 103, 168, 70, 241, 231, 85, 176, 203, 93, 192, 29, 128, 51, 154, 230, 197, 249, 93, 74, 28, 140, 238, 143, 134, 203, 114, 212, 95, 226, 250, 53, 229, 211, 182, 187, 202, 139, 97, 79, 173, 224, 146, 197, 62, 250, 134, 108, 219, 195, 183, 56, 249, 254, 41, 112, 142, 127, 113, 150, 3, 176, 0, 42, 0, 2, 254, 175, 191, 159, 148, 191, 78, 113, 41, 183, 244, 116, 65, 216, 85, 210, 137, 164, 17, 216, 92, 159, 67, 106, 1, 41, 131, 68, 4, 140, 201, 42, 157, 85, 244, 115, 219, 216, 196, 176, 71, 167, 112, 209, 109, 123, 120, 123, 234, 205, 3, 89, 217, 223, 233, 19, 151, 104, 250, 19, 81, 38, 5, 56, 125, 33, 223, 153, 70, 216, 143, 253, 216, 8, 92, 11, 205, 240, 188, 66, 191, 253, 68, 39, 30, 186, 108, 98, 233, 129, 125, 45, 221, 32, 236, 115, 136, 0, 179, 10, 220, 58, 89, 193, 251, 61, 120, 187, 19, 249, 70, 203, 0, 176, 226, 28, 127, 65, 3, 155, 136, 49, 67, 198, 172, 223, 53, 64, 52, 237, 137, 38, 147, 135, 57, 89, 208, 161, 209, 153, 235, 43, 123, 122, 20, 3, 162, 67, 85, 143, 10, 48, 248, 167, 84, 182, 119, 212, 5, 156, 53, 172, 23, 77, 215, 252, 131, 137, 131, 50, 10, 76, 31, 36, 243, 90, 98, 180, 37, 6, 80, 114, 25, 80, 128, 0, 157, 118, 206, 170, 253, 63, 246, 233, 251, 60, 184, 15, 123, 72, 81, 134, 169, 9, 209, 56, 23, 7, 67, 212, 110, 4, 32, 96, 231, 189, 119, 82, 247, 142, 70, 157, 96, 131, 127, 192, 98, 120, 55, 62, 154, 134, 136, 167, 225, 231, 159, 67, 116, 112, 216, 57, 179, 49, 214, 14, 241, 134, 102, 43, 207, 206, 171, 212, 185, 128, 82, 129, 137, 160, 221, 12, 220, 185, 45, 17, 166, 230, 193, 2, 160, 58, 88, 39, 170, 76, 124, 230, 20, 48, 233, 26, 35, 152, 78, 89, 51, 41, 111, 35, 226, 239, 161, 7, 236, 4, 32, 216, 83, 24, 204, 65, 246, 37, 244, 141, 73, 1, 38, 223, 231, 0, 21, 182, 52, 213, 94, 5, 218, 75, 136, 176, 163, 167, 97, 224, 68, 24, 128, 53, 183, 53, 69, 45, 237, 250, 232, 84, 115, 102, 103, 229, 240, 115, 216, 196, 15, 227, 111, 94, 90, 25, 36, 61, 216, 157, 72, 11, 101, 169, 201, 111, 34, 73, 221, 193, 137, 78, 16, 150, 49, 213, 136, 6, 214, 13, 11, 214, 209, 145, 184, 245, 16, 228, 47, 19, 24, 87, 205, 0, 22, 119, 44, 94, 101, 192, 206, 112, 117, 0, 105, 212, 85, 168, 237, 164, 238, 97, 172, 77, 175, 86, 100, 243, 45, 210, 52, 160, 226, 88, 5, 70, 3, 149, 196, 199, 196, 135, 195, 32, 248, 130, 201, 7, 103, 116, 61, 51, 0, 38, 59, 245, 123, 121, 42, 244, 171, 221, 186, 129, 89, 210, 226, 124, 166, 241, 4, 10, 251, 47, 171, 254, 114, 198, 4, 149, 250, 51, 39, 179, 148, 110, 108, 64, 39, 234, 179, 95, 52, 170, 44, 133, 96, 121, 167, 191, 123, 70, 80, 36, 111, 159, 64, 88, 7, 35, 252, 7, 155, 96, 111, 42, 99, 217, 119, 68, 196, 7, 135, 176, 87, 63, 201, 133, 160, 26, 72, 48, 192, 32, 146, 118, 184, 193, 194, 65, 10, 150, 147, 191, 231, 9, 251, 16, 101, 224, 107, 207, 109, 79, 201, 91, 152, 250, 252, 30, 46, 122, 84, 63, 198, 77, 107, 123, 145, 211, 51, 27, 57, 96, 127, 75, 91, 210, 27, 66, 249, 198, 177, 140, 2, 115, 242, 145, 59, 15, 32, 241, 14, 195, 236, 121, 168, 106, 113, 216, 130, 188, 237, 189, 120, 183, 19, 113, 252, 227, 126, 219, 38, 23, 165, 45, 6, 6, 78, 211, 165, 138, 252, 237, 75, 47, 239, 64, 34, 233, 217, 49, 10, 84, 13, 211, 181, 85, 177, 13, 57, 28, 239, 189, 99, 11, 28, 254, 8, 172, 238, 24, 13, 213, 185, 28, 249, 71, 44, 11, 150, 77, 231, 138, 250, 76, 31, 233, 1, 152, 156, 166, 107, 28, 205, 67, 205, 20, 201, 119, 130, 202, 168, 168, 117, 97, 149, 160, 33, 185, 161, 229, 185, 50, 24, 97, 116, 26, 87, 54, 223, 114, 167, 98, 128, 200, 178, 18, 135, 109, 186, 144, 3, 28, 106, 191, 101, 45, 148, 117, 62, 87, 146, 191, 80, 17, 150, 249, 210, 34, 108, 236, 254, 90, 192, 242, 181, 27, 150, 39, 232, 197, 29, 61, 180, 177, 163, 82, 181, 166, 42, 62, 1, 34, 10, 16, 50, 54, 28, 222, 214, 196, 35, 74, 7, 182, 2, 19, 128, 183, 215, 129, 189, 92, 83, 204, 57, 76, 65, 67, 202, 91, 136, 120, 118, 204, 51, 84, 86, 231, 215, 240, 100, 100, 110, 107, 92, 94, 41, 0, 59, 212, 83, 240, 222, 187, 251, 191, 212, 28, 167, 171, 151, 38, 233, 198, 21, 49, 186, 0, 226, 100, 52, 96, 161, 27, 123, 38, 163, 44, 182, 179, 179, 34, 79, 107, 176, 227, 30, 47, 164, 13, 36, 136, 131, 60, 176, 28, 116, 221, 210, 4, 221, 190, 58, 45, 223, 248, 252, 221, 222, 172, 108, 16, 238, 200, 232, 167, 108, 116, 54, 142, 99, 228, 221, 120, 3, 165, 56, 4, 178, 124, 216, 81, 160, 27, 49, 48, 172, 237, 100, 199, 250, 66, 48, 166, 217, 206, 248, 138, 94, 48, 216, 167, 102, 235, 195, 18, 101, 16, 219, 218, 198, 13, 250, 194, 182, 44, 157, 202, 148, 232, 88, 50, 39, 118, 215, 161, 84, 177, 174, 114, 164, 59, 79, 7, 123, 74, 242, 81, 132, 35, 169, 146, 60, 146, 196, 167, 88, 96, 211, 5, 32, 177, 89, 186, 252, 242, 15, 94, 0, 91, 125, 182, 36, 47, 215, 13, 42, 103, 138, 180, 45, 86, 145, 244, 207, 103, 202, 242, 233, 25, 97, 66, 1, 97, 4, 124, 236, 60, 125, 136, 248, 109, 64, 56, 121, 99, 18, 22, 253, 172, 35, 216, 30, 203, 77, 210, 134, 0, 35, 11, 128, 9, 141, 35, 147, 36, 132, 71, 218, 122, 162, 73, 253, 153, 19, 98, 141, 58, 167, 165, 147, 150, 157, 194, 107, 169, 246, 173, 35, 237, 147, 186, 58, 201, 131, 127, 52, 47, 128, 70, 60, 230, 13, 217, 210, 213, 43, 206, 37, 140, 127, 130, 107, 3, 186, 106, 0, 234, 121, 52, 76, 243, 12, 151, 135, 236, 186, 37, 142, 50, 224, 227, 99, 248, 74, 221, 108, 219, 153, 36, 128, 180, 229, 34, 177, 147, 177, 63, 20, 108, 41, 76, 89, 61, 65, 234, 183, 189, 39, 136, 140, 14, 115, 194, 207, 0, 189, 110, 89, 151, 176, 151, 245, 74, 208, 65, 245, 117, 33, 80, 0, 63, 252, 61, 115, 103, 74, 205, 223, 0, 234, 101, 193, 49, 80, 189, 81, 144, 125, 17, 87, 13, 118, 208, 181, 166, 11, 167, 105, 111, 233, 40, 201, 43, 189, 0, 155, 188, 251, 35, 172, 8, 112, 106, 155, 137, 93, 105, 108, 169, 0, 69, 155, 234, 170, 135, 159, 79, 84, 25, 133, 9, 145, 206, 212, 177, 164, 116, 219, 202, 184, 124, 173, 34, 96, 145, 176, 167, 198, 173, 11, 128, 110, 78, 217, 56, 10, 120, 99, 74, 184, 32, 106, 69, 190, 238, 241, 243, 29, 89, 154, 215, 154, 12, 84, 183, 11, 152, 113, 162, 179, 226, 80, 164, 254, 106, 157, 237, 205, 25, 246, 58, 194, 19, 155, 210, 220, 153, 220, 55, 50, 49, 208, 110, 154, 48, 14, 172, 88, 91, 41, 59, 149, 42, 27, 104, 97, 103, 255, 122, 79, 86, 62, 180, 0, 118, 20, 96, 250, 223, 187, 228, 129, 172, 54, 165, 130, 115, 178, 3, 116, 84, 152, 83, 84, 20, 55, 250, 255, 28, 192, 20, 25, 192, 28, 41, 181, 217, 24, 78, 65, 105, 108, 9, 23, 177, 95, 139, 229, 18, 157, 201, 247, 201, 100, 231, 39, 155, 153, 41, 121, 102, 239, 234, 24, 179, 111, 7, 160, 44, 170, 67, 85, 179, 168, 77, 201, 130, 115, 28, 39, 169, 212, 159, 57, 1, 78, 116, 0, 31, 119, 197, 194, 53, 189, 176, 39, 199, 185, 179, 122, 192, 146, 198, 87, 139, 241, 149, 183, 19, 233, 62, 218, 196, 182, 228, 59, 135, 211, 178, 179, 9, 159, 147, 209, 246, 80, 134, 116, 102, 12, 212, 183, 129, 242, 34, 48, 214, 158, 79, 50, 25, 21, 181, 142, 70, 70, 39, 180, 158, 200, 209, 238, 120, 65, 62, 31, 253, 113, 103, 175, 124, 84, 234, 227, 206, 82, 93, 101, 123, 172, 119, 64, 217, 21, 43, 14, 75, 182, 119, 150, 249, 88, 160, 141, 231, 114, 180, 168, 61, 71, 175, 236, 201, 208, 99, 27, 123, 232, 150, 21, 9, 154, 219, 146, 212, 25, 184, 169, 106, 48, 38, 158, 242, 56, 32, 125, 57, 40, 0, 168, 181, 153, 156, 71, 219, 112, 146, 74, 221, 193, 169, 111, 77, 134, 140, 225, 51, 82, 116, 0, 58, 7, 97, 245, 148, 218, 242, 212, 74, 127, 247, 124, 30, 17, 147, 197, 197, 234, 3, 59, 18, 179, 108, 128, 82, 55, 134, 192, 190, 116, 32, 178, 13, 142, 55, 35, 17, 214, 164, 203, 66, 46, 72, 35, 0, 107, 52, 221, 73, 42, 117, 7, 167, 216, 85, 220, 17, 186, 51, 72, 215, 234, 208, 97, 13, 211, 1, 54, 88, 190, 168, 4, 96, 194, 57, 167, 167, 245, 210, 193, 40, 215, 0, 80, 219, 120, 130, 175, 105, 132, 31, 40, 208, 199, 170, 126, 191, 131, 51, 42, 154, 214, 197, 225, 147, 69, 70, 65, 173, 107, 199, 249, 35, 56, 249, 155, 226, 0, 233, 68, 121, 46, 108, 245, 131, 255, 34, 128, 129, 61, 49, 209, 97, 176, 226, 90, 0, 54, 180, 7, 206, 101, 176, 90, 56, 210, 112, 177, 48, 89, 219, 244, 180, 38, 161, 212, 31, 156, 83, 50, 37, 95, 80, 166, 192, 57, 37, 13, 43, 83, 224, 156, 146, 6, 149, 46, 250, 127, 10, 83, 72, 239, 103, 135, 177, 173, 0, 0, 0, 0, 73, 69, 78, 68, 174, 66, 96, 130 };
            con.Insert(new Category(1, 1, 0, "Home", "Omschrijving van Deze categorie", categoryImage));
            con.Insert(new Category(2, 2, 1, "Automotive", "Omschrijving van Deze categorie", categoryImage));
            con.Insert(new Category(3, 3, 1, "Zakelijk", "Omschrijving van Deze categorie", categoryImage));
            con.Insert(new Category(4, 4, 1, "Particulier", "Omschrijving van Deze categorie", categoryImage));
            con.Insert(new Category(5, 5, 2, "Laadinfrastuctuur", "Omschrijving van Deze categorie", categoryImage));
            con.Insert(new Category(6, 6, 2, "Subsidies", "Omschrijving van Deze categorie", categoryImage));
        }

        public void GetCategory(SQLite.Net.SQLiteConnection con)
        {
            var query = con.Table<Category>();

            foreach (var message in query)
            {
                pageID = message.pageID;
                categoryID = message.categoryID;
                categoryParentID = message.categoryParentID;
                categoryName = message.categoryName;
                categoryDescription = message.categoryDescription;
                categoryImage = message.categoryImage;
            }
        }

    }
}
