using UnityEngine;

namespace IIDKQuest.Mods
{
    public class GRAPHICS
    {
        public static void Graphics1() => QualitySettings.masterTextureLimit = 1;
        
        public static void Graphics2() => QualitySettings.masterTextureLimit = 2;
        
        public static void Graphics3() => QualitySettings.masterTextureLimit = 3;
        
        public static void Graphics4() => QualitySettings.masterTextureLimit = 4;
        
        public static void Graphics5() => QualitySettings.masterTextureLimit = 5;
        
        public static void Graphics6() => QualitySettings.masterTextureLimit = 6;
        
        public static void Graphics7() => QualitySettings.masterTextureLimit = 7;
        
        public static void Graphics8() => QualitySettings.masterTextureLimit = 8;
        
        public static void Reset() => QualitySettings.masterTextureLimit = 0;
    }
}