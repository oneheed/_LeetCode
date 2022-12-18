// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

var solution = new Solution();

var input1 = new string[] { "aba", "aabb", "abcd", "bac", "aabc" };
var output1 = solution.SimilarPairs(input1);
Console.WriteLine(output1.ToString()); // [4,7,2,9,6,3,1]

var input2 = new string[] { "aabb", "ab", "ba" };
var output2 = solution.SimilarPairs(input2);
Console.WriteLine(string.Join(",", output2)); // [1,2,3,4,5]

var input3 = new string[] { "nba", "cba", "dba" };
var output3 = solution.SimilarPairs(input3);
Console.WriteLine(string.Join(",", output3)); // [3,4,6,16,17]

var input4 = new string[] { "plntapbbzbprlgmigthrfftiybuzqafmxzjefhjolxgmyaqpxbdcvfnrwsfidftnvitwrmgibipdzffijgsliveujcjxszbxctbn", "hjtcltozhhrutdcapgamfubaasmclgomilzxrslefushzphsspibubzodzsfjcxxelbmurzejbzbhwtfjxkntdufxwfryvxfbjop", "lgzijonyjczyadsqijqwkztstalcdboeidjkpfsxtuxchbejkthfufvhquzavwaeorfzzplxjrupzjwswnznbgckvyoxasumddxq", "nrockaszobnijtvpjakbnquyxvwupedqfjzimpyunoapgvcgyvoeidtbhyxdmwdoggjlnqlddvybliwilnwwrsvwanqftypovalr", "gguzloidcwrbvmeibchntrdkrcwmixdxufhzowwwadgyokdqxopilqiyemieknqjscxzneypayassdpoumkinyhyrckvtypsuvav", "nocgedjbgnlsqzndqkhmoiqftmlcunfqsskffxjqvvdflcaclzvjwzaoqopbmfowitxmhxlibktghftfzmwpaxgpboebyllgjdyz", "spdmcdarsouwbvwuhgrsqiuhaonjqqauqveeutrjesxqfzczgjpulgwpsckznkrakkkfgzdyqihhjkvdaoiiabsyrbbvyghygurz", "lwoqahfuhzihzuzhpsolhjnguhwctizxkcqqfwkkgtloxgjlqazuxwddmplndelapotmqnnqgnglbbfisorewjmeaynkriwynctt", "kpfelnapfzgducwzydsaawvrumyxiikszkwxnjtsvnitunmewnrccqyzzeqnavxaghvbrsbeofyghxpwtukohvveksneitacfrlm", "gumflyplqykjekbbtysjrazwgkywrjtoetqrinozaiwktcambnbykxyilqazpvuabshgqwdmftpvnfxcbhioqifnkyosglvjtwxq", "arfudruibazjxjczbukfhtodoxffzcubfzgyoebaexehrnuxprqsxpsfngsgaddonbununchsubkgqqagwalxjlesdatjazzjohl", "xacuphctwrinbrpqoqafheiyqfaqmvlliyppzrrpaxbcikkdlrylsgrntftadwxprylgjfcnmzfkxlnvbaefvhdeahfwilnaqjyp", "jfotcgwwvypfgncddpnrytjvnjmfqnxcsqizhgzpuwmweyhfxpgorvcvjgormmvxhzvncpjnpqjclwecjwgprollpowlhctwuine", "rujgqfdwillfmmnzdglfvdhgfphouadwqznaxoablwfjfanuclrzwtfgteitaxuqmyedahfmgphdxicaalqgrqkdgbnthkszalbz", "ymiksftppvdonbrefymiatsajtnzeggdjjopryxaorrdutictdoevpzwgdleioovhkgzmjntqsyzwrcpunvljcuiaiijzescqxqt", "bnxmzwjhlwjqblmkcgnvvbewtapkqxzjhbqsevcpnlfyeakifolyckxcawodypdvyttamczbdvvxhqtwnzjlxduvjarhjeajqsbk", "xoocqirxmydybhtduvxyrmgrqgrcalgucjmnqurvfzbtvexnvwibrylhobskfatfevzahcmiqigrvwajqflptomtsdrnzvjysunf", "dsqpijuaxoeaarebthvsywawpiekpumntywoslhtmihmcrvqtyiuoxjcozodmqstbvchvhmfxyhupyhzhpkphosdraabplqrhklg", "npamwwhaiethrrermaymgudjppkjsiomsfwhlrzgfuqwjztzkngnswnyepiumlpffomkmzbkkvbhdwcszqvjwvzdbmpvjbifnaut", "rtvxtqceflxvdtkifnegnoxhuhxgtfwwwgczqcitebcpgzcxnayqysupbrxrjouisofsmwcxxirprhcprhnefmrghiammiprheyt", "tbqkzrrpasqlnlsseowikggeozwwkdpxjtqczlytbrhyxykljckjxsymkmipgvmkstpszhueredvluzdhnfrcpsssrhqlkmugaea", "lfdnjvjbuvymokfnpgucanwocgabvcknfkibugauevorvymhuglgwrhbwarfizwmqnrdjawejjarrbpymfouudpuvzokfhydmnnu", "sxwwogzpckttogqgqdxtkswefaryrifvlgepxitulburnoynemdawmdvmyhaplbkkdpglgefudvaxeywwdqkajcsdhozrpqrgysl", "skopnvyycyixjljggpumirwbqesrkwmekeyqcvmirkgelrzcjwphitowtmwuwurztzijhfyldsxrbmacpgdibfksecidphzlkdih", "minbjdtavzddatyozxjaqukpzrsxxunyattseprcogxbblslmwcehcsrcqscfpnxropyqhrstcaaofrcgoygvzgrsplydtkfnohr", "qhsibdvizbbvkzmvirzbbyrgyhmirprhufdcafyierkdjeifgboyckwkzgvwrwdhplwwpmycwqbsevrhrxsttplfltjiwcuwbdcd", "lxwleqlbvsguqzpeuroblcifzdvcgndikbdpjjoqbopaalikmqjwnqavmxvnptdvtbnlxmdtqkmnvpuuxpskirgbabbotqyxtwbs", "fibsmtvbtoomhpnqxycfocnsgxqbmbpehqwcngyiffuvvxklzikwvycbfpebpdsujtlboyhoajfonheodvlkbcgxnrkaywnfxqxy", "sxsicfkwgupzmlnhhroujvawzvyalwfuvcdgisbaaimofknfmhipjgqkedxwlwxeznvjfohvrldezghantihlbzyxvsxqkkmvird", "xsodvmwgflnmzesvgzuqhspoxpgucbnlfzromucrtwbmtfwjvpdrnunjgjzuegpumlwycqvfypbgtxqglelvxrgnomxbfspeixjv", "gzsvenflvwgdlrvghvahdxlkerjkxxalguoscdlwtbyinmzhyqhmfjcpffiqypqalkactukoexzrbnjlvytpzpfgjxdvteqkcqrn", "wysmkhxyyvqipuyhddxisvoskzehueyiegswozzaqlgrfrcoemgbyjvmlftpodxlsfryzqtadnxiatprckixtrfgebmykuiahign", "pzpabdaedicdazvkopjnbnnjmkrjultzllvjfmmfjqckojtmkqabtubliqlqcdkiaboaednedvtbfsieuybfmhbfphbpipqetjav", "yfffxdwrfnadqfasjbvuriewyoenfvifbxjzbljhhyxrhwmmavxycbjfadcbbshvwefujiczajmxjnxanwshxoklbejeyxromfvp", "ejktmqhlxingfnpywdvwdwttckygxmmwsjtjchwauqkhfzybrhzoaoiafoblaumvccmymmnskhcaqttsteyksnreakbbwzmbbbeu", "fxfwsdgfsciijmopqmadtggxlozfduxqrmpnryfprxrdyzjbbxipvhbhmwoesjptdasvuixmhsdvhlgtulroypvyfldjpvxwmpqe", "zkyyocldpdkgvhkkyphvkektbcbfuosgxtfotymporoxrytmtqcjydgpxbswiojasukgdpcrujoxuykxzlgmutebqdldftycskvl", "xketvlhiweehhxoaejjhtwidzszsxxxjgbihtnugpeniwryncctnzibxxqgeouelfjknqoekbgcvuncfxwawzxqypsnqrfjnmjmq", "iboujlmigomsskldcninsltbdsqdcneffpwcdedocqgsmfscvbiwzeocisrescanvdqnarrgvcaildjobypktiepvvihzfiepqjf" };
var output4 = solution.SimilarPairs(input4);
Console.WriteLine(string.Join(",", output4)); // [3,4,6,16,17]


public class Solution
{
    public int SimilarPairs(string[] words)
    {
        var result = 0;

        for (int i = 0; i < words.Length; i++)
        {
            var word1 = string.Join("", words[i].Distinct().OrderBy(x => x));

            for (int j = i + 1; j < words.Length; j++)
            {
                var word2 = string.Join("", words[j].Distinct().OrderBy(x => x));

                if (word1 == word2)
                {
                    result++;
                }
            }
        }

        return result;
    }
}


