'引用
Imports System.Reflection
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports IZ_Format_Designer_V2.PVZ
Imports PvZHomeAPI



Public Class Main

#Region "声明与定义"

    '布阵器已不再更新维护 ——2025.3.1

    Public Declare Function RegisterHotKey Lib "user32" (ByVal hWnd As Integer, ByVal id As Integer,
                                                    ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    Public Declare Function UnregisterHotKey Lib "user32" (ByVal hWnd As Integer, ByVal id As Integer) As Integer

    '打开超链接
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
    Public hWndOpenLink As Long

    Public Levels_ForBeginners(17) As String
    Public Levels_Winkle(9) As String
    Public Levels_Magnet(24) As String
    Public Levels_NotFull(14) As String
    Public Levels_Adventure(25) As String
    Public Levels_OutOfRange(18) As String
    '新关卡
    Public Levels_Portal(18) As String
    Public Levels_Competition(13) As String
    Public Levels_IZECollections(135) As String

    Public MyLevelCollection(99) As String

    Public TipRandomizer As New Random

    Public Const WM_HOTKEY As Short = &H312S '热键消息ID
    Public Const MOD_ALT As Short = &H1S  'ALT
    Public Const MOD_CONTROL As Short = &H2S  'Ctrl
    Public Const MOD_SHIFT As Short = &H4S  'Shift
    Public uVirtKey1, Modifiers, idHotKey As Integer

    '速度数据读取
    Public SpeedData As Integer


    Public Plantable As Boolean
    Public CardType As PVZ.PlantType
    Public GameFound As Boolean = False
    Public LevelCode As String
    '选植物指示器上移7格
    Public YPlusUp As New Point(0, -7)

    Public ZombieCardTypeInfo() As String = {"路障", "撑杆", "铁桶", "扶梯", "矿工", "蹦极", "橄榄", "气球", "铁门", "冰车", "跳跳", "舞王", "巨人", "小鬼"}
    Public ZombieCardTypeInfoStar() As String = {"路障★", "撑杆★", "铁桶★", "扶梯★", "矿工★", "蹦极★", "橄榄★", "气球★", "铁门★", "冰车★", "跳跳★", "舞王★", "巨人★", "小鬼★"}
    Public ZombieCardTypeIndex() As Integer = {2, 3, 4, 21, 17, 20, 7, 16, 6, 12, 18, 8, 23, 24}

    Public ZombieCardSunInfo() As String = {"普僵/小鬼", "路障/撑杆", "舞王", "铁桶/矿工/蹦极", "扶梯/气球", "橄榄/冰车", "巨人"}
    Public ZombieCardSunInfoStar() As String = {"★普僵/小鬼", "★路障/撑杆", "★舞王", "★铁桶/矿工/蹦极", "★扶梯/气球", "★橄榄/冰车", "★巨人"}
    Public ZombieCardSunValue() As Integer = {50, 75, 350, 125, 150, 175, 300}

    '记忆三按键数字
    Public Plant_Key As Integer
    Public ShovelOnce_Key As Integer
    Public SpeedUp_Key As Integer

    '统计数据
    Public PlantsPlanted As Integer
    Public LevelsGenerated As Integer
    Public RunningTime As Long
    Public StartTime As DateTime
    Public EndTime As DateTime

    Public KeysIndexDictionary() As Integer = {Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.Q, Keys.W, Keys.E, Keys.R, Keys.T, Keys.A, Keys.S, Keys.D, Keys.F, Keys.G, Keys.Z, Keys.X, Keys.C, Keys.V, Keys.B, Keys.Tab, Keys.Space}

#End Region

#Region "程序启动时"


    '程序启动时
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '检测多开
        If UBound(Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName)) > 0 Then
            MessageBox.Show("本程序已打开", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End
        End If


        '记录启动时间
        StartTime = DateTime.Now

        '寻找游戏
        FindGame()

        '关卡信息定义
#Region "内置关卡代码" '所有Pro关卡代码必须带有四个"\"符号用来拆分


        '0 新人友好

        Levels_ForBeginners(0) = "IZFAPoJ/yz032149DqcecUcgIsIOIhIVIofWfLDXDEEiEYEDANArApAfAKAABMBCBB\萌新三连击\俾斯麦の龙\1\有多种方法通过这个简单的关卡，关键是哪种是最优的解法？（最优：925）"
        Levels_ForBeginners(1) = "IZFAPoE/yz9IpRMEABsMYGhRgMDECGqBfGiMLGEBKIoGVRXIOEU5B5e5W5N5r\新概念即死\Winkle雪线\1\最优解：900。五种常见瞬间秒杀类植物，每个都有自己不同的特性。"
        Levels_ForBeginners(2) = "IZFABkD/yzdAGpVUBOGCBqRfhoEDAeGiGhGMBXFNHYuoGWVKRgFrRLSBcsFVBE\垫的艺术\阿仙\2\最优解：25。""垫""是指一个僵尸在前进的过程中，补其他僵尸从而消掉秒杀植物保活行进僵尸的操作。通常用小鬼来垫，也被称之为""垫鬼""。现在拿这个关卡练练吧，利用小鬼将一次性植物祸水东引！"
        Levels_ForBeginners(3) = "IZFACWC/zVABYIXGeNLNONiNUNgNMBEBDGfNBEsDNIqNWKoVKEVICNpVhGr\杆胆相照\Winkle雪线\1\最优解：100。要充分拖延胆小菇缩头的时间，才能吃掉二路的坚果！"
        Levels_ForBeginners(4) = "IZFAPoJ/yz032149cqcsBKHXcMBWcfIOcCHAnBIVIhIiIoFpHUFrcEIDnNFLcYFeHg\歪瓜裂枣\俾斯麦の龙\1\最优解：500。梯子拥有高移速，并且可以免疫寒冰的减速。不过上面的西瓜又该怎么化解呢？小心西瓜的溅射伤害！"
        Levels_ForBeginners(5) = "IZEADhDy60MNBDVLEoBrieEXdpuqFUVsKKFAVMNVSgFfoWNCFBBh\基础连破\阿仙\2\最优解：150。铁门不会被减速，但是惧怕投手和地刺。尝试合理使用阵容，通过本关吧！"
        Levels_ForBeginners(6) = "IZFAPoJ/yz032149MVGUVrVLVDRORWRgRpBqBhBEGfGMGCIsIiIYIKIBKXKNKoKeKA\魅飞色舞\俾斯麦の龙\1\最优解：900。舞王如果放在三路，如何解决魅惑菇带来的威胁呢？"
        Levels_ForBeginners(7) = "IZBAB9C23BrGMfkkABBHp0LcVfFVUBN0fcGcoWqBWBHVKEg\逆向工程\Winkle雪线\2\最优解：0。一个小提示：如果反向矿工能堵住反向双发的枪口，那么双发就不会射出子弹。"
        Levels_ForBeginners(8) = "IZFACWD/60GpgLhoVoBNBrKiFqgfVMSUMVKEgDSABsBKFWHeRYKhKOFCHgHBRX\各有所长\阿仙\2\最优解：50。铁桶与铁门血量相同，一个可以防止穿透伤害，另一个则可以不易被减速，那么选择合适的僵尸组合尤为重要。"
        Levels_ForBeginners(9) = "IZFADICz+EfBDkYGLFqkgcOkBRikhRAREMoGeRsBVVMkCBWBXopVKXrGUBN\震撼来袭\Winkle雪线\1\最优解：0。巨人受到窝瓜伤害的位置不同，会导致小鬼的落点也不同，注意控制距离哦。"
        Levels_ForBeginners(10) = "IZFAPoJ/yz032149VsVVVfVpSiSqSUSLNrNYNeNKIoIgICIBIAdhdXdWdNdMBOBEBD\悬梁刺菇\俾斯麦の龙\1\最优解：925。面对如果多的杨桃和三线，是单独破解还是同时进攻呢？"
        Levels_ForBeginners(11) = "IZGACWI/yz03214itGUcNBARVFilqBZnrWOFeBFXPGBHjBgMXKKGDBsBCcfEEALSMfpdoIhVYVW\大混战\Winkle雪线\1\最优解：300。每条路线都是一个小组合，选择最适合的僵尸搭配通过！"
        Levels_ForBeginners(12) = "IZFALuF/yz09SEHLFBKKKeKhSO0NKgEoEsIYKpGCFVEfRDBXGUErGqdWIMKAEi\综合练习\俾斯麦の龙\2\最优解：0。用有限的僵尸攻破阵型！"
        Levels_ForBeginners(13) = "IZFABLH/yz0321fEWXKsSeEiAKDrBBBDGhcpBLdOVWRVBYgoFUGfANVqEAVCEgWM\综合练习2\俾斯麦の龙\2\最优解：25。综合IZ游戏最基本的技巧来通过本关。"
        Levels_ForBeginners(14) = "IZFAD6C/zRYcVVBGEEWEMEUBDKCBeSKchVrloBLEfENEOSiAAcPDscXFglpNq4E\杆星轮月\bLUErED_uNIVERSE\3\最优解：25。仅仅是小鬼和撑杆，也能造就无限可能。"
        Levels_ForBeginners(15) = "IZGACWE/yz9NrFAFEDjEOdtEMKiADDPNqcsBeKhBfGodgGXEFcNBpKBlYEZECILcUGVlKAW\三僵聚顶\阿仙\3\最优解：0。舞王如果处于啃食状态，就不会召唤伴舞。唯有用其他僵尸一起啃二路的坚果，才能让舞王尽快召唤，从而攻破一二三路。"
        Levels_ForBeginners(16) = "IZFADIE/z32HUBYdBlMeYDsqKHocXADeLleBLRrWVkEEOfNEglABiEflhFWFqFCBp4K\三位一体\耀天\3\标准解：0。一二两路互相保护，且对多路都造成威胁，如何应对杨桃和忧郁菇的夹击？注意实时阳光余量和部署顺序。"
        Levels_ForBeginners(17) = "IZFACWB/ROGBNrGAEsEYBuEURaRQVoBwRpKERPNtVMEWEVlNKiEvGhBZBCGDGqepGghfVfSXBKEeVLEjEF\百鬼夜行\阿仙\3\最优解：0。价值50的小鬼可以撑起半片天，尝试在图中只使用小鬼，通过这一关。"


        '1 雪线精选集

        Levels_Winkle(0) = "IZFAAyC/2VeIYKXBWBUVNDMcLKKKDICBBBAEVEsEOEEurIqcpdoEhffKgBi\经典时机\Winkle雪线\5\最优解：75。使用矿工，借助磁力菇跃迁到合适的地方。出土位置已经提示的很明显了！    起手提示：四路小鬼。"
        Levels_Winkle(1) = "IZFACWFyz014FANBIEBDACDhDsHiIUSeBYFXHWfVSMEoEKEgHqIpHrBOBfINIL\精打细算\Winkle雪线\4\标准解：50。二路和四路使用路障撑杆通过，其他路线可以使用多种方法通过。    提示：一路可选双铁桶，五路可选扶梯和撑杆。"
        Levels_Winkle(2) = "IZFACWD/21kOcNEXVVfWfeApRoNsNYNUNLDfdgBiIhHrSMIDDCEABEBKFqFB\三人成行\Winkle雪线\5\和三人小队一同攻破本关。只需要注意二路需要卡矿工在四列出土。    起手提示：四路矿工。"
        Levels_Winkle(3) = "IZFACWF/z214ENHWcYHVFAcDNfFEABVgBKNCVMBeHUEiBLBOIhHoFpIrcsHqFX\首尾三顾\Winkle雪线\4\矿工需要绕后，在前方选择合适的僵尸和他打配合吧。"
        Levels_Winkle(4) = "IZFACWE/021DYBpBsFVDBFKKAcXFhVNcMBrSOGoGecfcLVUVDHiBCVqfWEEXg\铁器枷锁\Winkle雪线\5\关卡的正中有一颗磁力菇。你需要借助它帮助僵尸前进的同时，不能让最上方的铁桶丢了帽子。    起手提示：五路小鬼后五路铁桶。"
        Levels_Winkle(5) = "IZFACWC/2BYcfRMEWEEEhNrfiVeVVfsfDfNBXfKILDBNUkCKAkOkpKgBoBq\磁铁迷阵\Winkle雪线\6\使用矿工越过上方磁力菇组成的迷阵。需要一只矿工用来引瓜，一只吃二路脑子，还要有一只越过一路的大蒜。    起手提示：五路小鬼后五路矿工。"
        Levels_Winkle(6) = "IZGAB9C/3lsNpuOlYBBVXVtNrNgBZNEloNKEeNhBANVGLlMRqNNGfkCVPEjlFBDGWVilU\怕风怯雨\Winkle雪线\7\最优解：25。这是新的怕风怯雨，依旧提供两种过法。你需要在胆小菇缩头的状态下，让小鬼穿过它们的防线。    起手提示：一路双小鬼后起三路小鬼。"
        Levels_Winkle(7) = "IZFACWC/yEAEDViEYEpEqErEsioBeBUBKBEVOVMEfVXVWGLINVCFBVhGVGg\同步效应\Winkle雪线\8\标准解：0，最优解：25。这是一场对于小鬼过双地刺的终极考验。把握好时机非常关键。    起手提示：一路双路障+小鬼引雷。"
        Levels_Winkle(8) = "IZHAAyC/2ejkFNfRBEMBpBPGiIoEUkDfNIWMecXVscCcVKEBtBafjfKROEkSLfAchkrVgVYcQBqBuEZBG\峰回路转\Winkle雪线\9\标准解：0。来看看你的终极控磁实力吧。本关提供多种过法，你需要让矿工穿过上方的磁力菇，并且想办法为最后三路的两个矿工找到合适的时机做出铺垫。下方可以使用五路反向矿工帮助破解四路，也可以直接尝试偷渡四路。"
        Levels_Winkle(9) = "IZHAH0Dz32HOlLSoSfeUeLeCeZGZErdkRiFjBABPBaBhBvKBcWcGlulgfqfDGESMGtGpDeDXDQVVVYlFKKKUcCcN4t4u4v|y46y77b26b69\水中捞月\Winkle雪线\10\最优解为0。这是一个综合了传送门性质、水中月以及蹦极偷的关卡。"

        '2 控磁

        Levels_Magnet(0) = "IZFAB9B2IKcXFVGWAOKYcCdsNABoGiBLRpWBiMVqRDFEfUIgkrlfBhVeSN\磁铁计时赛\Winkle雪线\4\欢迎参加""控磁大师锦标赛""！磁力菇冷却的短短15秒可以创造无限可能。本专题的关卡以控磁力菇为主，让磁力菇把僵尸在合适的时间吸引出来吧。"
        Levels_Magnet(1) = "IZIAB9B2fWRqlLSikriOFMcZGYBNcCAPdaBjRDlgBpIXWBVfVoKAFEdsWh\远距离跃迁\Winkle雪线\4\你已经掌握了诀窍，现在尝试在合适的时机把矿工放在第9列，并让它在指定位置出土！"
        Levels_Magnet(2) = "IZGAMgD/z2MqcDqCEBfWfVGAEKcOVFDEENciVhRtIeEMDPGpFofUcsVjBfEgfZfYfXeiNruL\一次性磁铁\Six_coins六币\5\三路有这么如此多的磁铁，要让小鬼一边吃，还要让剩余的磁力菇发挥它的作用。"
        Levels_Magnet(3) = "IZGAPoE/z32KVnUfMNefKEFGtdjkhBXGCfWMpFBlEiNlfkZFofgdrgilAWOSLcPkDHqqsMY\三磁同堂\谔虺\4\不得不说，当三个磁力菇同时把三个矿工吸出来的时候，确实帅啊。"
        Levels_Magnet(4) = "IZGAKKC21DZfNFAGYfUNgWPAiFXHBGCKDDEuFlLFqlolhWWMOcMcjctcsArKVfflplelK\多线并进\谔虺\4\阳光固定，每条路只能放一只僵尸！确定好磁力菇对应的矿工，然后一气呵成完成本关！"
        Levels_Magnet(5) = "IZGAEsDxz2cgqNKicEBZehBpEWVBleXFeWqhejerVVDAfKEqBtcjVLWCcDeDuPXsfODrVoeYVf4s4r\永动助战\Six_coins六币\4\如果矿工从三路被吸出来，当他啃食南瓜时就会一直触发忧郁菇的攻击。"
        Levels_Magnet(6) = "IZGAETI/yz03214VPDXBYloBClOIqIsSgdeKfcEVBGicrVtWNFMcKcLHWfVBUcZHAGFIjdDGhHp\底线冲刺\谔虺\6\矿工如果在第一列出土，后面的伤害由谁来承担？"
        Levels_Magnet(7) = "IZFACWDxy2HCcDVoKVWYAhrqEKIiFfHXBrceIWfNDOBUiBdLVEBsVMEpRgFA\有猫不先打猫尾草\贴吧妙姐\5\香蒲在一般的关卡中都是优先针对的对象，但是这一关你却不能这样做。"
        Levels_Magnet(8) = "IZFAEsE/z21oBHVXYEsliFocqKpBUcXWWAMlOlAcDWChMVgDhRfkrBeVEBNFKfL\一矿三吃\七袅_\7\一个控磁阵，五路矿工兼顾清行、引瓜、引磁，可谓一举三得。在合适时机放下小鬼，使窝瓜判定落在矿工身上。"
        Levels_Magnet(9) = "IZFADIDz23NqKpFelKVUHAIYfhcWeXHsNrWNuLeOVEVidXlDKV0OBgloBBBCMflM\镜中花 水中月\贴吧妙姐\6\原版的""水中月""利用土豆雷摧毁了蹦极僵尸，在这个关卡中，作者使用魅惑菇反向啃食蹦极，完成了这个目标。反向行走的僵尸犹如在镜中行走一般，为矿工的吸引创造了机会。"
        Levels_Magnet(10) = "IZFADIE/014uYeVfVEUGeEocqHWHfFiFpFXFMcLRKBOBEBCBsxrDBIhIgINIDIA\上下其手\Magic-魔音\6\你需要在磁力菇的帮助下用铁器僵尸通关本关。注意：扶梯无法把梯子放在爆炸坚果上。"
        Levels_Magnet(11) = "IZFAINF/yz29dXfWVYVVVNlLNrIpIgIfRhRUcsHONKIEIDRBcCHMHoHeFiFqFABZ\一石二鸟\七袅_\6\舞王放在三路，伴舞容易吃掉重要磁力，这个时候需要让窝瓜一石二鸟。"
        Levels_Magnet(12) = "IZGAGpF/z3210DHNFOFXspBiBqlscrctcZcjcWKMKfHh0YVEVFVPNANBNVNglKlofe0CcLDU\分毫不差\谔虺\6\利用矿工偷渡，配合其他多种僵尸过关。"
        Levels_Magnet(13) = "IZHALVC2/mhHiNBRQBGfVBtHXEKfrdDVWfgVNNAkFBUcYcaVuROBLcsIoRPEfEeDjXkcqIpVEBCWZHM\三连\桃花水母\7\这是一位才接触了IZ三天的新人制作的地图，对于下方三个磁铁，该如何分配好矿工呢？"
        Levels_Magnet(14) = "IZHAD6E/yz2VaBskpEqFGEZkDFkIBIfcXoOEiSARtfYuuVQnhlUeUcjIKDVsNBoBrNLNWEPKCfMEEehBFNeeYMg\地道战\Six_coins六币\7\控双磁力菇的挑战！想想办法，让矿工跨越这两颗磁力菇。对于二路，你可以尝试直接飞跃，也可以尝试使用一路反向矿工来实现。提供两种解法。"
        Levels_Magnet(15) = "IZGABLD/z2RXDDBBfKVYcqBIhoNOBheMeseXVIBLVIcVBfGFHgVZBrfeRjFshEKMGietHthFIAINFUGoKPGCWWejGEBp\似难则易 ◉\阿仙\6\最优解：525。1-9重叠向日葵与地刺。看似劝退的双磁，实则是没什么关联的！"
        Levels_Magnet(16) = "IZFADIE0214kWSUKffrfNfDfVfeFodMViVhDqDgDODEAABpBsBYBXBLBKBCBB\超级五磁\69岁老古介\7\这张图中有五个磁铁，最终的思路依旧是让矿工渡过磁铁。本关有多种解法。"
        Levels_Magnet(17) = "IZFABLF/z321hAeihAehdemKBghAhKDfEBermDVYhWBWEruFfVIXmomUqAuBcMFqeNlieUGsSNDCeKeqXOBpeoEjohBEmL\断头饭 ◉\七袅_\8\1-1忧郁菇下有三个花盆，1-2重叠地刺王与土豆雷。利用扶梯身位靠后的特性，在啃完坚果瞬间引三线打死扶梯，清除障碍并保留地雷，随后撑杆跳过地雷贴脸吃曾。"
        Levels_Magnet(18) = "IZHAJxE/yz2KUSPGrEDRhEsKoeDujukSfFeltHLcVGWBgDukQACiKVFfiDGecFOGXBcGqREhuRpEa\里应外合\The_Moon_丶\7\以卡矿为主，和其他僵尸配合通关。值得注意的是，二路大蒜不会导致无解。"
        Levels_Magnet(19) = "IZGACWE6014HLBtKhuWuYfBBjgqFKuVADfsgEuUfNRPBrMoACFAKiHeuXfgBfgMuZBFBOAp\坏事成叕\凉夜minusxX\8\最优解为0。古希腊掌管铁器的神。"
        Levels_Magnet(20) = "IZGANSD/21HVAWSXHghghfBfKBuZfpeONqNrKAqLqsrtgiVFVEdUlYfMfeVjXOEoepFhAKBDBCBNBP\入门的三磁阵\阿仙\9\真僵尸就玩控三磁，精确掌控出土时机！"
        Levels_Magnet(21) = "IZGAfQB2cAcYGOcjBCMXdLErffEuEWfDBpcKcoceAFfZIgIhBsRBcqEEHNBPEiRVFUdtEM\遇水叠桥\俾斯麦の龙\8\只用矿工通关的三磁阵。最优解竟然可剩1000多？"
        Levels_Magnet(22) = "IZHAHCC/2chEgNqfNfAnuEUBacZcXcKIMBPGkEefiVtkFcsBpBrBGkCVWKYNfVjcVcQBDELEOKEgBFo\磁约束\富贵王子Allen\9\最优解：75。一张综合控多磁地图，需要让三只矿工在三路的三个裂荚处出土。"
        Levels_Magnet(23) = "IZIAH0B2kskrDvDbDffKRYRNRPRFGCkGkDEgEZcRcOcXcjcqcpcecBekejeOeWeBBlBtBuBaBHBEBAfofWfi0h0MSUSkcVfQML\巅峰对决\风依\10\最优解：25。只利用矿工，在五个磁力菇的阵法中突破。找到合适的出土点。建议从一路开局。"
        Levels_Magnet(24) = "IZHALuC/2hVufhQfphqhMBG0PhGBGBGhGVHGKcASMBDkCBlkY0LBqIoBZciIoVvukDVcXcWGUhGfBfekrfNfEfaktEOBuKsdjepBhkFRQRg\六磁轮回 ◉\卍木游戏\10\最优解：1200。叠种：1-7有向日葵*3，花盆*3；5-1有小喷菇*2，矿工的灵活运用，小鬼的灵活机动，思维与操作的严丝合缝，如何配合才可穿越磁力菇的天罗地网，完成心中之梦。"

        '3 残局

        Levels_NotFull(0) = "IZGACWE/yz0KodiFeSgSOFNdMVUBABt\残缺的意志\烟楼-天青-鸣\1\本单元收录了一些残局。这是原""圣光普照""的改版，使用最基本的僵尸即可攻破。收录时有删改。"
        Levels_NotFull(1) = "IZHACWE/yz3oLWMBfkpqGcQeGeuRXkBVjBqVYEEVDRWquBU\启蒙\Six_coins六币\2\一个较为基础的残局，选择合适的僵尸通过吧。收录时有删改。"
        Levels_NotFull(2) = "IZHAB9Exyz3eiBoAqRaBssBBOlVHAXPeXHhesVMHicXSLEjBfktKU4s\隔空取物\师岩之怒\3\由新玩家制作的基础残局，难度不高。"
        Levels_NotFull(3) = "IZFAHCCz9cCRfNNfpBDlVdgKqDYWXViVhALFWEOHeGsFEfMSBDr\一杆星月 两袖清风\bLUErED_uNIVERSE\3\利用撑杆即可轻松破解的阵型。"
        Levels_NotFull(4) = "IZHACWF/yz39VaVUVXBFHfSOFKKBDhEoBYdqFtcjlABr\棘手二选一\烟楼-天青-鸣\3\残局""棘手二选一""的改版，保留了原版大部分的设计，有多种过法。收录时有删改。"
        Levels_NotFull(5) = "IZFAH0G/yz034BfBiqOVUHKFolVuBsefWBLrgerXruAApGDFN\直击要害\stocklover\3\优先摘除那个最致命的植物。"
        Levels_NotFull(6) = "IZGACWC/zuYVrugXfRUdVeVGMHKVLqABDVCEBBOBP\星星的复仇\Six_coins六币\4\利用星星的子弹阻止一路小鬼引雷，就可以让撑杆跳过去移除忧郁菇。"
        Levels_NotFull(7) = "IZFAD6Exz60KMFEcDelBldS0H0GcmGpHiSgFeSKBOBBRaEZEVEqErEsftfXfA4S4m\保持间距\bLUErED_uNIVERSE\4\排除磁力菇，利用门板抵挡寒冰的减速，并用铁桶僵尸为他承受伤害！"
        Levels_NotFull(8) = "IZFACvD/z9cDVMDWNUBfVhViVqNpBsVBVXEeKA\披荆斩棘\七袅_\6\最优解为50。小鬼卡双刺，小鬼啃坚果保舞王。"
        Levels_NotFull(9) = "IZGACvD/z0cjdBEgRoeNViBFeYDe0DmsBhRqEEVVufeBVtBPdYcZeedN4Y4N4B\繁星\Six_coins六币\5\利用高血量僵尸为小鬼挡住杨桃的子弹，要注意释放的顺序与时机。"
        Levels_NotFull(10) = "IZHAGQD/z3HOBrVqlUlhEghgFLdWcIVZFuEpBo0NStlFVk4u4F4I4L4O4W4t\瑕不掩瑜\bLUErED_uNIVERSE\6\最优解为0。需要利用小鬼与蹦极进行配合的残局，中间的杨桃自然有请蹦极上场。"
        Levels_NotFull(11) = "IZHAGQC/2cuBNBNlUhMulGMekdkGQubeaGpcaKDFKGRfOHoekuHRPuFEvcLBe4R4U\先发制人 ◉\bLUErED_uNIVERSE\8\2-4有两朵花，4-7套了两个南瓜头。矿工绕后想吃掉向日葵，就一定会吃掉磁力菇。怎么才能保住磁力呢？"
        Levels_NotFull(12) = "IZIABLE/031HXBQEf0hliDteYSMFAlLcFNjlEVCVeVuBUBrBvkqdNEafbfYfg\士卒星散 飞鲸吞钓\bLUErED_uNIVERSE\7\蹦极的超长手臂可以挡住杨桃的子弹，以此来帮助小鬼平安走过杨桃的攻击范围。"
        Levels_NotFull(13) = "IZHAD6C/3VbBoNCRguQdmNhBrBklWFYdNkDkpVeVHVF\天降神兵\七袅_\8\与上一张图类似，利用蹦极宽大判定范围，帮助小鬼挡住子弹。"
        Levels_NotFull(14) = "IZHAAyE/z29XaEKANVOGCGEFAqHf6EBRZfWBoBoBoupupupRqRrVsVfVgDhGiBjFUEVDY4o4h4W\速战速决 ◉\路过-h\10\叠种：5-1有向日葵*4，6-9有磁力菇。这是一个设计的十分精确的关卡。从关卡生成的那一刻就已经开始了！你必须及时按照作者设定的指定时机摆放僵尸，否则必将失败。提示：第九列四路小鬼，立即四路小鬼，立即第九列五路小鬼。"

        '4 奇妙冒险

        Levels_Adventure(0) = "IZGAB9D/z7lKBWNUNVDXEZlNELlYltqoqpqqlEIrNsqjIglMIiBhIfXOleNDVPBFBAEBqC\冰车漂移\NemoLittleG\5\本专题让我们来看看IZ中一些有意思的设计。本关最优解：75。雪橇车僵尸在一定时间内不受到伤害，就会突然进行加速。利用这个特性冲过四路和五路。    起手提示：二路撑杆。"
        Levels_Adventure(1) = "IZFAD6C/8BfNrBoNCNDEOXAGEXWGMGKENkBXhMiGUXsuVXLNqFXcYBeugVp4U\跃跃欲试\滑稽的小黄瓜\5\最优解为0。让跳跳僵尸为小鬼僵尸承受来自大嘴花的骚扰与豌豆子弹的攻击。收录时有删改。    起手提示：四路跳跳。"
        Levels_Adventure(2) = "IZGABLD/z2liuYlelBGOIAqtBsuXuWljluEKkrBNlVlUMqsfELIPBFVMELkpkglDlLsokEBCuZEh4P4B4r4q4O5L4D4L\大嘴和小鬼 ◉\小小少年100\4\预设解：275。2-2叠种双雷和伞。一路小鬼吃完大蒜到二路如果不处理就会踩雷并消梯，借助二路的大嘴，消灭这只小鬼吧。"
        Levels_Adventure(3) = "IZFACWC/zViBfVXcOIsVNHLIKRhFMRgDBgASpBeAUBWXEVDVCAoKVEqVYBr\杆王\某卡哇伊的屑新\5\结合小鬼与撑杆僵尸来过这一关，可没有你想象的那么简单！收录时有删改。"
        Levels_Adventure(4) = "IZGAQBC39KLeghUhZeZhqKDNVhVhpeheeKfKZhYhDNehXhAlXhNhChMhOeXqFBAhLeFNORihKeKeDhiKshsuthhGrBWNMlUGhEjhgBqeqlEeEeVhFqYhohfeoKohelNeMeOBpBBNKKCeBNghBhWeNEP4g4h4X4M4N4O4q4E\蘑菇园派对\Six_coins六币\6\最奢侈的一集，不要太在意舞王的存活。"
        Levels_Adventure(5) = "IZDADIC/zRAVBuCBKGLGMqUEVBWMeofEg0qVpVo4M4L\绝望三路\专吸硬币の茨利咕\5\虽然只有短短三列，本关却有很多有意思的特性和设计。摘除忧郁菇，协助撑杆和小鬼通过此关。"
        Levels_Adventure(6) = "IZFANSF23149dLdXeBIVdBcDlWDscEBqKpFolelKEAVidgFfeOSOcNKUVCHMfYeLAr\摘星\七袅_\6\4路单舞王会被星星打爆，因此后面跟上橄榄协助吃掉星星，顺带引磁。2路单矿必死，矿吃完伞后上蹦极偷掉星星，为矿工挡下伤害。如果南瓜头内植物消失，则南瓜上的梯子也会消失，1路用蹦极在合适时机偷掉杨桃，可以让扶梯卡在南瓜中间，引爆土豆雷。"
        Levels_Adventure(7) = "IZGAB9C/3eAeLeMltBjksBrVhVgVWVYVqVUlolVBeBfBpFAFLHMHBHCGKNX4o4V4M4L4A\童子军\Six_coins六币\6\结合蹦极僵尸与小鬼过双刺的关卡。难点在于一路寒冰射手的时机比较重要，它的最后一发必须打在蹦极身上才能保证小鬼顺利通过。"
        Levels_Adventure(8) = "IZFABLD/21SUBAlCFKcO0pcNVfWreEciVLWDVYBocVesDXfWFeKsKElq0BDhBgWM4E4s\东隅已逝 桑榆非晚\bLUErED_uNIVERSE\7\无论磁力菇先吸哪个梯子，本关卡都有可以通过的解法。"
        Levels_Adventure(9) = "IZEAGQC29cMfUcjBoefXDcjGufeGkusKKRhFCBieiKAGifwBfDXRBRLcjuEXNGacjuOcjcr4X\电光朝露 ◉\bLUErED_uNIVERSE\6\4-6叠种5个裂荚，4-5叠种大嘴花与向日葵。舞王僵尸350阳光说吃就吃。"
        Levels_Adventure(10) = "IZGACvC/3NVDMNDRBeMXZeMeMBPBOVLlURCNXNWlKGABEVFeZlYNNNoNoNeVjViNoDhNoNoVrBqBsKgBtNoNoNolpNf4M\神之一手 ◉\七袅_\7\叠种：2-3有南瓜头*3；5-1有8个胆小菇。蹦极偷伞，小鬼趁机前进。"
        Levels_Adventure(11) = "IZGAK8D/29ERRPSBGMBhIWcXeiHLFDGecSWrAqeYEEEfBjcAVtDZBwDFliejWYROeqRCcNEQSgVsuk\路见不平 拔刀相助\bLUErED_uNIVERSE\5\有的时候往往会因为太在意舞王的存活而犹豫不决，但有的时候直接支付350的舞王也是不错的选择。"
        Levels_Adventure(12) = "IZHAD6D/z1SOFFBQFEEeMjrahMhGejGCElGMHvMKctupShhFBihPhAVUuABgkZouHGEXurRqDNBPhpILckff\莫强求\俾斯麦の龙 & Winkle雪线\4\都说大蒜它很辣，今天我得尝尝它！用梯子向三路发起进攻吧，无论梯子向上还是向下，本关都有可以通过的解法！"
        Levels_Adventure(13) = "IZAAKjC/2eceplpWhGARDEieNDKDb0c0C0eheVUlSEBqoqqqrdtqvqwehuLuPWMWOeCcNcjejhZfYWZdR4o\星零逆轨\莫名其妙的梦林\6\最优解：0。脑子就在红线上，想吃到它还是有点困难的。如何利用磁力菇通关呢？"
        Levels_Adventure(14) = "IZFAB9BzKMViqChgEfEehKeMBsBgcUEeRYcq0rEfEWBVREhVhXBhBNBodtBDEeBpEfkAcOcXEK4p4o\鸢飞戾天 鱼跃于渊 ◉\bLUErED_uNIVERSE\5\叠种提示：4-1和4-2叠种3个土豆雷。一个只用撑杆的图，对于四路的重叠土豆雷，别忘记使用撑杆引雷特性！"
        Levels_Adventure(15) = "IZFACWE/z04isBrVqEplgBfDoIehedUdLDKlAqBhAhBEGBZRXDWeWuVuMmauNEYNhdidEdOFDEC4U\步步惊星\七袅_\6\用四五路的僵尸触发杨桃的攻击判定，让一路铁桶受到更多伤害，保证吃掉寒冰且不踩雷。"
        Levels_Adventure(16) = "IZFAfQD/29SKEhKeNEWDAiIpfWEXcqlBIMVgRfAodrKLGsDOBABVRVVCGNGYFU\四面楚歌 八仙过海 ◉\bLUErED_uNIVERSE\5\3-2叠种一个向日葵和一个窝瓜。"
        Levels_Adventure(17) = "IZGAFeJ/xyz02314BtlYcXeYuUEVFWuZFPEKIMBOoLBNVFFDHCBEGAcBAfHecjDiGgRhDrlpFsAqqoeo4Y\身先士卒\七袅_\7\前面的僵尸为后面僵尸开路，后面僵尸进而发挥作用。"
        Levels_Adventure(18) = "IZGAD6I/yz03214GNutcVcfHgBPlZeeFBcOcFBDHpleSLWslCBWooEXWhHYerFMliSjBEFUeheMBKoqepoAcr4i4C4e4Z\左顾右盼\Magic-魔音\8\一个有意思的单破合集，选择合适的僵尸帮助在后面的矿工消除威胁。收录时有删改。"
        Levels_Adventure(19) = "IZGACWE/z31eMqBVDBEcWMreWNfHVAPlFBAuicNBKAOojBoEgcXEClhHMlUEZBsrtlLBeqpVYEq5N5r5f5g5q5h5X5o5C5Z5W5O\犁庭扫穴\凉夜minusxX\7\如果一个阵法由钉耙组成，那就要用最省钱的方式将钉耙统统消耗掉。50阳光的小鬼僵尸可以消耗一个钉耙，75阳光的撑杆僵尸可以消耗两个钉耙，125阳光的蹦极僵尸可以消耗三个钉耙，但有些时候尸体也可以消耗掉钉耙。该如何抉择呢？“
        Levels_Adventure(20) = "IZGADIE/z21kFAqHeDfcXFpvHctksRjDhXiDPDODNDMDLgKgKgKnKnKRouWGUoCBDBBFAcEDgeXBrRVFYBZcX4f4P4e4h4K4L4M4N4O4g4s\追风行者 ◉\七袅_\7\最优解：75。叠种：2-1叠种3卷心菜2西瓜，3-4叠种双裂荚。梯子吃大蒜后搭梯，会导致其纵坐标偏移。这个特性很有意思。"
        Levels_Adventure(21) = "IZGAD5E/z32EOhNhfhshPDplAhLSLlMhMhWhAhhhKENBrVsEDhFsVKPhOhEDEhUhBEXhelYBqEhhiFCGiBKlohthohrDFGZhqhZcWcghjhXDpcfhYEjdBfeAUhVBt4i4Z4X4Y4A4P4O4B4j4C4s4h\一方有难 八方支援 ◉\bLUErED_uNIVERSE\7\5-2叠种两个坚果。这个关卡把场地都铺设在了花盆之上。五路的小鬼吃掉两个坚果的过程中会被上方杨桃攻击到，必须借助其他僵尸挡住伤害才能让小鬼存活。"
        Levels_Adventure(22) = "IZFAHbG/z2317BMHourBUGOGKuDEpAVeXRLEpGfVEcFhDhrcGeCGXfCGicglNBXeMeguqVrGpuEKNIeDAEYurAWeNBhlslBuq4Y4p364C\红衣军 ◉\七袅_\10\结合多种机制设计的极难关卡，主要考验各种僵尸之间的配合。初始磁力菇会吸走1-3，后3-5的梯子。1-5地刺和地刺王，5-4叠种盆中双地刺王和地刺，5-2叠种双土豆雷和大嘴花，3-4叠种大嘴花和向日葵，2-4叠种大喷菇与大嘴花。"
        Levels_Adventure(23) = "IZGACWF/z321MDFNeOcfSABeRMShDWDjereCBBHOBXBglUeENqfVlCSreFoKEpSFWsehEPWiKtloVYeLcLcZSEeK\似是而非\凉夜minusxX\8\最优解为0。三线射手的攻击范围大于索敌范围，不被打不等于打不到。"
        Levels_Adventure(24) = "IZGAF3C/4NE0NofHhHjHiBVoM0KGgcWBv0PorHtosqFejePDLeWueoYeNoZeCBXMokpeiNqehNUeMuBeO0OoCBAoDeg4p4L4M4N4O4E4D4C4j4P4g4h4i4W4q\前仆后继\某不知名の提拉米苏\9\你知道橄榄球的判定范围有多大吗？利用橄榄球的身位，协助小鬼通过本关。收录时有删改。"
        Levels_Adventure(25) = "IZGACWD/z7qZKFBDqfoEGNMicrRCeLEOcPqeBADjqtqYePuKupqsEMcLHWFVDXKqDgBBBoFUBh\难分轩轾\凉夜minusxX\10\最优解为0。虽然冰车很强，但是遇到地刺还是无力回天。你能用冰车卡小鬼地刺的间隔吗？"

        '5 高负载

        Levels_OutOfRange(0) = "IZHADhH/yz6031BolpVuVtBqFgKMfYliKjehEQSrEsVkEfEeBNsBEEXPHOKGBFeDKCVAXalLGDBVEUHXEZWhNWdK\你能铲了它吗\谔虺\2\这个专题都是种的满满的植物，并且往往带有重叠种植！让我们先从一个相对比较简单来入手吧，本关拥有多种解法。"
        Levels_OutOfRange(1) = "IZHACWG/z3157BMeABPWguanOXQBoqsqtuDlYBLaAoEEuBWlBeWBqeEsUajsFSKsVeXKhaZsioeBkeYVrRGHCeBetnXBpekrNofej\闪击战\师岩之怒\3\一位新人玩家的投稿！冰车可以碾压棘手的植物，但是不能碰到地刺。气球可以直接飞过高输出的阵型。利用各种僵尸的相互配合及掩护来通关。"
        Levels_OutOfRange(2) = "IZIACWE/z2+NeofesEOhlBPKFBNeUAXMVvgRRctGGoZfMBoWifbFYBWVLhHWaBvulkpqQMuEscrEUEkFDoCuqEjREuHVKGARB\轮番上阵\Six_coins六币\5\巨人僵尸不会受到套在南瓜头里的土豆雷的伤害。游玩本关前要记得要让玉米炮取消冷却！"
        Levels_OutOfRange(3) = "IZHAMgE/z21XqGjIUGklVsPlZMASfcpePBEEXlYIFXNXWEieAVGGglalBoMDheQ0DhZVuhqEofOeqhrVKGrSLhaGsBQFCutde\秩序\The_Moon_丶\7\使用矿工移除三线射手后要为三路小鬼的前进留出充足时间！才能让最后矿工提前小鬼引雷。    起手提示：四路撑杆+四路梯子后二路矿工绕后，四路矿工卡4-2。"
        Levels_OutOfRange(4) = "IZHAQBD014hthkhquAhEhBVphsGLhQHCIGpvoahLAhhNhXhChVHiHkhfhvhihhhGTNWDpRAEpthDArFODBAfhFhohaeXVYoQIMpqVYAVhrhRpsfXpF\盆中恶煞\俾斯麦の龙\6\看起来种在陆地上的水草即使放在盆里也没什么用呢，本关水草纯属威慑作用，更棘手的应该是中间的磁力吧！"
        Levels_OutOfRange(5) = "IZHAMHD/02lEebIKfhVVFAEURXDPSpcqGrcgeKBsStGYVNBN0flbcGSOsaepAolZehoiEHXkRuKeRjcQepDDIBlF4K\诱敌自乱 ◉\The_Moon_丶\9\(叠种：2-4有向日葵、地刺；5-2有南瓜头*2) 综合利用矿工进行设计的一关。矿工需要尽快解决5-2的两个南瓜头。    起手提示：二路铁桶后三路矿工，五路矿工绕后，另起五路矿工卡5-3。"
        Levels_OutOfRange(6) = "IZBAGQE/z24qvdwcF0IlsGSuKSjGMewGLBQGDeFfecffunGuBcrupejnYeellGOeMHWlHGCWbGcFZlUerWiBEGgSPuVXouXuacmGtcReQcNGAukFhBq4N4r4I4D\一线之隔\谔虺\5\离胜利只有一格之差了！在后方如此庞大的阵型中解决障碍，保护前侧的僵尸。"
        Levels_OutOfRange(7) = "IZHAKKF/0214KEcCcFcGcNlLlMXKKUGWGXGgBhSfVeloWpFq0rctGkGufYEZDaBQKDKBRVRASPVOSj\逃过一劫\The_Moon_丶\8\想办法延长磁力菇的吸取间隔，为中间的小鬼僵尸争取更多时间吃掉坚果！最后用矿工突破三路。    起手提示：五路矿工后四路矿工绕后，接1-2矿工。"
        Levels_OutOfRange(8) = "IZIAfQDy39KrkslpoDWFWhIfceFgIOBLIKGNFUGPVMBWGaqRrlVkIXBYqidQlbIjcZnBVClAEEEGdqBHBtduIvoVBo\一战封神\谔虺\6\舞王僵尸想在如此复杂的阵型中起舞，必须为他铺好前进的道路。"
        Levels_OutOfRange(9) = "IZIACWK/yz03214+9NYNENWFKFpFeSbSjIvItIaIDIUdkdhdLdRdGHiHqHABlBuBrBgBXBNBHBPBFKMKBKZKoqfEVECfQqOEs\火力压制\玩摄影的Frame\6\植物阵容具有十分强大的输出能力，僵尸要如何突围？"
        Levels_OutOfRange(10) = "IZGAH0Eyz23SD0jcERf0RKeXa0jBAcFlBeFhqlgGLspEYFClGlXGqIVEkktuicW0jDhSoeRhKSUuKBPEOrZdslQBrDufMetKN4j4Q4G\添酒回灯重开宴 ◉\bLUErED_uNIVERSE\8\一张较为经典的矿工卡磁图。这关矿工要出土的点位应该提示的比较明显。"
        Levels_OutOfRange(11) = "IZHAMHG/yz032ePeoeDIUBWWqGDfqDaoODteCdGefBPVFIVXQGfdG0s0hKpfZVblFHecgVocksKlMDBdLdGuW0i0ueguNRCEY\时间裂隙 ◉\The_Moon_丶\8\5-3叠种火炬与地刺，3-3叠种地刺王与花，1-6叠种地刺和伞。"
        Levels_OutOfRange(12) = "IZHAK8D/z2FAEZRWGCGYsgVrcMVHVvEoEoVHVHEoBDEKcqVuXjsBFeRkePRQfVVfRFEDREVNGXkEBhGGKLKpVtIUDalPSisORs4G4s\重复工作 ◉\The_Moon_丶\8\(叠种：1-4有向日葵、土豆雷；1-5有大蒜、窝瓜；1-8有地刺*3；5-1有土豆雷*3) 啃食可以增加磁力菇的吸引范围，利用这个特性为三路小鬼争取更多的时间。    起手提示：一路矿工引土豆雷后一路和四路矿工绕后。"
        Levels_OutOfRange(13) = "IZHAH0E/021GKRv0qfXeAGZRMGYSgRqFsXolpKhctRkXjefsecNGrlLFDIWeFFUGacVBtBtBfhe0FIAVucGWBeWFOWi4A\白驹过隙 ◉\The_Moon_丶\8\矿工配合其他铁器的综合地图。5-3叠种反向双发和窝瓜，5-6叠种裂荚与两颗向日葵。"
        Levels_OutOfRange(14) = "IZIAF3D/z2egRVeeHDEPDueoVHuheRNWGEFOhb0ZlRoADGkvKQBlBw0beGGtEa0qSN0pdgcMleGYGsfU0mBfVjGFGXebeoEiVSKoGrkCVk\附骥名彰 芦中托渡\bLUErED_uNIVERSE\9\这张超大的地图中，主要思想依旧是矿工法。小鬼在三路吃南瓜头并及时踩雷，帮助最后一只矿工在三路出土。经典思路了。"
        Levels_OutOfRange(15) = "IZHANrF/z231BrGDeFkBDvfieWBaRadMFXeKEeloKZlAeoENsKVHcgEeeF0seDuEVjGLXhVHeiIU0bBWFPVHRGEuIqEuGVDvKpGO0YFfeqEuXQuklFGt4D4B4v\稍纵即逝 ◉\The_Moon_丶\10\(叠种：1-6有南瓜头*2；1-8有地刺*3；3-7有向日葵、窝瓜；4-1有土豆雷*2；5-7有土豆雷*3；5-8有坚果墙*2) 结合多种技巧带来的终极挑战！    起手提示：一路矿工后偷2-1。"
        Levels_OutOfRange(16) = "IZHAMgD/02csDaBlepEXlherWkqiBjeAlNfeKoREfYBF0CVKluFDRMcbWrstEKHfXqEVVUcODKlgKZIADHFL0pRX4A\四渡赤水 ◉\The_Moon_丶\9\2-1叠种土豆雷地刺与坚果。"
        Levels_OutOfRange(17) = "IZIAEsDx02WhDwRgNAGoNABpDwXMXMBuXMEVHhGahwhwRmhwRcENnsBiBaGQVEEBVFKgXpXpcIfPXYnjsXGbVDEZfeBXNAvkhwhwBBWHEtGqfrKLGZDwVCBp\三顾茅庐 ◉\俾斯麦の龙\10\最优解：0，1-1叠种三胆小，1-2雷和花，2-3三个高坚果，3-4冰瓜和向日葵，3-6大嘴花和土豆雷，3-7大嘴花与向日葵，4-3窝瓜和大喷菇，4-4双发与火炬，5-2双向日葵与双高坚果，5-9三个坚果墙与五个花盆。"
        Levels_OutOfRange(18) = "IZHAXDC29GpuFcOuMeKcsfZEXSocOeoRuuGcYBfRieLWPePuHcOeO0UEXGDeOuGlKuHureuDeeg0hhUuQeUeA0NctDqDAWLukuVRgfWuHcEGDGahieeuhubujuGuFea\哀舞王之须臾 羡矿工之无穷 ◉\bLUErED_uNIVERSE\10\4-4叠种一个反向双发和一个地刺王，3-4叠种两个土豆地雷，1-4叠种两个大嘴花，2-5叠种三个裂荚射手和两个南瓜头，1-6叠种两个地刺王，1-7和1-8均叠种三个地刺王。用舞王支付打开突破口后，再用矿工偷渡残局。"

        '6 保护传送门

        Levels_Portal(0) = "IZFACWH/yz0314RQlWFOKNGYNXNVNUNMILehchdgIsBiBrBqioHpFfnegKXEWDBCKBAA|y78y25b22b37\传送门\富贵王子Allen\2\首先我们先对传送门的性质做一个基本的认知。在本关卡，你将认识到哪些子弹可以穿过传送门，而哪些不能。"
        Levels_Portal(1) = "IZFACWFyz039NrfANBFOBCBNeEcKqEsDkXkYGURVMMELKWneDfdpgoDsBqBiBhlg|y78y23b113b25\轮回之镜\半城烟槿半城殇\2\另一个白门的位置在4-10，放入其中的僵尸将再无出头之日，但撑杆可以跳过传送门。"
        Levels_Portal(2) = "IZGAAyB/GEBLVZkpkFNWeZErNXVANUVgVtNYGoECNVVNBi|y3y26b45b66\回转寿司\Winkle雪线\3\最优解：0。一个很有意思的小短图，中间的南瓜可是要啃很久的，怎样才能让胆小菇一直缩头呢？"
        Levels_Portal(3) = "IZFAFFE/z37oekoBCEAoBqEqheCXODYVpeheEBXoLoNFDuMlKIWFVoUBiusXqdrBgAf4K|y47y33b26b36\空间隧道\Six_coins六币\4\传送门入门阵！利用冰车和传送门破开看似牢不可破的防御！"
        Levels_Portal(4) = "IZFACWD/z9cXIAEMcsBNDOEEFfEDKgFUcpBBVWVLBCKrRoEVvHSYEiKKEqIeVh4s4e4A4O4N4X4U4K4B|y117y117b26b99\过河拆桥\Winkle雪线\5\最优解为0。过河拆桥在本关有两个意义，一是利用玉米炮炸掉梯子，二是最后伴舞通过传送门啃掉玉米炮。绝妙之处在于故意留出一路的土豆雷将在最后再次利用。"
        Levels_Portal(5) = "IZEACWC/zWKRgdWRVFN0LlhleEohqBqBfBMspVrVXVDDUDCNBGA4h4W4N|y36y25b34b23\小步流星\贴吧妙姐\5\标准解为0。这个中间的杨桃看起来十分棘手，不过借助这两个无限循环的传送门，可以在其中放入两只撑杆僵尸，帮助一路和五路抵挡子弹。不过四路需要动动脑筋……"
        Levels_Portal(6) = "IZFACvE/z62BfkhGCBOrYRWqLEDDNNXNEGiFgefBfEsRrHqApKofeKUuVVMVBIKIA|y13y48b34b48\貌合神离  ◉\贴吧妙姐\7\(叠种：4-2有向日葵*2) 当两个传送门重叠在一起的时候，这行的植物攻击判定就会发生改变。你需要引导植物攻击二路的铁门，尽可能的延缓坚果被吃掉的时间。"
        Levels_Portal(7) = "IZFACWD/z5rKKENpNYNXNBBCBhBrGsGfGAlUDODieqBqDogDVgqVIeEWENuMkL4K|y15y77b88b4\双缝干涉\贴吧妙姐\6\标准解为0。香蒲会优先锁定来自空中的气球僵尸，如果气球在两个传送门之间疯狂穿梭，地面的僵尸就可以安然无恙地前进。"
        Levels_Portal(8) = "IZIAMgD/2zhhufVXlCuKhguMuNfEGHhNuLeseEIBVYEPugGbEmlDtshfueIpVZktkFGOhehKlrVWlqGiuhGVGIEShMhLGcGwGvEjlUlU4b4U4V4v4H|y2y113b114b110\镜像对称 ◉\滑稽的小黄瓜\8\这张有趣的地图上下对称（应该算吧），但是上下的解法不同，很有意思。3-1有两个保护伞。"
        Levels_Portal(9) = "IZHAFeF/z231ejljXXBAuVeYcWVuFFlURGBeELcMekkqHOErshVEEBRDRCoKNfRoKYeKBZBaFNFQHPnsftXkqgRpEi4q|y70y26b48b15\轮回\Six_coins六币\8\最优解为0。当传送门均在同一路时，利用僵尸特性巧妙破阵吧！"
        Levels_Portal(10) = "IZHABkE/z32BFBflAEaEpfhWYuiHXHNEuEkACWjBtHgDGHrWscQBMBKGOVZHLhaAoAeAWWEXVVqHDEBWPAU|y25y33b35b47\假痴不癫\Six_coins六币\8\最优解为0。正在挖地的矿工和左行矿工受传送门影响，而已经穿过传送门后自然出土的右行矿工则不受影响。"
        Levels_Portal(11) = "IZGACWC/3NUBtDfqplLSBDZDrNEcOBFljDDNWNeNMlPNANYNqMCBsNgBiNXchGocNNVNK|y23y48b25b44\帘外烟撩\凉夜minusxX\7\最优解为0。虽然传送偷最终不会偷走保护伞，但是他降落的位置实打实地可以吓走胆小菇。利用这一点让小鬼僵尸前进。"
        Levels_Portal(12) = "IZGACWE/z54oUeNWjBEBXeBeEqgoiRsBPEKMAfffeAtoYejRMGWeiehHNaLBFaBchDpHrBOMVBZEDcqgCao|y24y44b14b44\鬼蜮伎俩\凉夜minusxX\9\最优解为0。利用重叠传送门判定紊乱的特性，持续勾引仙人掌造成无效输出。让地面的僵尸有机会消耗南瓜头。"
        Levels_Portal(13) = "IZGACWE/yz5HtEKBerFHUaZHYNoAXBfnOBNRPXjDEasaBiLngNpbAAVRinhNqarHDHWHMHC|y3y89b34b58\永世沉沦\凉夜minusxX\6\最优解为0。请注意本关开局后在1-1有一只三叶草，请抓住时机在2路放气球！"
        Levels_Portal(14) = "IZGACWC/9ENBDDMMPBsnhcfRUABBrHCktefHZnjMpAYBXEFegDegOkoNKngehsLAWejKVWEEqniEAei4t|y100y23b4b113\犯罪高手\凉夜minusxX\9\最优解为0。舞王处于后撤步状态时啃食魅惑僵尸会导致其反方向移动一段距离。"
        Levels_Portal(15) = "IZHACWE/z37esEueAlFBAeZnEoZBpGooNMVejofeilsRCoPoqiBeYBjlLuDGOogMeequaeBukBMGhsYePXGlUsiegRWBKutuQBrBXeN|y13y47b22b48\宙外来客\凉夜minusxX\9\最优解为0。面对如此猛烈的火力， 似乎只能使用冰车了。"
        Levels_Portal(16) = "IZGAMgD/23VpDLlqDtnrlUnEcVEZfWFXEDeEDYlsXjghifcgAeciVolOINBCNBNAHFAMRPSK|y100y23b37b57\迷惘之瞬\富贵王子Allen\10\最优解为150。结合水中月，卡矿工，以及小鬼技巧的一张综合关卡。"
        Levels_Portal(17) = "IZHACWE/z32orHNXWEaHUukEsngoZcecVBiBPcpshlKHDnBMYBMloNteEehlAeGeQejfGeOEXcLBjBCHEeUuufqlQcfnOBF|y47y33b70b35\镜花水月\凉夜minusxX\10\最优解为0。镜中花蹦极取物，水中月矿工偷渡。"
        Levels_Portal(18) = "IZHAI/F/2314NMNODPEqNLBkNNlAnFcEVCRYIafrerFeEKluKhcilfAWVQBgRDBtcVlUcXDBFsXGeoHoNjcpGZ4k4u|y58y33b57b26\金属脉搏\富贵王子Allen\10\最优解为50，在有传送门的地图中精确控制铁器吸取的顺序。"



        '7 比赛用图

        Levels_Competition(0) = "IZHACWE/z02BusNIffqVoeKhUeeegGXVpBAcY0aBkMORERDceNMeVcsBGdVhfGhNWkFXjGXctIBlUGrFZFQdCGiMPRgfK\散财杯一图三\俾斯麦の龙\7\2023年散财杯指定地图三，本关卡最优解：50"
        Levels_Competition(1) = "IZFAImDz61SKKCBrMVroBOKBMMfWMsMfBgDhMASqKYBEKUFeDDMiFXFpKNFL\散财杯一图四\晨风\4\本关卡最优解：300"
        Levels_Competition(2) = "IZFAfQFx678+DDVgiKlLFMGrGBSfIoIOIhcsWqBpAeRAICfVVXdWEYKUINIiIE\散财杯一图九\俾斯麦の龙\4\本关卡最优解：1300"
        Levels_Competition(3) = "IZFAJxF/0314VBReEKfVIOIXIrcEIhdfGpVDKLWCAWFADqigBNIiIMlsSUIYGo\电梯杯一图六点五\俾斯麦の龙\10\本关卡最优解：0"
        Levels_Competition(4) = "IZFAPoJ/yz032149IDcCSBlMWhcYHWfVVXVgVUBEBOBNBLBiBfBeisiriqcpFoFKFA\智商杯六图一 (IZE)\namelessness\控制\2023年植物大战僵尸吧第六届智商杯，选自常规赛区的十个阵型。原帖链接p/8224989200。本关卡最优解：1700"
        Levels_Competition(5) = "IZFAfQJ/yz032149lYfWEXGiWsFpieSgBhBqIrIoIfIVIUGODNKMBDVEVCcBRLdKAA\智商杯六图二 (IZE)\namelessness\综合\本关卡最优解：1825"
        Levels_Competition(6) = "IZFAfQJ/yz032149RiBhSfKeErIqcpFoGsfYGXWWlVVgVUiMAKdBDEIOINIDICILIA\智商杯六图三 (IZE)\namelessness\综合\本关卡最优解：1400"
        Levels_Competition(7) = "IZFAfQJ/yz032149VoVqiYiXisIrBiBhBpBfIelVcUSKVMFgFWFLfNIOIEWDcCcBHA\智商杯六图四 (IZE)\namelessness\控制\本关卡最优解：2025"
        Levels_Competition(8) = "IZFAfQJ/yz032149BfBiBhBXBCKrKgRsRYGDGVGKRLKMKBVOVNVpIqIoIeEEEWEUEA\智商杯六图五 (IZE)\namelessness\即死\本关卡最优解：2275"
        Levels_Competition(9) = "IZFAfQJ/yz032149VrVNDMdLABfDGEGqSocYFXEWiVlfRgWiKhBsBpBeBUBCBAIOIK\智商杯六图六 (IZE)\namelessness\综合\本关卡最优解：2525"
        Levels_Competition(10) = "IZFAfQJ/yz032149fEiBWCDYEhVgVVGfGOKiBslrRqdoIpIeIUIXIMINIDSWcLFKAA\智商杯六图七 (IZE)\namelessness\综合\本关卡最优解：1450"
        Levels_Competition(11) = "IZFAfQJ/yz032149DCEEiDlLRNciWsdqSpKoIeIMFfAUGVGOVYVXfgBrBhBWBKBBBA\智商杯六图八 (IZE)\namelessness\综合\本关卡最优解：2450"
        Levels_Competition(12) = "IZFAfQJ/yz032149IiIhIfIpIoKeKgKNKMKXKWKVKUKKBsfrfqfYfEfDfCfBfABOBL\智商杯六图九 (IZE)\namelessness\穿刺\本关卡最优解：1950"
        Levels_Competition(13) = "IZFAfQJ/yz032149IsIqIgIfIoGeEpVrVhBiBYGXdWlVFUDOBNSMfLKKREcDWCiBAA\智商杯六图十 (IZE)\namelessness\综合\本关卡最优解：1675"


        '8 珍珑收藏

        Levels_IZECollections(0) = "IZFAfQJ/yz032149WClMVWSUfKifirVsVqBoBXBNBDIYIhIgIpFeFOFLcVcicEHBiA\暗度陈仓 (IZE)\czmppppp\控制\历史上铁器矿工流之首发，开创性地将铁器偷渡技巧纳入矿工法范畴，故为暗度陈仓。    本关卡最优解：2125"
        Levels_IZECollections(1) = "IZFAfQJ/yz032149ENIOGXIYRVfWdUGiIhifcgSeKsBrIqFoVpVMlLBKBEWDDCIBAA\白驹过隙 (IZE)\旷野狼歌\综合\本关卡最优解：1875"
        Levels_IZECollections(2) = "IZFAfQJ/yz032149AoKeVYVfGqGhcXSWROiAFBfUWrdsIpIiIgEEDCIDILlKBVBNBM\斑羚飞渡 (IZE)\fjk0619\综合\本合集中收录了大部分来自2022年的珍珑关卡。特别感谢The_Moon_丶与Six_coins六币协助整理。本关卡最优解：1900"
        Levels_IZECollections(3) = "IZFAfQJ/yz032149ReifGoGgWschDXdOFKKLSMlVEUVYVEfDACIAIWIiIrIpBqBNBB\杯水车薪 (IZE)\模仿者魔仿者模音\综合\本关卡最优解：1850"
        Levels_IZECollections(4) = "IZFAfQJ/yz032149ipAoceffRidrWqIsIhIgGOEYlVSWIMKDGCFADNBXBLBKBUVEVB\笨嘴拙舌 (IZE)\namelessness & 虹玫万奈\综合\本关卡最优解：2075"
        Levels_IZECollections(5) = "IZFAfQJ/yz032149FfFBchcicEcDHCHgHeHAFsFqFrFpFoFVFKINBOBYBXIWBMBLBU\比翼双飞 (IZE)\Nickwmc\输出\本关卡最优解：2325"
        Levels_IZECollections(6) = "IZFAfQJ/yz032149IsIrIEINIVIUBXBpKoKqKMKWKiKhKgKfKefYfOfDfCfLfKfAfB\鞭长莫及 (IZE)\路过-h\穿刺\本关卡最优解：1825"
        Levels_IZECollections(7) = "IZFAfQJ/yz032149HqcrcpIeHfHWcVcXIMHNBoBhBgBUBLBKFsFiFYFOFEFDFCFBFA\冰山一角 (IZE)\sweetcandysweet\输出\本关卡最优解：2525"
        Levels_IZECollections(8) = "IZFAPoJ/yz032149iiGhEplfSeKUWMALcKFAGBdCRODEfXIWVsVrBoBVBqBgBYBNBD\不落窠臼 (IZE)\初末3141\综合\本关卡最优解：1600"
        Levels_IZECollections(9) = "IZFAfQJ/yz032149KURKiocpWslfGWGeVqfXSVDiBgIrIYIhILVMdNBOIEEDACFBBA\步步为营 (IZE)\namelessness & 虹玫万奈\综合\本关卡最优解：1825"
        Levels_IZECollections(10) = "IZFAfQJ/yz032149loBpiVKUVhVfDiRYfWFLSKENWDcCIAIOIEIMIXIqIgAeGsGrdB\惨绝人寰 (IZE)\The_Moon_丶\综合\本关卡最优解：1400"
        Levels_IZECollections(11) = "IZFAfQJ/yz032149IgIhIXIDILIMICBVBUBiBYBOBENNNWNfNeNsNrNqNpNoNBNKNA\趁火打劫 (IZE)\namelessness\回复\胆小主题舞王运用的优秀一例，待伴舞恐吓边路胆小时伺机下小鬼，故为趁火打劫。    本关卡最优解：2725"
        Levels_IZECollections(12) = "IZFAfQJ/yz032149KKiLIMIARDlCWNAeVoDiErGqGhIsIgIfIpBEBBSOFYcXVWfVdU\趁人之危 (IZE)\老骥扶梯\综合\本关卡最优解：1675"
        Levels_IZECollections(13) = "IZFAfQJ/yz032149lASBEEBDBCVMdNDOcLKKiUAVGYGXfeWgVhBiBWBfBoRsFrIqIp\趁虚而入 (IZE)\Crescebdo\综合\本关卡最优解：2500"
        Levels_IZECollections(14) = "IZFAfQJ/yz032149RMdEIOIDlVfWEfIiFhGsGeKoSqcpWrDgiAABVCVLBYBNBXBUBK\诪张变眩 (IZE)\初末3141\综合\本关卡最优解：2325"
        Levels_IZECollections(15) = "IZFAfQJ/yz032149fgEpVoVfAsFiiWcVKUlBWDdCRLSMGOGKDNIXIYIEBABhBrBqBe\从容就义 (IZE)\初末3141\综合\本关卡最优解：2300"
        Levels_IZECollections(16) = "IZFAfQJ/yz032149BDSLIBIKlCVEWOfNEMFWAVRUVgKeGocpirGsDiBYBXBhBqBfdA\打草惊蛇 (IZE)\鲜血水晶杯\综合\借刀杀人之非公开时间线姊妹图，四路铁桶作饵引诱杨桃攻击路障，故为打草惊蛇。    本关卡最优解：2500"
        Levels_IZECollections(17) = "IZFAfQJ/yz032149DEIDWCABSAVOVNcMiLfKKfFedgGYGXIhRrEsBiBpBoBUlVIWIq\大胆穿心 (IZE)\旷野狼歌\综合\本关卡最优解：2050"
        Levels_IZECollections(18) = "IZFAfQJ/yz032149AefqShdgKfFVEURKlLiEWDVXVMDWcoIpIsIYICGrGiBOBNBBBA\大智若愚 (IZE)\Crescebdo\综合\本关卡最优解：2100"
        Levels_IZECollections(19) = "IZFAfQJ/yz032149loWhcgAeIqFpIKRAdEVOiWKVSXfYVUBBIDDCBiBsBrBfENGMGL\灯下黑 (IZE)\Crescebdo\综合\本关卡最优解：2200"
        Levels_IZECollections(20) = "IZFAfQJ/yz032149lpWqDrFsEfRiIgGhfWAVIXIUSKILBMdEiDGCcBKABoBeBYVOVN\电光石火 (IZE)\凉拌菜梗 & 大迪克笔帝\综合\本关卡最优解：2100"
        Levels_IZECollections(21) = "IZFAfQJ/yz032149GsDrWqKpViVhGfAeiYSXdVlUEOfLBoBgBWBKcDFCIEINIMIBRA\调虎离山 (IZE)\风花镜月 & BrainVSzombies & zhoukaipx & 鲜血水晶杯\综合\三路撑杆啃掉威胁最大的杨桃后，再上四路舞王自杀破四、五两路，另有一路后置下梯，令其减速后鬼引窝瓜，故为调虎离山。    本关卡最优解：2100"
        Levels_IZECollections(22) = "IZFAfQJ/yz032149iCKBVDEEcYVXWslfFgRrfUdMIOIqIpILAKSAGiGNBhBVBoBeDW\东壁余光 (IZE)\七袅_\综合\本关卡最优解：2100"
        Levels_IZECollections(23) = "IZFAfQJ/yz032149AeGflodqisRiIrIgIYcXVhVWfVFUELKKWOGESCIDIBDNBpBMBA\断头餐 (IZE)\Crescebdo\综合\本关卡最优解：1900"
        Levels_IZECollections(24) = "IZFAfQJ/yz032149GUlVKoIpdqWsVYSXIgcfAeEhBrBiBWRLiMFKDNBOVEGDICIBfA\发蒙解缚 (IZE)\大迪克笔帝\综合\本关卡最优解：2175"
        Levels_IZECollections(25) = "IZFAfQJ/yz032149fUlVEYGfigcidhKeSoWsIrIqIpIXIWILAKFNDMGARDVEVCBOBB\伐竹取道 (IZE)\某不知名の提拉米苏\综合\本关卡最优解：1625"
        Levels_IZECollections(26) = "IZFAfQJ/yz032149WDlBiiipioFeFNcMcgcfHLSKFVfUBOBXBCIsIrIEIWIAVYVhVq\反哺 (IZE)\雨中的鱼子酱\控制\本关卡最优解：1800"
        Levels_IZECollections(27) = "IZFAfQJ/yz032149VplWKVWEiDACGYDXchSfFedrIsIqfOEKRLGMVNBiBgBoBUBBBA\反间计 (IZE)\大迪克笔帝 & Crescendo\综合\精确卡大嘴花消化时间，使二路舞王召唤时大嘴刚好消化，从而同时引发窝瓜大嘴，诱敌自乱，故为反间计。    本关卡最优解：2500"
        Levels_IZECollections(28) = "IZFAfQJ/yz032149RoEefVFfSUigVWDXGiGYdsArIhIqBpKKIAlLVEcOINWDBMBCBB\反客为主 (IZE)\初末3141\综合\一路路障置于九列，引发速度重置使其进入优势相位，骗地刺首扎扎空，故为反客为主。    本关卡最优解：2100"
        Levels_IZECollections(29) = "IZFAfQJ/yz032149ipfodsShBgBecVDWIYIiIrIqIfGXGUKKEEWDRLlAIBACFMVNVO\返璞归真 (IZE)\模仿者魔仿者模音\综合\本关卡最优解：1725"
        Levels_IZECollections(30) = "IZFCcGJ/yz032149lYDiGsWqAoieSfFVfUdKcOGNVgVMIpIrIhIXIWEAKBRDBEBLBC\飞来横祸 (IZE)\Magic-魔音\综合\满局。本关卡最优解：9865"
        Levels_IZECollections(31) = "IZFAfQJ/yz032149IMINIOVDVEVYBABCRLRqRiEXEWEgEhKKKUKfKsGeGpGrIVBBIo\风驰电掣 (IZE)\凉拌菜梗\即死\本关卡最优解：1850"
        Levels_IZECollections(32) = "IZFCb3J/yz032149IsVfVefUFKRLABlAIWKVdYEXiEGDIOINIMSocpWgGiDhBrBqBC\否极泰来 (IZE)\Umbrella_leaf\综合\满局。本关卡最优解：9925"
        Levels_IZECollections(33) = "IZFAfQJ/yz032149iiKgDrcqFpGhGfdeVWlVBoBsBYBXBUfOBNWMALSKVERCEBIDIA\釜底抽薪 (IZE)\namelessness & 耄耋鱼鱼 & 梦境是刹那的永恒\综合\巧借矿工啃食底线时受五列磁铁吸引，未啃食时不被吸引之特性，构造精确偷渡矿工妙手，故为釜底抽薪。    本关卡最优解：2375"
        Levels_IZECollections(34) = "IZFAfQJ/yz032149KoVsRqAVigFflpcUBrSefidYDWGhGXEAIMILIKWCVDBEBOBNBB\隔岸观火 (IZE)\The_Moon_丶\综合\五路连下两矿，由反向矿为正向矿抵挡三线子弹，并引走窝瓜保其平安，故为隔岸观火。    本关卡最优解：2275"
        Levels_IZECollections(35) = "IZFAfQJ/yz032149cqirApfgWXdVIfEsIBSNKMFLRKlDVWVCGiGYBhBEBoBeBUBADO\故技重施 (IZE)\s3t_ & sweetcandysweet & 麦兜RADA\综合\本关卡最优解：2525"
        Levels_IZECollections(36) = "IZFAfQJ/yz032149iAABcCWDDEfKILIWIOIYIsBpBrGqViVoKeEfFgRhdUSVGXBMlN\关门捉贼 (IZE)\fjk0619 & namelessness\综合\四路矿起后，为啃掉冰豆并重置栈位，适时下撑杆引窝瓜以一砸二，故为关门捉贼。    本关卡最优解：1900"
        Levels_IZECollections(37) = "IZFAfQJ/yz032149RWBgGrGqGeIpIoBUBKBsRORYBVIXViVhVfENEEEDEAKCKMKLKB\海不厌深 (IZE)\The_Moon_丶\即死\本关卡最优解：2250"
        Levels_IZECollections(38) = "IZFAfQJ/yz032149IrIqIsIiIhKoKpKgKfKeKUKYKEKDBCBBBAfXfWfVfOfNfMfLfK\海阔天空 (IZE)\sweetcandysweet\穿刺\本关卡最优解：2025"
        Levels_IZECollections(39) = "IZFAJxJ/yz032149RXfYdVKUleEfDgisSqcpFoGiGhALWEBOIrINIWIMIKIBIAVDVC\鸿门宴 (IZE)\模仿者魔仿者模音\综合\残局。本关卡最优解：0"
        Levels_IZECollections(40) = "IZFAfQJ/yz032149lpfgRfAeKrFqDYIUGVGWiAICWMcLSKIOINEEViVhdsBoBXBDBB\后庭花 (IZE)\namelessness & 虹玫万奈\综合\本关卡最优解：2025"
        Levels_IZECollections(41) = "IZFAfQJ/yz032149loffFgAAdBcMROiEDDENIiIhICILIKBeGpSqBsBrGVKUWWVYVX\厚积薄发 (IZE)\虹玫万奈 & 大迪克笔帝\综合\本关卡最优解：1825"
        Levels_IZECollections(42) = "IZFAfQJ/yz032149cLFKiBKAdCGDWEDORNfMSUleAfVpViGhEsIXIrIgIVBoBqBYBW\狐假虎威 (IZE)\Crescebdo\综合\本关卡最优解：2125"
        Levels_IZECollections(43) = "IZFAfQJ/yz032149lERsdXWiVhVBECcNFMKLGYGODWiUSgAefoIrIqIfIVBpBDBKBA\环环相扣 (IZE)\七袅_\综合\本关卡最优解：2075"
        Levels_IZECollections(44) = "IZFAfQJ/yz032149BrBoKpIqIsIYIDICIAfBfEfOfWfifhfgfffeKXKVKUKNKMKLKK\缓兵之计 (IZE)\Magic-魔音\穿刺\本关卡最优解：1750"
        Levels_IZECollections(45) = "IZFAfQJ/yz032149AAGBECDDGOVNcMSKleFVfUKfRrWhiXViIYIsIgIpdqBoBWBLBE\回笼觉 (IZE)\Magic-魔音\综合\本关卡最优解：2150"
        Levels_IZECollections(46) = "IZFAfQJ/yz032149RsiolpIqIrIichWgIfSeKUBWfVGYGXDOENIKALFBIEIDdCVMVA\混水摸鱼 (IZE)\初末3141\综合\二路矿护一路扶梯偷渡，接五路矿护四路橄榄精确偷渡，故为混水摸鱼。    本关卡最优解：1375"
        Levels_IZECollections(47) = "IZFAfQJ/yz032149BqIYIEIOINIrIpIofsfifhfgfffefUfAKXKWKVKKKLKMKDKCKB\继往开来 (IZE)\初末3141\穿刺\本关卡最优解：1575"
        Levels_IZECollections(48) = "IZFAfQJ/yz032149FeSoRsWrEfVhVWlVfUKKiLdMANDXcYIEGDICIOGiIgBqBpBBBA\假痴不癫 (IZE)\初末3141 & namelessness\综合\三路铁桶在杨桃攻击下强打坚果看似亏损，实为五路撑杆挡刀，故为假痴不癫。    本关卡最优解：2050"
        Levels_IZECollections(49) = "IZFAfQJ/yz032149dslrGqEpVoiiRgcfFeDWKVSUVOGNWMBKfLIhIYIXIEIDICIBAA\假道伐虢 (IZE)\namelessness\综合\二路矿工无法看杨桃相位，铁桶又不被吸附，需出七列后置铁桶之妙招，故为假道伐虢。    本关卡最优解：1500"
        Levels_IZECollections(50) = "IZFAETJ/yz032149fUlVKWiedgRfEqShWMAKcCFAGXGLVsVYDrBoBpIiIEINIOIDIB\见缝插针 (IZE)\s3t_\综合\残局。本关卡最优解：0"
        Levels_IZECollections(51) = "IZFAfQJ/yz032149GAGKILIDIEIOIYBoDqBsRrEpAechSgKfWilBdCFMVWVNfXiVIU\结草衔环 (IZE)\凉拌菜梗\综合\本关卡最优解：1575"
        Levels_IZECollections(52) = "IZFAfQJ/yz032149REcNAVifKelpWsdrfgIqIhFoGiDYVOVWEXSLGMBDBKIUICIBIA\结缨伏剑 (IZE)\The_Moon_丶\综合\本关卡最优解：1625"
        Levels_IZECollections(53) = "IZFAfQJ/yz032149RfKeDgGhEiGOSEiAdLfKWWcVAUFsVrVNBqlpIoIYIXIMIDICIB\借刀杀人 (IZE)\111111和1 & sqrt_7\综合\以二路矿工引磁入局，配以五路九列铁桶之妙手，引诱杨桃杀死矿工保住磁铁，故为借刀杀人。    本关卡最优解：1450"
        Levels_IZECollections(54) = "IZFAfQJ/yz032149lAEMWDREGYiWGVfUdLVpVfFeDhciAXIOINKKSCBBBoBsBrBqBg\借尸还魂 (IZE)\梦境是刹那的永恒\综合\四路正向矿食脑后，观察裂荚相位下鬼杀之，以四路鬼尸体抵挡杨桃子弹使五路鬼通过，故为借尸还魂。    本关卡最优解：2575"
        Levels_IZECollections(55) = "IZFAfQJ/yz032149IsGrEqKpGoVhVglfReWXDWcVSUiOBiBLBKfEFDIYINIMICABdA\金蝉脱壳 (IZE)\鲜血水晶杯\综合\三路矿杀三线保四路舞王，并引发裂荚双发bug击杀上伴舞避免卡位，使舞王脱险，故为金蝉脱壳。亦有三扶梯为坚果搭梯解救舞王之另解。    本关卡最优解：1825"
        Levels_IZECollections(56) = "IZFAEsJ/yz032149WqKrcpAolidhIgFfiNEKRCSBIYIEIDIAVXVODWGeGVfUBsBMBL\进本退末 (IZE)\初末3141\综合\本关卡最优解：100"
        Levels_IZECollections(57) = "IZFAPoJ/yz032149WYiVAUlfRpGrGXfWFOKKSsdqcoDgVhVMECIDBEBNBiBeBLBBBA\近水楼台 (IZE)\雨中的鱼子酱\综合\本关卡最优解：1725"
        Levels_IZECollections(58) = "IZFAfQJ/yz032149EEiBIAGDGCINlXFWfVKUWgcfAedhIiRsIrDqVpVMSLBKBYBOBo\精准之舞 (IZE)\旷野狼歌\综合\本关卡最优解：2050"
        Levels_IZECollections(59) = "IZFAfQJ/yz032149BsBiBOBEBVBUIYIhIgIpINIMIBNrNqNoNeNfNXNWNDNCNLNKNA\空城计 (IZE)\sweetcandysweet\回复\为延长二、四路胆小被恐吓时间，三路撑杆吃通后需再下一撑杆巡查空城，故为空城计。    本关卡最优解：2750"
        Levels_IZECollections(60) = "IZFAfQJ/yz032149SpieKocDEBFCGOGLfVdWDXRYliWhVgVNIsIrIqIfAABEBMBUBK\苦肉计 (IZE)\namelessness\综合\反向利用""僵尸不受伤害时啃食加速""特性，引诱杨桃攻击三路矿工，使其受伤后啃食变慢，保住磁铁，故为苦肉计。    本关卡最优解：2025"
        Levels_IZECollections(61) = "IZFAfQJ/yz032149BDWhVClVfOSKVUBWBiBgBfIsIYIXVqiripioHMcEcNcBFeFLFA\李代桃僵 (IZE)\鲜血水晶杯 & Crescendo\控制\三路原本障杆皆可破，但为拖延磁铁掩护一路扶梯，需以矿工代替之，故为李代桃僵。    本关卡最优解：2225"
        Levels_IZECollections(62) = "IZFAfQJ/yz032149RLiKWEDDBCIBIAEoVNVgcsArdqKplWFVSMBYIiIhIXIffUGeGO\里应外合 (IZE)\初末3141\综合\本关卡最优解：1600"
        Levels_IZECollections(63) = "IZFAfQJ/yz032149frHWSVlLcpcqcMiNFgFUFKWCIEIDBOBoBeBfBBBAVsVXVYiiih\力挽狂澜 (IZE)\大迪克笔帝 & 模仿者魔仿者模音\控制\本关卡最优解：2500"
        Levels_IZECollections(64) = "IZFAfQJ/yz032149DEfMdWRsWhlfipcoSUVOVNIYIDICILGqGeFiEgAKKVBrBXBBBA\连环计 (IZE)\sqrt_7 & Crescendo\综合\偷磁入局后，四路连下双鬼秒杀冰豆，并依照实际情况判断何时下第三鬼，故为连环计。    本关卡最优解：2075"
        Levels_IZECollections(65) = "IZFAfQJ/yz032149IfIeINIDIBBCBUBifsfrfpfgfhfYfOfAKqKoKEKXKWKVKMKLKK\凌波微步 (IZE)\Crescebdo\穿刺\本关卡最优解：1900"
        Levels_IZECollections(66) = "IZFAfQJ/yz032149ILVDVMWhBqBOBEBCHsFoFNFBcicrVfIpIgIeiYiXcWfViUSKlA\瞒天过海 (IZE)\鲜血水晶杯\控制\本合集内容整理自植物大战僵尸吧""【IZE】阵道三十六卷""，原帖链接p/8241036716。关卡介绍文案由Crescendo编写。精准掌控磁铁判定顺序，除三路矿工外，于其余四路同时偷渡四个铁器，故为瞒天过海。    本关卡最优解：2025"
        Levels_IZECollections(67) = "IZFAfQJ/yz032149WhROirFgApVoVNGsGidecVfUSKKAEBlCDDIXIWBqBfBYBEBMBL\帽子戏法 (IZE)\初末3141\综合\本关卡最优解：2500"
        Levels_IZECollections(68) = "IZFAfQJ/yz032149BpBqBgBKIiIYIXINfofefWfEfDfCfBfAKsKrKhKfKUKVKOKMKL\梅花三弄 (IZE)\雨中的鱼子酱\穿刺\本关卡最优解：2250"
        Levels_IZECollections(69) = "IZFAfQJ/yz032149WsVoGgGpKfSeEUfVlWcYFNAMdBiEVDDCRLBKBhBXBOIiIrIqIA\美人计 (IZE)\Crescendo\综合\巧用矿工出土时不受磁铁吸附之特性，使得一路矿被吸附而四路矿正常出土。据传，矿工美貌可迷惑磁铁，故为美人计。    本关卡最优解：2075"
        Levels_IZECollections(70) = "IZFAfQJ/yz032149RLFKKUGqfgiWdVEDVCVBchArWYDsGiSXlNBpBoBeIfIEIOIMIA\妙手偶得 (IZE)\路过-h\综合\本关卡最优解：1875"
        Levels_IZECollections(71) = "IZFAfQJ/yz032149fXWNVYVOFUigAfKeGhRpSVGqDsErcMdElBIoILBiBWBDBCBKBA\南柯一梦 (IZE)\Magic-魔音\综合\本关卡最优解：2250"
        Levels_IZECollections(72) = "IZFAfQJ/yz032149dpAeIoIfWgihGrVqRYSXfWcVFUEKKLlMDNVEGCIDIOIsBiBBBA\内外勾结 (IZE)\初末3141\综合\本关卡最优解：1800"
        Levels_IZECollections(73) = "IZFAfQJ/yz032149lLKKDMcBFAIDINIUfVEYVXVWisRrGqdiGoSfAeWgBpBhBOBEBC\鸟尽弓藏 (IZE)\namelessness & 初末3141\综合\本关卡最优解：2150"
        Levels_IZECollections(74) = "IZFAfQJ/yz032149dBfDVEViWXRhlgSfAKDOKWFoipcqIsIrIUICBABYBVBeEMGNGL\弩下逃箭 (IZE)\大迪克笔帝\综合\本关卡最优解：2025"
        Levels_IZECollections(75) = "IZFAETJ/yz032149KedoFpcqErVsWiAYlXDhfViBRCSAVDGEGNIOIgIWIUILBMBfBK\藕断丝连 (IZE)\老骥扶梯\综合\残局。本关卡最优解：100"
        Levels_IZECollections(76) = "IZFACWJ/yz032149EARCRBRfVqErEXEDVMVNGOKsKYKEKeGpGgBoBiBhBWBVBUBLBK\抛砖引玉 (IZE)\耄耋鱼鱼\即死\开局。一、五路均通过后置撑杆观察大喷相位，再伺机下鬼杀之，故为抛砖引玉。    本关卡最优解：1125"
        Levels_IZECollections(77) = "IZFAfQJ/yz032149WEHDSClBfVIqIABNBMBoBpBfBKVhVeVLiOiXiUFrFgFWcscicY\齐头并进 (IZE)\初末3141\控制\本关卡最优解：2575"
        Levels_IZECollections(78) = "IZFAfQJ/yz032149REVOVNDDlCEMieAfcVKUWhSgdrfoIsIiIYIWBXBqBpBLFAGKGB\弃车保帅 (IZE)\耄耋鱼鱼\综合\本关卡最优解：2125"
        Levels_IZECollections(79) = "IZFAfQJ/yz032149KASBWsfCBDdEiKcLEMDNGOIUIVIWFXGYBeBfVglhViAoIpRqBr\千里之堤 (IZE)\某不知名の提拉米苏\综合\本关卡最优解：1975"
        Levels_IZECollections(80) = "IZFAfQJ/yz032149BDSKfLHNiiihifcgcOcEVClBBsWrBqBpVoBYVUIXIWIVFeFMFA\前瞻后顾 (IZE)\旷野狼歌\控制\本关卡最优解：2325"
        Levels_IZECollections(81) = "IZFAfQJ/yz032149AASBWCEDDEVOVNlYfXFWiqcpKoRUdVIMIsIrIgBiBhBfBeGLGK\擒贼擒王 (IZE)\某不知名の提拉米苏 & The_Moon_丶 & 瑜悦悦\综合\神作。三路矿开后，二路下舞王自杀，召唤之伴舞亦全部自杀后破局，故为擒贼擒王。    本关卡最优解：1925"
        Levels_IZECollections(82) = "IZFAfQJ/yz032149RsWhViGoAfEeIrSqfUVViYIXcAKBICdDDEIOlNFMGgBpBWBLBK\清君侧 (IZE)\namelessness\综合\本关卡最优解：2075"
        Levels_IZECollections(83) = "IZFAfQJ/yz032149GilhKfiLfUBVDWFXSeIAIBIKIDIOIYIgGCVEAocpWqdrEsVMRN\情同手足 (IZE)\老骥扶梯\综合\本关卡最优解：1475"
        Levels_IZECollections(84) = "IZFAfQJ/yz032149BsBrBeIYIiIqIpIMKOKNKXKhKgKfKUKVKLfofWfKfEfDfCfBfA\三阳开泰 (IZE)\The_Moon_丶\穿刺\本关卡最优解：1925"
        Levels_IZECollections(85) = "IZFAfQJ/yz032149AoDqdriiGhGXfVKURfIpIeIgIWSNELWMlCVDVOcYFBBsBEBKBA\上屋抽梯 (IZE)\鲜血水晶杯\综合\五路扶梯食脑后，借用其留下来的搭梯坚果拖延磁铁，供一路铁桶偷渡，故为上屋抽梯。    本关卡最优解：2100"
        Levels_IZECollections(86) = "IZFAfQJ/yz032149IeAoipSqVrBsDiEhGgGffVKUdKVLRBlAFNWEcDIOIYIXIWBMBC\舍近求远 (IZE)\s3t_\综合\本关卡最优解：1825"
        Levels_IZECollections(87) = "IZFAfQJ/yz032149lCWXVVBWIEIBfKHUSDcNioiOiYcMcpVrVqIsIiIhIgIfFeFLFA\声东击西 (IZE)\鲜血水晶杯 & Crescendo\控制\看似四路扶梯引磁，实则以舞王攻破下三路，且二路同样先以矿工啃食冰豆，再下撑杆偷袭，故为声东击西。    本关卡最优解：1375"
        Levels_IZECollections(88) = "IZFAfQJ/yz032149KoRplqErDsdLiVcfSeFhfYGXGOVgVMWCAAIiIWIUIKIEINBDBB\绳锯木断 (IZE)\凉拌菜梗\综合\本关卡最优解：1575"
        Levels_IZECollections(89) = "IZFAPoJ/yz032149EoFpfWIfKeShRicsDrGViLdKlAWCADGOVNVMBqBgBEBYBXBUBB\势在必行 (IZE)\初末3141\综合\本关卡最优解：1700"
        Levels_IZECollections(90) = "IZFAfQJ/yz032149lpceAfWgViVhdOENfYFXSWKVRUIqBoiEBCBAIDIMIBIKGLGsDr\殊途同归 (IZE)\凉拌菜梗 & Crescebdo\综合\本关卡最优解：1825"
        Levels_IZECollections(91) = "IZFAfQJ/yz032149lMisAeWgchDiIrIqBpBoBUSNdXVYVOfWIfIVILFKGEGDECKBRA\树上开花 (IZE)\鲜血水晶杯\综合\于二、三路同下两个舞王互为掩护，舞王双开花破上四路，故为树上开花。    本关卡最优解：1825"
        Levels_IZECollections(92) = "IZFAfQJ/yz032149BYBXIrIsIiIOIWIVKoKpKhKgKfKeKCKLKAfqfNfEfDfMfUfKfB\双飞燕 (IZE)\namelessness\穿刺\本关卡最优解：1675"
        Levels_IZECollections(93) = "IZFAfQJ/yz032149BpBqBsBYIUIVIOIEfofefffgfhfifXfWKrKKKLKMKNKDKCKBKA\双鬼拍门 (IZE)\sweetcandysweet\穿刺\本关卡最优解：2200"
        Levels_IZECollections(94) = "IZFAfQJ/yz032149iecgSfWrIsIqIpIoGiGhVMROINILIKBAlBdDKCDEVYfWEXFUAV\水中月 (IZE)\namelessness\综合\本关卡最优解：1400"
        Levels_IZECollections(95) = "IZFAPoJ/yz032149cVfWVUVYVXWEIDiCFBSABslripioFqcichFfHeBgBOBNBMBLBK\顺手牵羊 (IZE)\鲜血水晶杯 & namelessness\控制\面对四路高火力，于适当时机下蹦极偷花，为正向矿挡子弹并回收阳光，故为顺手牵羊。    本关卡最优解：1650"
        Levels_IZECollections(96) = "IZFAfQJ/yz032149KeVsWhGgRflVAUSWcYDXFKdOVNGMfEiDEBIAICIrIqIpBiBoBL\顺水推舟 (IZE)\凉拌菜梗\综合\本关卡最优解：1875"
        Levels_IZECollections(97) = "IZFAfQJ/yz032149EsSqlpAoiKFeRfKVfUdgGhciVYVrWODNGDIEIXICIMILBWBBBA\死得其所 (IZE)\模仿者魔仿者模音\综合\本关卡最优解：1900"
        Levels_IZECollections(98) = "IZFAfQJ/yz032149EoIsIhIUVeVVVMRORNRKGiGfGBEEEDEXBYBrBqBpBgKWKCKLKA\昙花一现 (IZE)\Crescebdo\即死\本关卡最优解：2200"
        Levels_IZECollections(99) = "IZFABkJ/yz032149AecYSWFVBoBUdpDqEsVrGXGfKKiMfLWERDBBlAIiIhIgIOINVC\逃之夭夭 (IZE)\The_Moon_丶\综合\残局。本关卡最优解：50"
        Levels_IZECollections(100) = "IZFAfQJ/yz032149ViVYRsWrdgieABlAFUfVSWEEGOGKcMKLDNBoBpBDBCIXIhIqIf\天降正义 (IZE)\模仿者魔仿者模音\综合\本关卡最优解：2100"
        Levels_IZECollections(101) = "IZFAfQJ/yz032149IKIBIMSCGDWEVOVhGYdXAWfUDgFoiqcsErKfReINIiBABVBplL\铁索连环 (IZE)\凉拌菜梗\综合\本关卡最优解：1850"
        Levels_IZECollections(102) = "IZFAfQJ/yz032149WgfWcMVqVCRBiKlUKVAfSedoFpGOGNEsDhBrBiBYBXBAILIEID\同甘共苦 (IZE)\旷野狼歌\综合\本关卡最优解：2275"
        Levels_IZECollections(103) = "IZFAfQJ/yz032149dEENVOGDWMICILRBiAIXFWKVfUGeVhciDglsAqIpSfBoBrBYBK\同心断金 (IZE)\初末3141\综合\本关卡最优解：2100"
        Levels_IZECollections(104) = "IZFAfQJ/yz032149BABLBDGEGYSWBoiVFUAecfEgBpBqlrVsVKfiDhIXIOdMWNKBRC\偷梁换柱 (IZE)\GRACEFUL小神\综合\五路小鬼杀伞后，下蹦极偷四列坚果，巧用其巨大判定范围挡三列杨桃，故为偷梁换柱。    本关卡最优解：2500"
        Levels_IZECollections(105) = "IZFAfQJ/yz032149dsdidgdVdMdNdOdEBqBpBhBDBKIrIeILVYVXVWVoVfVUVCVBVA\围魏救赵 (IZE)\Crescendo\倾斜\倾斜主题罕见的双线齐攻，以二、四路铁桶围困三路杨桃，保护边路路障，故为围魏救赵。    本关卡最优解：2525"
        Levels_IZECollections(106) = "IZFAfQJ/yz032149lVFLSKAARBKedoifIpIUIgWiGsGrVqVDDMcOfYEXBhBEBWBNBC\无独有偶 (IZE)\初末3141\综合\本关卡最优解：2150"
        Levels_IZECollections(107) = "IZFABkJ/yz032149WWSVKUcgFfiefiEsGqBoBpBrBhDOGNlMRCdEABIYIXILIDVKVA\无中生有 (IZE)\111111和1 & sqrt_7\综合\残局。惟有五路引雷后于七列后置下鬼，方可利用小鬼步伐不均一多啃二十五阳光破局，故为无中生有。    本关卡最优解：75"
        Levels_IZECollections(108) = "IZFAfQJ/yz032149DqiiFsWNlLEMSXGUGVcWdYVgfoIrROVDcBICKABEBhBpBfBeBK\向死而生 (IZE)\路过-h\综合\本关卡最优解：2625"
        Levels_IZECollections(109) = "IZFAfQJ/yz032149lADOWEdDcCEMfLFKiYAhRsBpBgIiIqIoVrVVBXBWBUGfGeKBSN\笑里藏刀 (IZE)\namelessness\综合\四路控栈后，两个低栈撑杆可使二路土豆判定偏移，造就蹦极偷土豆之奇景，故为笑里藏刀。    本关卡最优解：2225"
        Levels_IZECollections(110) = "IZFAfQJ/yz032149fofpfqfrfsfifOfEKhKgKfKeKKKLKCKBKAIDINIMIWIVBYBXBU\心旷神怡 (IZE)\Nickwmc\穿刺\本关卡最优解：1950"
        Levels_IZECollections(111) = "IZFAfQJ/yz032149dLdAdBdYdWdgdsdrIKIVIMBEBDBqBUBoVpVeVfViVhVXVOVNVC\星离月会 (IZE)\sweetcandysweet\倾斜\本关卡最优解：2450"
        Levels_IZECollections(112) = "IZFAfQJ/yz032149WsVrEqdpBociGhSgIfFeRUVVDWlXiOINfMGLKKADBYBEBCBBBA\形同虚设 (IZE)\模仿者魔仿者模音\综合\本关卡最优解：2525"
        Levels_IZECollections(113) = "IZFAfQJ/yz032149SWAAWDiBGEDOEXcCfUleRiFgBhBfBVVYVMdLKKGsIrIqINIpIo\幸灾乐祸 (IZE)\fjk0619 & The_Moon_丶\综合\本关卡最优解：1925"
        Levels_IZECollections(114) = "IZFAPoJ/yz032149crAqEiIhKgGYDXFWRVGUWMlKiEdDSCVLVBfABOBNBsBoBpBfBe\羊入虎口 (IZE)\The_Moon_丶\综合\本关卡最优解：1825"
        Levels_IZECollections(115) = "IZFAfQJ/yz032149AASBWCEDDEVOVNlYfXFWiqcpKoRUdVIMIsIrIgBiBhBfBeGLGK\一笔勾销 (IZE)\某不知名の提拉米苏 & The_Moon_丶 & 瑜悦悦\综合\本关卡最优解：1925"
        Levels_IZECollections(116) = "IZFAfQJ/yz032149SoRpWrGsiilgfVEYGNcMALFKdDDEKBBCBOBhBfBeIqIUIAVXVW\一别两宽 (IZE)\namelessness\综合\本关卡最优解：2200"
        Levels_IZECollections(117) = "IZFAfQJ/yz032149dhROBNiXSWWgfUEClLKKcMAeVoViBsBfBqIrIpIVIDDEGYGBFA\一箭双雕 (IZE)\初末3141\综合\本关卡最优解：2025"
        Levels_IZECollections(118) = "IZFAfQJ/yz032149RXWhVYVNfLFMifloceApKASKIDICIiBOBqDsErGgGEdWIVBUBB\以退为进 (IZE)\麦兜RADA\综合\本关卡最优解：2050"
        Levels_IZECollections(119) = "IZFAPoJ/yz032149KKBLBWBNBoBpBqBrdsGgGiIhSfEelUfMDOVYVXAVWEiDcCRBFA\以逸待劳 (IZE)\Snow-Pea & namelessness\综合\通过二路舞王控制三路舞王相位，触发发愣bug，使前伴舞原地不动阻挡三线子弹，故为以逸待劳。    本关卡最优解：1625"
        Levels_IZECollections(120) = "IZFAfQJ/yz032149KUVMiNFKfYEilfRoVqdsDrIXIhIgIVGOGpBeBWBLBEWDcCABSA\以蚓投鱼 (IZE)\初末3141\综合\本关卡最优解：2050"
        Levels_IZECollections(121) = "IZFAfQJ/yz032149WhEORLKKiWfVFUSecfdgBoBpAqIrIsIiIYIXIMVEVCDDGNGBlA\引蛇出洞 (IZE)\The_Moon_丶\综合\本关卡最优解：1675"
        Levels_IZECollections(122) = "IZFAfQJ/yz032149DidhlXKVfUWMcKFDSNIEILIfIWieIsVrVqEpRoABBYBOBCGgGA\引针拾芥 (IZE)\初末3141\综合\本关卡最优解：1825"
        Levels_IZECollections(123) = "IZFAfQJ/yz032149IEIDICIsIiIYBeBgKWKXKhKrKqKpKfKVKBfOfNfMfLfofUfKfA\迎客来 (IZE)\初末3141\穿刺\本关卡最优解：1850"
        Levels_IZECollections(124) = "IZFAfQJ/yz032149IsFqBrBpSofhEglfIeWXcYAWiVdUBMGLGKViVOINIEIDDCRAKB\欲擒故纵 (IZE)\flaxcaster\综合\IZE复兴第一图，""万恶之源""。以四路后置路障入局，杀磁铁而保土豆，以便后续撑杆吃伞，故为欲擒故纵。    本关卡最优解：1825"
        Levels_IZECollections(125) = "IZFAfQJ/yz032149DDcESNWMFLfXGYGWiVdUAhEqRoVpVelfKgIrICBsBiBOBBBKBA\远交近攻 (IZE)\鲜血水晶杯 & Crescendo\综合\近处矿工法直攻挡杨桃，远处铁桶兵分三路同时偷渡，故为远交近攻。    本关卡最优解：2475"
        Levels_IZECollections(126) = "IZFAfQJ/yz032149GNGERLdKVMVDWYKWFUfVSgifAeDiEscrlpBoBqBhBXBCIOIBIA\越俎代庖 (IZE)\namelessness\综合\本关卡最优解：2225"
        Levels_IZECollections(127) = "IZFAfQJ/yz032149GYGVGMVhKBVOVNEEEWELECRXRgRfIrKqKpKoBsBiBeBKIDIUIA\直木先伐 (IZE)\某不知名の提拉米苏\即死\本关卡最优解：2100"
        Levels_IZECollections(128) = "IZFAfQJ/yz032149cqSpiodhfelVVNVMALRKDDWCKBGiGEEYIOIsIrIXIgIfFWBUBA\指桑骂槐 (IZE)\Magic-魔音\综合\为使一路伴舞免受三路伴舞拖累，二路梯引窝瓜强杀舞王，故为指桑骂槐。    本关卡最优解：1650"
        Levels_IZECollections(129) = "IZFAfQJ/yz032149fAfBfCfDfEfNfOfgBLBiBrBoIKIMKUKVKWIYIXKhKqKsKpKeKf\珠槃玉敦 (IZE)\sweetcandysweet\穿刺\本关卡最优解：2175"
        Levels_IZECollections(130) = "IZFAfQJ/yz032149fAFBDMSNIDdCWEIOiKcLKVGWGgAfEeBUBoBplXIYBhBrRsVqVi\壮志未酬 (IZE)\Six_coins六币\综合\本关卡最优解：2275"
        Levels_IZECollections(131) = "IZFAfQJ/yz032149IDIEIpIsBNBWBhBUlVVfVgFeGXGiRCcBKoiASKALWMdOfYEqDr\走为上 (IZE)\namelessness & 旷野狼歌\综合\橄榄啃一列或食脑时受五列磁铁吸附，非啃食状态则不被吸附，藉此间隙使其逃离磁铁，故为走为上。    本关卡最优解：1900"
        Levels_IZECollections(132) = "IZFAfQJ/yz032149fWKYKXKgKfKVKUKLKKKCIOINIBfEfDfsfrfqfpfoBiBhBeBMBA\左支右捂 (IZE)\sweetcandysweet\穿刺\本关卡最优解：2375"
        Levels_IZECollections(133) = "IZFAfQJ/yz032149dgBoEeBpBrFCfLGWGVAfBsBEIDBOVNDhIBWYRMVAiUSXlqciKK\作壁上观 (IZE)\米苏 & 瑜悦悦\综合\本关卡最优解：2475"
        Levels_IZECollections(134) = "IZFACWJ/yz032149BeBoBpRUEWKMDNGOlESfcVVXVYiDFgWhGiAqdrfsBABBBCBKBL\付之一炬 (IZE)\The_Moon_ & Magic-魔音\综合\栈位。    本关卡最优解：1100"
        Levels_IZECollections(135) = "IZFAfQJ/yz032149iDWCROSNfMEfKeGiDhlgVYVXGWFUcVABdABoBpBEIsIrIqILIK\插翅难飞 (IZE)\bLUErED_uNIVERSE & Magic-魔音 & 七袅_\综合\本关卡最优解：1800"
        '我的关卡
        For MyLevelNull = 0 To 99
            MyLevelCollection(MyLevelNull) = "\\\\"
        Next

#End Region

        '选项卡首选项，文本首状态
        ZomCard.SelectedIndex = 0
        ZombieType.SelectedIndex = 0
        PWAX.SelectedIndex = 3
        PWAY.SelectedIndex = 9
        PWBX.SelectedIndex = 4
        PWBY.SelectedIndex = 2
        PBAX.SelectedIndex = 0
        PBAY.SelectedIndex = 2
        PBBX.SelectedIndex = 1
        PBBY.SelectedIndex = 9
        SwRow1.SelectedIndex = 0
        SwRow2.SelectedIndex = 1
        SwCol1.SelectedIndex = 2
        SwCol2.SelectedIndex = 3
        PlantX.SelectedIndex = 0
        PlantY.SelectedIndex = 0

        LevelCollectionListBox.SelectedIndex = LevelCollectionListBox.Items.Count - 1

        CardSlotInfo.Text = CardSlotBar.Value.ToString
        RedLineInfo.Text = RedLineBar.Value.ToString

        '检查僵尸卡是否被修改过
        ReadZombieCardPropertyOnce()

        '统一控件字体
        EnterCode.LanguageOption = RichTextBoxLanguageOptions.UIFonts

        '记忆上次复选框状态
        MagnetTimerSwitch.Checked = GetSetting("IZ_Format_Designer_V2", "SaveSettings", "MagnetTimerSwitch_CHECK", False)
        AutoPaste.Checked = GetSetting("IZ_Format_Designer_V2", "SaveSettings", "AutoPaste_CHECK", False)

        RealPlants.Checked = GetSetting("IZ_Format_Designer_V2", "SaveSettings", "RealPlants_CHECK", False)
        IZECardOnly.Checked = GetSetting("IZ_Format_Designer_V2", "SaveSettings", "IZECardOnly_CHECK", False)
        ManualCtrl.Checked = GetSetting("IZ_Format_Designer_V2", "SaveSettings", "ManualCtrl_CHECK", False)
        AutoFillPortalPos.Checked = GetSetting("IZ_Format_Designer_V2", "SaveSettings", "AutoFillPortalPos_CHECK", False)

        '恢复修改按键INDEX
        PlantKeyEdit.SelectedIndex = GetSetting("IZ_Format_Designer_V2", "SaveSettings", "PlantKeyEdit_INDEX", 15)
        ShovelOnceKeyEdit.SelectedIndex = GetSetting("IZ_Format_Designer_V2", "SaveSettings", "ShovelOnceKeyEdit_INDEX", 16)
        SpeedUpKeyEdit.SelectedIndex = GetSetting("IZ_Format_Designer_V2", "SaveSettings", "SpeedUpKeyEdit_INDEX", 17)

        '获取倍速Value，更新文本
        SpeedIndex.Value = GetSetting("IZ_Format_Designer_V2", "SaveSettings", "SpeedIndex_Value", 0)
        Select Case SpeedIndex.Value
            Case 0
                SpeedIndexText.Text = "2x"
                SpeedUp.Text = "二倍速"
            Case 1
                SpeedIndexText.Text = "4x"
                SpeedUp.Text = "四倍速"
            Case 2
                SpeedIndexText.Text = "8x"
                SpeedUp.Text = "八倍速"
            Case 3
                SpeedIndexText.Text = "16x"
                SpeedUp.Text = "十六倍速"
            Case 4
                SpeedIndexText.Text = "32x"
                SpeedUp.Text = "三十二倍速"
            Case 5
                SpeedIndexText.Text = "64x"
                SpeedUp.Text = "六十四倍速"
        End Select


        '读取统计数值
        PlantsPlanted = GetSetting("IZ_Format_Designer_V2", "Statistics", "PlantsPlanted", 0)
        LevelsGenerated = GetSetting("IZ_Format_Designer_V2", "Statistics", "LevelsGenerated", 0)
        RunningTime = GetSetting("IZ_Format_Designer_V2", "Statistics", "RunningTime", 0)

        '给种植赋予按键
        Plant_Key = KeysIndexDictionary(GetSetting("IZ_Format_Designer_V2", "SaveSettings", "PlantKeyEdit_INDEX", 15))
        ShovelOnce_Key = KeysIndexDictionary(GetSetting("IZ_Format_Designer_V2", "SaveSettings", "ShovelOnceKeyEdit_INDEX", 16))
        SpeedUp_Key = KeysIndexDictionary(GetSetting("IZ_Format_Designer_V2", "SaveSettings", "SpeedUpKeyEdit_INDEX", 17))

        '获取我的关卡，如果无则赋初值
        For GetMyLevelSetting = 0 To 99
            MyLevelCollection(GetMyLevelSetting) = GetSetting("IZ_Format_Designer_V2", "MyLevelCollection", "MyLevel(" + GetMyLevelSetting.ToString + ")", "\\\\")
        Next

        '创建关卡编号
        OpenLevelInput()

        LevelListView.Items.Clear()
        LevelListView.BeginUpdate()
        For LevelIndex = 1 To 100
            If LevelIndex <= 9 Then
                LevelListView.Items.Add("00" + LevelIndex.ToString)

            ElseIf LevelIndex >= 10 And LevelIndex <= 99 Then
                LevelListView.Items.Add("0" + LevelIndex.ToString)

            ElseIf LevelIndex > 99 Then
                LevelListView.Items.Add(LevelIndex.ToString)
            End If
        Next

        '生成每个关卡编号的其中内容
        For LevelIndex = 0 To 99
            LevelListView.Items(LevelIndex).SubItems.Add(ListLevelProCodeString(MyLevelCollection(LevelIndex), 1))
            LevelListView.Items(LevelIndex).SubItems.Add(ListLevelProCodeString(MyLevelCollection(LevelIndex), 2))
            LevelListView.Items(LevelIndex).SubItems.Add(ListLevelProCodeString(MyLevelCollection(LevelIndex), 3))

        Next
        LevelListView.EndUpdate()

        '更新随机寄语
        ShowTip(80)

    End Sub

#End Region

#Region "程序关闭时"

    '关闭修改器时
    Private Sub Main_Closed() Handles MyBase.Closed

        PVZ.CloseGame(True)
        '注销全局热键
        For i = 0 To 2
            UnregisterHotKey(Handle, i)
        Next

        '记录结束时间
        Dim TimeInterval As TimeSpan = DateTime.Now - StartTime

        RunningTime += CInt(TimeInterval.TotalSeconds)

        '恢复玉米炮CD
        SetCobColdDownTime(3000)

        '关闭后台运行
        Memory.WriteByte(&H54EBA8, 116)

        '关闭资源上限

        '解锁传送门
        PVZ.FixPortal(False)

        '取消禁止删档
        PVZ.Memory.WriteByte(&H54B267, 116)

        '记忆复选框状态

        '常规
        SaveSetting("IZ_Format_Designer_V2", "SaveSettings", "MagnetTimerSwitch_CHECK", MagnetTimerSwitch.Checked)
        SaveSetting("IZ_Format_Designer_V2", "SaveSettings", "AutoPaste_CHECK", AutoPaste.Checked)
        '布阵
        SaveSetting("IZ_Format_Designer_V2", "SaveSettings", "RealPlants_CHECK", RealPlants.Checked)
        SaveSetting("IZ_Format_Designer_V2", "SaveSettings", "IZECardOnly_CHECK", IZECardOnly.Checked)
        SaveSetting("IZ_Format_Designer_V2", "SaveSettings", "ManualCtrl_CHECK", ManualCtrl.Checked)
        SaveSetting("IZ_Format_Designer_V2", "SaveSettings", "AutoFillPortalPos_CHECK", AutoFillPortalPos.Checked)
        '倍速滑条
        SaveSetting("IZ_Format_Designer_V2", "SaveSettings", "SpeedIndex_Value", SpeedIndex.Value)
        '快捷键
        SaveSetting("IZ_Format_Designer_V2", "SaveSettings", "PlantKeyEdit_INDEX", PlantKeyEdit.SelectedIndex)
        SaveSetting("IZ_Format_Designer_V2", "SaveSettings", "ShovelOnceKeyEdit_INDEX", ShovelOnceKeyEdit.SelectedIndex)
        SaveSetting("IZ_Format_Designer_V2", "SaveSettings", "SpeedUpShovelKeyEdit_INDEX", SpeedUpKeyEdit.SelectedIndex)
        '统计数据
        SaveSetting("IZ_Format_Designer_V2", "Statistics", "PlantsPlanted", PlantsPlanted)
        SaveSetting("IZ_Format_Designer_V2", "Statistics", "LevelsGenerated", LevelsGenerated)
        SaveSetting("IZ_Format_Designer_V2", "Statistics", "RunningTime", RunningTime)


    End Sub

#End Region

#Region "Tab：常规"

#Region "启动和寻找"

    '找游戏
    Private Sub FindGame()

        If PVZ.RunGame() And GameVer = 1 Then

            GameFound = True
            GameState.ForeColor = Color.SlateBlue
            GameState.Text = "已找到游戏"
            SunRefresher.Enabled = True


            '启用按钮

            ModifySun.Enabled = True
            SunConfirm.Enabled = True
            SunTo2K.Enabled = True

            SunToMax.Enabled = True

            CobNoCD.Enabled = True
            AllowPlants.Enabled = True
            NoCD.Enabled = True

            CardSlotBar.Enabled = True
            ZomCard.Enabled = True
            ZombieType.Enabled = True
            RedLineBar.Enabled = True
            ReplaceA.Enabled = True
            ReplaceB.Enabled = True
            ReplaceConfirm.Enabled = True
            ZombieCardSunType.Enabled = True
            ZombieCardSun.Enabled = True
            ZombieSunConfirm.Enabled = True
            ResetZombieCardProperty.Enabled = True
            Fail.Enabled = True
            Clear.Enabled = True
            KillAll.Enabled = True
            SwitchintoIZE.Enabled = True
            CreateCodeAndCopy.Enabled = True

            AutoColletct.Enabled = True
            LockShovel.Enabled = True
            SpeedUp.Enabled = True
            EnterCode.Enabled = True
            ClearText.Enabled = True
            ReadCode.Enabled = True

            LockButter.Enabled = True
            LockKernel.Enabled = True
            LockKernel.Checked = False
            LockButter.Checked = False

            QSave.Enabled = True
            QLoad.Enabled = True

            ActivePortal.Enabled = True

            GenerateThisLevel.Enabled = True

            SwRow1.Enabled = True
            SwRow2.Enabled = True
            SwCol1.Enabled = True
            SwCol2.Enabled = True
            PlantX.Enabled = True
            PlantY.Enabled = True

            SwitchRow.Enabled = True
            SwitchCol.Enabled = True
            PlantXY.Enabled = True

            WSLevelID.Enabled = True
            DownloadWSLevel.Enabled = True
            OpenWS.Enabled = True
            Randomizer.Enabled = True
            RandomEndless.Enabled = True

            LabelWarn.ForeColor = Color.Black
            LabelWarn.Text = "使用方法：选择要种植的植物，当鼠标处于游戏内时，按下Z键种植"

            '获取玉米炮CD
            'CanonCD.Text = PVZ.Memory.ReadInteger(&H464D4D)

            '允许后台运行
            Memory.WriteByte(&H54EBA8, 112)

            '初始化
            PVZ.InitFunctions()

            '存档/速度 初始化

            If Memory.ReadByte(&H58E286) <> 0 Then
                Load_Init()
                SpeedData = SpeedCtrl_Init()
            End If

            '去除资源上限 10000
            ' PVZ.NoUpperLimit()
            PVZ.SunMax = 10000

            '固定传送门
            PVZ.FixPortal()

            '禁止游戏删档
            PVZ.Memory.WriteByte(&H54B267, 112)

        Else

            GameFound = False
            GameState.ForeColor = Color.Red
            GameState.Text = "未找到游戏"
            SunRefresher.Enabled = False

            '禁用按钮

            ModifySun.Enabled = False
            SunConfirm.Enabled = False
            SunTo2K.Enabled = False
            SunToMax.Enabled = False
            CobNoCD.Enabled = False
            AllowPlants.Enabled = False
            NoCD.Enabled = False
            CardSlotBar.Enabled = False
            ZomCard.Enabled = False
            ZombieType.Enabled = False
            RedLineBar.Enabled = False
            ReplaceA.Enabled = False
            ReplaceB.Enabled = False
            ReplaceConfirm.Enabled = False
            ZombieCardSunType.Enabled = False
            ZombieCardSun.Enabled = False
            ZombieSunConfirm.Enabled = False
            ResetZombieCardProperty.Enabled = False
            Fail.Enabled = False
            Clear.Enabled = False
            KillAll.Enabled = False
            SwitchintoIZE.Enabled = False
            CreateCodeAndCopy.Enabled = False

            AutoColletct.Enabled = False
            LockShovel.Enabled = False
            SpeedUp.Enabled = False
            EnterCode.Enabled = False
            ClearText.Enabled = False
            ReadCode.Enabled = False

            LockKernel.Enabled = False
            LockButter.Enabled = False
            LockKernel.Checked = False
            LockButter.Checked = False

            QSave.Enabled = False
            QLoad.Enabled = False

            ActivePortal.Enabled = False
            ActivePortal.Checked = False

            CreatePortalButton.Enabled = False
            PWAX.Enabled = False
            PWAY.Enabled = False
            PWBX.Enabled = False
            PWBY.Enabled = False
            PBAX.Enabled = False
            PBAY.Enabled = False
            PBBX.Enabled = False
            PBBY.Enabled = False
            GenerateThisLevel.Enabled = False

            SwRow1.Enabled = False
            SwRow2.Enabled = False
            SwCol1.Enabled = False
            SwCol2.Enabled = False
            PlantX.Enabled = False
            PlantY.Enabled = False

            SwitchRow.Enabled = False
            SwitchCol.Enabled = False
            PlantXY.Enabled = False

            WSLevelID.Enabled = False
            DownloadWSLevel.Enabled = False
            OpenWS.Enabled = False
            Randomizer.Enabled = False
            RandomEndless.Enabled = False

            LabelWarn.ForeColor = Color.Red
            LabelWarn.Text = "您还没有打开游戏，或者游戏版本不支持。请点击""常规""中的""寻找游戏""开启其他功能"


        End If


    End Sub

    '重新寻找游戏
    Private Sub FindWindowAgain_Click(sender As Object, e As EventArgs) Handles FindWindowAgain.Click
        FindGame()
    End Sub

    '阳光刷新器
    Private Sub SunRefresher_Tick(sender As Object, e As EventArgs) Handles SunRefresher.Tick
        GameState.Text = "阳光 " + PVZ.Sun.ToString()
    End Sub

#End Region

#Region "磁铁倒计时"

    '每0.1秒刷新面板
    Public Sub MagnetT_Tick(sender As Object, e As EventArgs) Handles MagnetT.Tick

        Dim Magnet_1 As Plant = Nothing
        Dim Magnet_2 As Plant = Nothing
        Dim Magnet_3 As Plant = Nothing

        Dim Magnet_4 As Plant = Nothing
        Dim Magnet_5 As Plant = Nothing

        For Each p In PVZ.AllPlants


            If IsNothing(Magnet_1) = False And IsNothing(Magnet_2) = False And IsNothing(Magnet_3) = False And IsNothing(Magnet_4) = False And p.Type = 31 Then

                Magnet_5 = p
                Continue For

            ElseIf IsNothing(Magnet_1) = False And IsNothing(Magnet_2) = False And IsNothing(Magnet_3) = False And p.Type = 31 Then

                Magnet_4 = p
                Continue For

            ElseIf IsNothing(Magnet_1) = False And IsNothing(Magnet_2) = False And p.Type = 31 Then

                Magnet_3 = p
                Continue For

            ElseIf IsNothing(Magnet_1) = False And p.Type = 31 Then

                Magnet_2 = p
                Continue For

            ElseIf p.Type = 31 Then

                Magnet_1 = p

            ElseIf IsNothing(Magnet_1) = False And IsNothing(Magnet_2) = False And IsNothing(Magnet_3) = False And IsNothing(Magnet_4) = False And IsNothing(Magnet_5) = False Then
                Exit For

            End If

        Next

        If IsNothing(Magnet_1) = False Then
            If Magnet_1.Exist Then
                Mtimer1.Text = (Magnet_1.AttributeCountdown \ 10) / 10
                M1XY.Text = Magnet_1.Row + 1 & "-" & Magnet_1.Column + 1
            Else Mtimer1.Text = "---"
                M1XY.Text = ""
            End If
        Else
            Mtimer1.Text = "---"
            M1XY.Text = ""
        End If

        If IsNothing(Magnet_2) = False Then
            If Magnet_2.Exist Then
                Mtimer2.Text = (Magnet_2.AttributeCountdown \ 10) / 10
                M2XY.Text = Magnet_2.Row + 1 & "-" & Magnet_2.Column + 1
            Else Mtimer2.Text = "---"
                M2XY.Text = ""
            End If
        Else
            Mtimer2.Text = "---"
            M2XY.Text = ""
        End If

        If IsNothing(Magnet_3) = False Then
            If Magnet_3.Exist Then
                Mtimer3.Text = (Magnet_3.AttributeCountdown \ 10) / 10
                M3XY.Text = Magnet_3.Row + 1 & "-" & Magnet_3.Column + 1
            Else Mtimer3.Text = "---"
                M3XY.Text = ""
            End If
        Else
            Mtimer3.Text = "---"
            M3XY.Text = ""
        End If

        If IsNothing(Magnet_4) = False Then
            If Magnet_4.Exist Then
                Mtimer4.Text = (Magnet_4.AttributeCountdown \ 10) / 10
                M4XY.Text = Magnet_4.Row + 1 & "-" & Magnet_4.Column + 1
            Else Mtimer4.Text = "---"
                M4XY.Text = ""
            End If
        Else
            Mtimer4.Text = "---"
            M4XY.Text = ""
        End If

        If IsNothing(Magnet_5) = False Then
            If Magnet_5.Exist Then
                Mtimer5.Text = (Magnet_5.AttributeCountdown \ 10) / 10
                M5XY.Text = Magnet_5.Row + 1 & "-" & Magnet_5.Column + 1
            Else Mtimer5.Text = "---"
                M5XY.Text = ""
            End If
        Else
            Mtimer5.Text = "---"
            M5XY.Text = ""
        End If

    End Sub

    '寻找植物
    Public Function FindPlant(name) As Boolean
        For Each p In PVZ.AllPlants
            If p.Type = name Then
                Return True
                Exit Function
            End If
        Next

        Return False

    End Function

    '找到了才开始计时
    Private Sub FinderMagnet_Tick(sender As Object, e As EventArgs) Handles FinderMagnet.Tick
        If (FindPlant(31)) Then
            MagnetT.Enabled = True
        Else
            MagnetT.Enabled = False
            Mtimer1.Text = "---"
            Mtimer2.Text = "---"
            Mtimer3.Text = "---"
            Mtimer4.Text = "---"
            Mtimer5.Text = "---"
            M1XY.Text = ""
            M2XY.Text = ""
            M3XY.Text = ""
            M4XY.Text = ""
            M5XY.Text = ""

        End If
    End Sub

#End Region

#Region "基础设置"

    'Sun槽只允许输入数字
    Private Sub ModifySun_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ModifySun.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or (e.KeyChar = Chr(8)) Or (e.KeyChar = Chr(13)))

        If e.KeyChar = Chr(13) Then
            SunConfirm_Click(sender, e)
        End If

    End Sub
    '阳光
    Private Sub SunConfirm_Click(sender As Object, e As EventArgs) Handles SunConfirm.Click
        If Not ModifySun.Text = "" Then
            PVZ.Sun = ModifySun.Text
        Else
            PVZ.Sun = 0
        End If
    End Sub

    Private Sub SunTo2K_Click(sender As Object, e As EventArgs) Handles SunTo2K.Click
        PVZ.Sun = 2000
    End Sub
    Private Sub SunToMax_Click(sender As Object, e As EventArgs) Handles SunToMax.Click
        PVZ.Sun = 10000
    End Sub

    '卡槽数量
    Private Sub CardSlotBar_Scroll(sender As Object, e As EventArgs) Handles CardSlotBar.Scroll
        PVZ.CardSlot.SetCardNum(CardSlotBar.Value)
        CardSlotInfo.Text = CardSlotBar.Value.ToString
    End Sub
    '设置红线
    Private Sub RedLineBar_Scroll(sender As Object, e As EventArgs) Handles RedLineBar.Scroll
        SetRedLine(RedLineBar.Value)
        RedLineInfo.Text = RedLineBar.Value.ToString
    End Sub

    '设置红线
    Sub SetRedLine(C As Integer)
        PVZ.Memory.WriteByte(&H4255C4, C)
        PVZ.Memory.WriteInteger(&H4253C7, 10 + 83 * C)
        PVZ.Memory.WriteByte(&H4255DD, C)
        PVZ.Memory.WriteInteger(&H4253F7, 10 + 83 * C)
        PVZ.Memory.WriteByte(&H4255A9, C)
        PVZ.Memory.WriteInteger(&H425416, 10 + 83 * C)
    End Sub

    Private Sub ZombieType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ZombieType.SelectedIndexChanged
        Dim type As PVZ.ZombieType

        Select Case ZombieType.Text

            '僵尸卡

            Case "小鬼" : type = PVZ.CardType.Imp
            Case "普僵" : type = PVZ.CardType.Zombie
            Case "路障" : type = PVZ.CardType.ConeheadZombie
            Case "撑杆" : type = PVZ.CardType.PoleVaultingZombie
            Case "铁门" : type = PVZ.CardType.ScreenDoorZombie
            Case "铁桶" : type = PVZ.CardType.BucketheadZombie
            Case "矿工" : type = PVZ.CardType.DiggerZombie
            Case "蹦极" : type = PVZ.CardType.BungeeZombie
            Case "扶梯" : type = PVZ.CardType.LadderZombie
            Case "气球" : type = PVZ.CardType.BalloonZombie
            Case "橄榄" : type = PVZ.CardType.FootballZombie
            Case "舞王" : type = PVZ.CardType.DancingZombie
            Case "巨人" : type = PVZ.CardType.Gargantuar
            Case "冰车" : type = PVZ.CardType.Zomboin
            Case "跳跳" : type = PVZ.CardType.PogoZombie

            '植物卡

            Case "豌豆/普僵" : type = 0
            Case "向日葵/摇旗" : type = 1
            Case "樱桃/路障" : type = 2
            Case "坚果/撑杆" : type = 3
            Case "土豆雷/铁桶" : type = 4
            Case "寒冰/读报" : type = 5
            Case "大嘴/铁门" : type = 6
            Case "双发/橄榄" : type = 7
            Case "小喷/舞王" : type = 8
            Case "阳光菇/伴舞" : type = 9
            Case "大喷/救生圈" : type = 10
            Case "墓碑吞/潜水" : type = 11
            Case "魅惑/冰车" : type = 12
            Case "胆小/雪橇小队" : type = 13
            Case "寒冰菇/海豚" : type = 14
            Case "毁灭菇/小丑" : type = 15
            Case "睡莲/气球" : type = 16
            Case "窝瓜/矿工" : type = 17
            Case "三线/跳跳" : type = 18
            Case "海草/雪人" : type = 19
            Case "辣椒/蹦极" : type = 20
            Case "地刺/扶梯" : type = 21
            Case "火炬/投石车" : type = 22
            Case "高坚果/巨人" : type = 23
            Case "海蘑菇/小鬼" : type = 24
            Case "路灯花/僵王" : type = 25
            Case "仙人掌/豌豆僵尸" : type = 26
            Case "三叶草/坚果墙僵尸" : type = 27
            Case "裂荚/辣椒僵尸" : type = 28
            Case "杨桃/机枪僵尸" : type = 29
            Case "南瓜头/窝瓜僵尸" : type = 30
            Case "磁力菇/高坚果僵尸" : type = 31
            Case "卷心菜/红眼" : type = 32


        End Select

        If Not ZombieType.Text = "" Then
            PVZ.CardSlot.GetCard(ZomCard.Text - 1).CardType = type
        End If
    End Sub

#End Region

#Region "僵尸卡槽属性修改"
    Private Sub ReplaceA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReplaceA.SelectedIndexChanged


        If PVZ.Memory.ReadInteger(&H42A046) = -125582400 Then
            PVZ.Memory.WriteQword(&H42A03E, 202333581277315)
            PVZ.Memory.WriteShort(&H42A046, 0)
            PVZ.Memory.WriteByte(&H4661BE, 124)
            PVZ.Memory.WriteByte(&H42A41A, 32)
        End If

        If ReplaceA.SelectedIndex = 0 Then
            ReplaceB.SelectedIndex = PVZ.Memory.ReadInteger(&H42A044)
        ElseIf ReplaceA.SelectedIndex > 0 And ReplaceA.SelectedIndex <= 14 Then
            ReplaceB.SelectedIndex = PVZ.Memory.ReadInteger(&H42A04E + (ReplaceA.SelectedIndex - 1) * 11)
        End If

    End Sub

    Private Sub ReplaceConfirm_Click(sender As Object, e As EventArgs) Handles ReplaceConfirm.Click
        If PVZ.Memory.ReadInteger(&H42A046) = -125582400 Then
            PVZ.Memory.WriteQword(&H42A03E, 202333581277315)
            PVZ.Memory.WriteShort(&H42A046, 0)
            PVZ.Memory.WriteByte(&H4661BE, 124)
            PVZ.Memory.WriteByte(&H42A41A, 32)
        End If

        If ReplaceA.SelectedIndex = 0 Then
            PVZ.Memory.WriteInteger(&H42A044, ReplaceB.SelectedIndex)
        ElseIf ReplaceA.SelectedIndex > 0 Then
            PVZ.Memory.WriteInteger(&H42A04E + (ReplaceA.SelectedIndex - 1) * 11, ReplaceB.SelectedIndex)
        End If

        ZombieCardTypeDetector()

    End Sub
    Private Sub ZombieCardTypeDetector()
        Select Case ReplaceA.SelectedIndex
            Case 0
                If ReplaceB.SelectedIndex <> 0 Then
                    ReplaceA.Items(0) = "普僵★"
                Else ReplaceA.Items(0) = "普僵"
                End If
            Case 1
                If ReplaceB.SelectedIndex <> 2 Then
                    ReplaceA.Items(1) = "路障★"
                Else ReplaceA.Items(1) = "路障"
                End If
            Case 2
                If ReplaceB.SelectedIndex <> 3 Then
                    ReplaceA.Items(2) = "撑杆★"
                Else ReplaceA.Items(2) = "撑杆"
                End If
            Case 3
                If ReplaceB.SelectedIndex <> 4 Then
                    ReplaceA.Items(3) = "铁桶★"
                Else ReplaceA.Items(3) = "铁桶"
                End If
            Case 4
                If ReplaceB.SelectedIndex <> 21 Then
                    ReplaceA.Items(4) = "扶梯★"
                Else ReplaceA.Items(4) = "扶梯"
                End If
            Case 5
                If ReplaceB.SelectedIndex <> 17 Then
                    ReplaceA.Items(5) = "矿工★"
                Else ReplaceA.Items(5) = "矿工"
                End If
            Case 6
                If ReplaceB.SelectedIndex <> 20 Then
                    ReplaceA.Items(6) = "蹦极★"
                Else ReplaceA.Items(6) = "蹦极"
                End If
            Case 7
                If ReplaceB.SelectedIndex <> 7 Then
                    ReplaceA.Items(7) = "橄榄★"
                Else ReplaceA.Items(7) = "橄榄"
                End If
            Case 8
                If ReplaceB.SelectedIndex <> 16 Then
                    ReplaceA.Items(8) = "气球★"
                Else ReplaceA.Items(8) = "气球"
                End If
            Case 9
                If ReplaceB.SelectedIndex <> 6 Then
                    ReplaceA.Items(9) = "铁门★"
                Else ReplaceA.Items(9) = "铁门"
                End If
            Case 10
                If ReplaceB.SelectedIndex <> 12 Then
                    ReplaceA.Items(10) = "冰车★"
                Else ReplaceA.Items(10) = "冰车"
                End If
            Case 11
                If ReplaceB.SelectedIndex <> 18 Then
                    ReplaceA.Items(11) = "跳跳★"
                Else ReplaceA.Items(11) = "跳跳"
                End If
            Case 12
                If ReplaceB.SelectedIndex <> 8 Then
                    ReplaceA.Items(12) = "舞王★"
                Else ReplaceA.Items(12) = "舞王"
                End If
            Case 13
                If ReplaceB.SelectedIndex <> 23 Then
                    ReplaceA.Items(13) = "巨人★"
                Else ReplaceA.Items(13) = "巨人"
                End If
            Case 14
                If ReplaceB.SelectedIndex <> 24 Then
                    ReplaceA.Items(14) = "小鬼★"
                Else ReplaceA.Items(14) = "小鬼"
                End If

            Case Else

        End Select
    End Sub

    '检测一遍僵尸卡属性，检测是否被改过
    Private Sub ReadZombieCardPropertyOnce()

        Dim Rzcpo As Integer

        '卡槽
        If PVZ.Memory.ReadInteger(&H42A044) = 0 Or PVZ.Memory.ReadInteger(&H42A044) = -1010814205 Then
            ReplaceA.Items(0) = "普僵"
        Else ReplaceA.Items(0) = "普僵★"
        End If

        For Rzcpo = 0 To 13

            If PVZ.Memory.ReadInteger(&H42A04E + 11 * Rzcpo) = ZombieCardTypeIndex(Rzcpo) Or PVZ.Memory.ReadInteger(&H42A04E + 11 * Rzcpo) = 0 Then
                ReplaceA.Items(Rzcpo + 1) = ZombieCardTypeInfo(Rzcpo)
            Else ReplaceA.Items(Rzcpo + 1) = ZombieCardTypeInfoStar(Rzcpo)
            End If
        Next

        '阳光
        For Rzcpo = 0 To 6
            If PVZ.Memory.ReadInteger(&H467B60 + 6 * Rzcpo) = ZombieCardSunValue(Rzcpo) Or (PVZ.Memory.ReadInteger(&H467B60 + 6 * Rzcpo) = 0 And Not PVZ.GameState.Playing) Then
                ZombieCardSunType.Items(Rzcpo) = ZombieCardSunInfo(Rzcpo)
            Else ZombieCardSunType.Items(Rzcpo) = ZombieCardSunInfoStar(Rzcpo)
            End If
        Next

        If PVZ.Memory.ReadInteger(&H467B3D) = 100 Or (PVZ.Memory.ReadInteger(&H467B3D) = 0 And Not PVZ.GameState.Playing) Then
            ZombieCardSunType.Items(7) = "铁门"
        Else ZombieCardSunType.Items(7) = "★铁门"
        End If

        If PVZ.Memory.ReadInteger(&H467B48) = 200 Or (PVZ.Memory.ReadInteger(&H467B48) = 0 And Not PVZ.GameState.Playing) Then
            ZombieCardSunType.Items(8) = "跳跳"
        Else ZombieCardSunType.Items(8) = "★跳跳"
        End If

    End Sub

    '僵尸卡阳光
    Private Sub ZombieCardSunType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ZombieCardSunType.SelectedIndexChanged
        If ZombieCardSunType.SelectedIndex >= 0 And ZombieCardSunType.SelectedIndex <= 6 Then
            ZombieCardSun.Text = PVZ.Memory.ReadInteger(&H467B60 + ZombieCardSunType.SelectedIndex * 6)
        ElseIf ZombieCardSunType.SelectedIndex = 7 Then
            ZombieCardSun.Text = PVZ.Memory.ReadInteger(&H467B3D)
        ElseIf ZombieCardSunType.SelectedIndex = 8 Then
            ZombieCardSun.Text = PVZ.Memory.ReadInteger(&H467B48)
        End If
    End Sub

    Private Sub ZombieCardSun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ZombieCardSun.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or (e.KeyChar = Chr(8)) Or (e.KeyChar = Chr(13)))
        If e.KeyChar = Chr(13) Then
            ZombieSunConfirm_Click(sender, e)
        End If
    End Sub

    Private Sub ZombieSunConfirm_Click(sender As Object, e As EventArgs) Handles ZombieSunConfirm.Click
        If ZombieCardSunType.SelectedIndex >= 0 And ZombieCardSunType.SelectedIndex <= 6 Then
            PVZ.Memory.WriteInteger(&H467B60 + ZombieCardSunType.SelectedIndex * 6, ZombieCardSun.Text)
        ElseIf ZombieCardSunType.SelectedIndex = 7 Then
            PVZ.Memory.WriteInteger(&H467B3D, ZombieCardSun.Text)
        ElseIf ZombieCardSunType.SelectedIndex = 8 Then
            PVZ.Memory.WriteInteger(&H467B48, ZombieCardSun.Text)

        End If

        ZombieCardSunDetector()

    End Sub

    Private Sub ZombieCardSunDetector()
        Select Case ZombieCardSunType.SelectedIndex
            Case 0
                If ZombieCardSun.Text <> 50 Then
                    ZombieCardSunType.Items(0) = "★普僵/小鬼"
                Else ZombieCardSunType.Items(0) = "普僵/小鬼"
                End If
            Case 1
                If ZombieCardSun.Text <> 75 Then
                    ZombieCardSunType.Items(1) = "★路障/撑杆"
                Else ZombieCardSunType.Items(1) = "路障/撑杆"
                End If
            Case 2
                If ZombieCardSun.Text <> 350 Then
                    ZombieCardSunType.Items(2) = "★舞王"
                Else ZombieCardSunType.Items(2) = "舞王"
                End If
            Case 3
                If ZombieCardSun.Text <> 125 Then
                    ZombieCardSunType.Items(3) = "★铁桶/矿工/蹦极"
                Else ZombieCardSunType.Items(3) = "铁桶/矿工/蹦极"
                End If
            Case 4
                If ZombieCardSun.Text <> 150 Then
                    ZombieCardSunType.Items(4) = "★扶梯/气球"
                Else ZombieCardSunType.Items(4) = "扶梯/气球"
                End If
            Case 5
                If ZombieCardSun.Text <> 175 Then
                    ZombieCardSunType.Items(5) = "★橄榄球/冰车"
                Else ZombieCardSunType.Items(5) = "橄榄球/冰车"
                End If
            Case 6
                If ZombieCardSun.Text <> 300 Then
                    ZombieCardSunType.Items(6) = "★巨人"
                Else ZombieCardSunType.Items(6) = "巨人"
                End If
            Case 7
                If ZombieCardSun.Text <> 100 Then
                    ZombieCardSunType.Items(7) = "★铁门"
                Else ZombieCardSunType.Items(7) = "铁门"
                End If
            Case 8
                If ZombieCardSun.Text <> 200 Then
                    ZombieCardSunType.Items(8) = "★跳跳"
                Else ZombieCardSunType.Items(8) = "跳跳"
                End If
            Case Else
        End Select
    End Sub

    '重置属性
    Private Sub ResetZombieCardProperty_Click(sender As Object, e As EventArgs) Handles ResetZombieCardProperty.Click

        Dim Rzcp As Integer

        If PVZ.Memory.ReadInteger(&H42A046) = -125582400 Then
            PVZ.Memory.WriteQword(&H42A03E, 202333581277315)
            PVZ.Memory.WriteShort(&H42A046, 0)
            PVZ.Memory.WriteByte(&H4661BE, 124)
            PVZ.Memory.WriteByte(&H42A41A, 32)
        End If

        PVZ.Memory.WriteInteger(&H42A044, 0)
        For Rzcp = 0 To 13
            PVZ.Memory.WriteInteger(&H42A04E + 11 * Rzcp, ZombieCardTypeIndex(Rzcp))
        Next

        For Rzcp = 0 To 6
            PVZ.Memory.WriteInteger(&H467B60 + 6 * Rzcp, ZombieCardSunValue(Rzcp))
        Next
        PVZ.Memory.WriteInteger(&H467B3D, 100)
        PVZ.Memory.WriteInteger(&H467B48, 200)

        ResetZombieCardNames()

        ReplaceA_SelectedIndexChanged（sender, e）
        ZombieCardSunType_SelectedIndexChanged(sender, e)

    End Sub

    Private Sub ResetZombieCardNames()

        Dim Rzcn As Integer

        ReplaceA.Items(0) = "普僵"
        For Rzcn = 0 To 13
            ReplaceA.Items(Rzcn + 1) = ZombieCardTypeInfo(Rzcn)
        Next

        For Rzcn = 0 To 6
            ZombieCardSunType.Items(Rzcn) = ZombieCardSunInfo(Rzcn)
        Next
        ZombieCardSunType.Items(7) = "铁门"
        ZombieCardSunType.Items(8) = "跳跳"

    End Sub
#End Region

#Region "快捷指令"

    '快捷指令
    Private Sub Fail_Click(sender As Object, e As EventArgs) Handles Fail.Click
        PVZ.Sun = 0
        For Each zombies In PVZ.AllZombies
            zombies.State = 3

            For Each items In PVZ.AllCoins
                items.Exist = False
            Next
        Next
    End Sub
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        For Each Plants In PVZ.AllPlants
            Plants.Remove()
        Next

        For Each NotBrain In PVZ.AllGriditems
            If NotBrain.Type = 1 Or NotBrain.Type = 2 Or NotBrain.Type = 3 Or NotBrain.Type = 4 Or NotBrain.Type = 5 Or NotBrain.Type = 11 Then
                NotBrain.Remove()
            End If
        Next
    End Sub

    Public Sub KillAll_Click(sender As Object, e As EventArgs) Handles KillAll.Click
        For Each zombies In PVZ.AllZombies
            zombies.State = 3
        Next
    End Sub
    Private Sub SwitchintoIZE_Click(sender As Object, e As EventArgs) Handles SwitchintoIZE.Click

        PVZ.CardSlot.SetCardNum(9)

        PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Imp
        PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
        PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
        PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.BucketheadZombie
        PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.BungeeZombie
        PVZ.CardSlot.GetCard(5).CardType = PVZ.CardType.DiggerZombie
        PVZ.CardSlot.GetCard(6).CardType = PVZ.CardType.LadderZombie
        PVZ.CardSlot.GetCard(7).CardType = PVZ.CardType.FootballZombie
        PVZ.CardSlot.GetCard(8).CardType = PVZ.CardType.DancingZombie

        CardSlotBar.Value = 9
        CardSlotInfo.Text = CardSlotBar.Value.ToString

    End Sub

    '禁止删除存档(废除)
    'Private Sub NoSave_CheckedChanged(sender As Object, e As EventArgs) Handles NoSave.CheckedChanged
    '    If NoSave.Checked Then
    '        PVZ.Memory.WriteByte(&H54B267, 112)
    '    Else
    '        PVZ.Memory.WriteByte(&H54B267, 116)
    '    End If
    'End Sub

    '自动收集
    Private Sub AutoColletct_CheckedChanged(sender As Object, e As EventArgs) Handles AutoColletct.CheckedChanged
        PVZ.AutoCollect(AutoColletct.Checked）
    End Sub
    '锁定铲子
    Private Sub LockShovel_CheckedChanged(sender As Object, e As EventArgs) Handles LockShovel.CheckedChanged
        PVZ.LockShovel(LockShovel.Checked)
    End Sub
    '允许种植物
    Private Sub AllowPlants_CheckedChanged(sender As Object, e As EventArgs) Handles AllowPlants.CheckedChanged
        If AllowPlants.Checked Then
            PVZ.Memory.WriteInteger(&H40FDC7, 3408437)
            PVZ.Memory.WriteInteger(&H438CFF, 3240701)
            PVZ.Memory.WriteInteger(&H438FAD, 3240015)
        Else
            PVZ.Memory.WriteInteger(&H40FDC7, 276997)
            PVZ.Memory.WriteInteger(&H438CFF, 109261)
            PVZ.Memory.WriteInteger(&H438FAD, 108575)
        End If
    End Sub
    '取消冷却
    Private Sub NoCD_CheckedChanged(sender As Object, e As EventArgs) Handles NoCD.CheckedChanged
        If NoCD.Checked = True Then
            Memory.WriteByte(&H487296, 112)
            Memory.WriteByte(&H488250, 235)
            Memory.WriteByte(&H488E76, 1)
        Else
            Memory.WriteByte(&H487296, 126)
            Memory.WriteByte(&H488250, 117)
            Memory.WriteByte(&H488E76, 0)
        End If
    End Sub
    '倍速
    Private Sub SpeedUp_CheckedChanged(sender As Object, e As EventArgs) Handles SpeedUp.CheckedChanged
        If SpeedUp.Checked = True Then
            '倍速开启
            Select Case SpeedIndex.Value
                Case 0 '2x
                    Memory.WriteByte(SpeedData, 2)
                    CreateCaption("2x", 6, 100)
                Case 1 '4x
                    Memory.WriteByte(SpeedData, 4)
                    CreateCaption("4x", 6, 100)
                Case 2 '8x
                    Memory.WriteByte(SpeedData, 8)
                    CreateCaption("8x", 6, 100)
                Case 3 '16x
                    Memory.WriteByte(SpeedData, 16)
                    CreateCaption("16x", 6, 100)
                Case 4 '32x
                    Memory.WriteByte(SpeedData, 32)
                    CreateCaption("32x", 6, 100)
                Case 5 '64x
                    Memory.WriteByte(SpeedData, 64)
                    CreateCaption("64x", 6, 100)
            End Select
            CreateSound(25)
        Else
            Memory.WriteByte(SpeedData, 1)
            CreateCaption("1x", 6, 100)
            CreateSound(25)
        End If
    End Sub
    '玉米炮CD
    Private Sub CobNoCD_CheckedChanged(sender As Object, e As EventArgs) Handles CobNoCD.CheckedChanged
        If CobNoCD.Checked Then
            SetCobColdDownTime(100)
            For Each Cob In AllPlants
                If Cob.Type = PlantType.CobCannon Then
                    Cob.AttributeCountdown = 100
                End If
            Next
        Else
            SetCobColdDownTime(3000)
        End If
    End Sub

    ''存档与读档
    '快速存档
    Private Sub QSave_Click(sender As Object, e As EventArgs) Handles QSave.Click
        If LevelState = PVZ.GameState.Playing Then
            QuickSave()
            '恢复音乐
            QuickSaveResumeAudio(1)
            QuickSaveResumeAudio(0)
            CodeState.ForeColor = Color.Indigo
            CodeState.Text = "已存档"
            CleanStateText.Enabled = False
            CleanStateText.Enabled = True
        End If

    End Sub

    '快速读档
    Private Sub QLoad_Click(sender As Object, e As EventArgs) Handles QLoad.Click

        If LevelState = PVZ.GameState.Playing Then
            Memory.WriteByte(&H58E282, 1)
            CodeState.ForeColor = Color.Indigo
            CodeState.Text = "已读档"
            CleanStateText.Enabled = False
            CleanStateText.Enabled = True
        End If

    End Sub


#End Region

#Region "加密和解密"

    '阵型转换成编码
    Public NumList = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+", "/"}

    Public Function PlaToStr() As String
        Dim NoneCard As Boolean = False
        Dim add_portal_code As String = "|"

        For Each i As PVZ.CardSlot.SeedCard In PVZ.AllCards
            If i.CardType = -1 Then
                NoneCard = True

            End If
        Next
        If NoneCard = False Then
            '限制列数
            Dim Str As String = "IZ"
            Dim RedLinein4 As Integer = PVZ.Memory.ReadInteger(&H4253C7)
            Dim RedLinein5 As Integer = PVZ.Memory.ReadInteger(&H4253F7)
            Dim RedLinein6 As Integer = PVZ.Memory.ReadInteger(&H425416)
            If PVZ.LevelId >= 61 And PVZ.LevelId <= 65 Then '表示四列 基地址&H4253C7, 10 + 83 * 0，0表示列数
                RedLinein4 = (RedLinein4 - 10) / 83
            ElseIf (PVZ.LevelId >= 66 And PVZ.LevelId <= 68) Or PVZ.LevelId = 70 Then '表示五列 基地址&H4253F7
                RedLinein5 = (RedLinein5 - 10) / 83
            ElseIf PVZ.LevelId = 69 Then '表示六列 基地址&H425416
                RedLinein6 = (RedLinein6 - 10) / 83
            End If

            If PVZ.LevelId >= 61 And PVZ.LevelId <= 65 Then
                Str += NumList(RedLinein4)
            ElseIf (PVZ.LevelId >= 66 And PVZ.LevelId <= 68) Or PVZ.LevelId = 70 Then
                Str += NumList(RedLinein5)
            ElseIf PVZ.LevelId = 69 Then
                Str += NumList(RedLinein6)
            Else Str += NumList(RedLineBar.Value) '防止关卡ID不在61至70 以设置中的为准
            End If
            '阳光
            Dim SunStr As String = Nothing
            Dim Sun As Integer = PVZ.Sun
            For i = 0 To 2
                SunStr = NumList(Sun Mod 64) + SunStr
                Sun \= 64
            Next
            Str += SunStr
            '卡槽
            Str += NumList(PVZ.CardSlot.CardNum)
            For Each C As PVZ.CardSlot.SeedCard In PVZ.AllCards
                Dim Num = C.CardType
                If Num <= 48 Then
                    Str += NumList(C.CardType)
                ElseIf Num >= 60 Then
                    Str += NumList(C.CardType - 11)
                End If
            Next
            '植物
            For Each Pla In PVZ.AllPlants
                Str += NumList(Pla.Type)
                Str += NumList(Pla.Row * 10 + Pla.Column)
            Next
            '场地物品
            For Each Item In PVZ.AllGriditems

                Dim type As Integer = Nothing

                If Item.Type <= 3 Then
                    type = Item.Type
                ElseIf Item.Type = 11 Then
                    type = 4
                End If

                If type <> 0 Then
                    Str += NumList(53 + type)
                    Str += NumList(Item.Row * 10 + Item.Column)
                End If
            Next

            '传送门 黄门
            For Each item_p In PVZ.AllGriditems
                If item_p.Type = GriditemType.PortalYellow Then
                    Dim y_portals As Integer
                    If item_p.Row > 7 Then
                        item_p.Row = 7
                    End If
                    If item_p.Column > 10 Then
                        item_p.Column = 10
                    End If
                    y_portals = item_p.Row + item_p.Column * 11
                    add_portal_code = add_portal_code + "y" + y_portals.ToString()

                End If
            Next

            '白门
            For Each item_p In PVZ.AllGriditems
                If item_p.Type = GriditemType.PortalBlue Then
                    Dim b_portals As Integer
                    If item_p.Row > 7 Then
                        item_p.Row = 7
                    End If
                    If item_p.Column > 10 Then
                        item_p.Column = 10
                    End If
                    b_portals = item_p.Row + item_p.Column * 11
                    add_portal_code = add_portal_code + "b" + b_portals.ToString()

                End If
            Next

            '有传送门才加
            For Each items In PVZ.AllGriditems
                If items.Type = GriditemType.PortalYellow Or items.Type = GriditemType.PortalBlue Then
                    Str += add_portal_code
                    Exit For
                End If

            Next


            CodeState.ForeColor = Color.Indigo
            CodeState.Text = "完成"
            CleanStateText.Enabled = False
            CleanStateText.Enabled = True
            Return Str
        Else
            CodeState.ForeColor = Color.Red
            CodeState.Text = "错误：卡槽中有空隙"
            CleanStateText.Enabled = False
            CleanStateText.Enabled = True
        End If

#Disable Warning BC42105 ' 函数没有在所有代码路径上返回值
    End Function
#Enable Warning BC42105

    '解码
    '全部清除
    Public Sub AllClr()
        For Each p In PVZ.AllPlants
            p.Remove()
        Next

        For Each z In PVZ.AllZombies
            z.Remove()

        Next
        For Each i In PVZ.AllCoins
            i.Exist = False
        Next
        For Each gi In PVZ.AllGriditems
            '排除清空大脑
            If gi.Type <> 12 Then gi.Remove()
        Next

    End Sub


    Public Function StrToPla(Str As String, P_Str As String) As Integer

        'IZ检测
        Try
            If Str.Length > 2 Then
                If Str.Substring(0, 2) = "IZ" Then

                    AllClr()

                    Str = Str.Substring(2, Str.Length - 2)
                    '限制列数
                    SetRedLine(Array.IndexOf(NumList, Str.Substring(0, 1)))
                    Str = Str.Substring(1, Str.Length - 1)
                    '阳光
                    Dim Sun3 = Array.IndexOf(NumList, Str.Substring(0, 1)) * Math.Pow(64, 2)
                    Dim Sun2 = Array.IndexOf(NumList, Str.Substring(1, 1)) * Math.Pow(64, 1)
                    Dim Sun1 = Array.IndexOf(NumList, Str.Substring(2, 1))
                    PVZ.Sun = Sun1 + Sun2 + Sun3
                    Str = Str.Substring(3, Str.Length - 3)
                    '卡槽
                    PVZ.CardSlot.SetCardNum(Array.IndexOf(NumList, Str.Substring(0, 1)))
                    Str = Str.Substring(1, Str.Length - 1)
                    For i = 0 To PVZ.CardSlot.CardNum - 1
                        Dim type = Array.IndexOf(NumList, Str.Substring(0, 1))
                        If type <= 48 Then
                            PVZ.CardSlot.GetCard(i).CardType = type
                        Else
                            PVZ.CardSlot.GetCard(i).CardType = type + 11
                        End If
                        Str = Str.Substring(1, Str.Length - 1)
                    Next
                    '植物
                    Do Until Str = ""
                        Dim Pla As PVZ.Plant
                        Dim type = Array.IndexOf(NumList, Str.Substring(0, 1))
                        Dim RC = Array.IndexOf(NumList, Str.Substring(1, 1))
                        Dim R = RC \ 10
                        Dim C = RC Mod 10
                        If type <= 52 Then
                            Pla = PVZ.CreatePlant(type, R, C)
                            If RealPlants.Checked = False And Not IsNothing(Pla) Then
                                Pla.Fix()
                            End If

                        Else
                            type -= 53
                            Select Case type
                                Case 1
                                    PVZ.CreateGrave(R, C)
                                Case 2
                                    PVZ.CreateCrater(R, C, 18000)
                                Case 3
                                    PVZ.CreateLadder(R, C)
                                Case 4
                                    PVZ.CreateRake(R, C)
                            End Select
                        End If
                        Str = Str.Substring(2, Str.Length - 2)
                    Loop



                    '传送门
                    Dim portal As String = P_Str
                    If portal <> "" Then
                        '匹配密码
                        Dim format As String = "y(\d+)y(\d+)b(\d+)b(\d+)"

                        '创建匹配
                        Dim match As Match = Regex.Match(portal, format)

                        If match.Success Then
                            Dim result(3) As Integer
                            For i As Integer = 1 To 4
                                Integer.TryParse(match.Groups(i).Value, result(i - 1))
                            Next

                            '匹配结果4拆分8
                            Dim p() As Integer = P4to8(result(0), result(1), result(2), result(3))

                            ActivePortal.Checked = True

                            EnablePortal()

                            '创建传送门
                            CreatePortal(p(0), p(1), p(2), p(3), p(4), p(5), p(6), p(7))

                            '传送门代码刷新输入框
                            If AutoFillPortalPos.Checked = True Then
                                PBAX.SelectedIndex = p(0)
                                PBAY.SelectedIndex = p(1)
                                PBBX.SelectedIndex = p(2)
                                PBBY.SelectedIndex = p(3)
                                PWAX.SelectedIndex = p(4)
                                PWAY.SelectedIndex = p(5)
                                PWBX.SelectedIndex = p(6)
                                PWBY.SelectedIndex = p(7)
                            End If

                        Else

                            Return 4

                        End If

                    End If

                    LevelsGenerated += 1

                    Return 1

                Else

                    Return 2

                End If

            Else

                Return 2

            End If

        Catch '避免异常

            Return 3

        End Try

    End Function

#End Region

#Region "关卡代码相关"
    Private Sub CreateCodeAndCopy_Click(sender As Object, e As EventArgs) Handles CreateCodeAndCopy.Click

        LevelCode = PlaToStr()

        Clipboard.SetData(DataFormats.Text, LevelCode)

        If AutoPaste.Checked = True Then
            EnterCode.Text = LevelCode
        End If

    End Sub

    Private Sub ReadCode_Click(sender As Object, e As EventArgs) Handles ReadCode.Click

        Dim code As String = EnterCode.Text

        Dim portal_code As String

        '去掉所有的空格
        code = code.Replace(" ", "")

        '有传送门吗

        Dim find_char As Integer = code.IndexOf("|")  '没找到为-1

        '有
        If find_char <> -1 AndAlso find_char < code.Length - 1 Then

            '获取传送门代码
            portal_code = GetPortalCode(code)

            '删除传送门代码
            code = RemoveSlash(code, find_char)

        Else portal_code = "" '没有传送门代码

        End If


        If LevelState = PVZ.GameState.Playing Then

            Select Case StrToPla(code, portal_code)
                Case 1
                    CodeState.ForeColor = Color.Indigo
                    CodeState.Text = "关卡已生成"
                    CleanStateText.Enabled = False
                    CleanStateText.Enabled = True
                Case 2
                    CodeState.ForeColor = Color.Red
                    CodeState.Text = "错误的代码"
                    CleanStateText.Enabled = False
                    CleanStateText.Enabled = True
                Case 3
                    CodeState.ForeColor = Color.Red
                    CodeState.Text = "代码异常"
                    CleanStateText.Enabled = False
                    CleanStateText.Enabled = True
                Case 4
                    CodeState.ForeColor = Color.Red
                    CodeState.Text = "传送门格式错误"
                    CleanStateText.Enabled = False
                    CleanStateText.Enabled = True
            End Select

        Else
            CodeState.ForeColor = Color.Red
            CodeState.Text = "请在关卡中生成"
            CleanStateText.Enabled = False
            CleanStateText.Enabled = True

        End If

    End Sub

    Private Sub ClearText_Click(sender As Object, e As EventArgs) Handles ClearText.Click
        EnterCode.Text = ""
    End Sub

    Private Sub EnterCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EnterCode.KeyPress
        If e.KeyChar = Chr(13) Then
            ReadCode_Click(sender, e)
        End If
    End Sub

    '注释字体
    Private Sub EnterCode_TextChanged(sender As Object, e As EventArgs) Handles EnterCode.TextChanged
        Dim FindChar As Integer = EnterCode.Text.IndexOf("|")

        '存储光标最开始位置
        Dim CharStart As Integer = EnterCode.SelectionStart()

        EnterCode.SelectAll()
        '去色
        EnterCode.SelectionColor = Color.Empty
        '恢复光标位置
        EnterCode.Select(CharStart, 0)

        If FindChar <> -1 Then
            '涂色
            EnterCode.Select(FindChar, EnterCode.TextLength - FindChar)
            EnterCode.SelectionColor = Color.Indigo
            '恢复光标位置
            EnterCode.Select(CharStart, 0)
        End If
    End Sub

    '状态文本清空器
    Private Sub CleanStateText_Tick(sender As Object, e As EventArgs) Handles CleanStateText.Tick
        CodeState.Text = ""
        CleanStateText.Enabled = False
    End Sub

    '右键
    Private Sub 粘贴CtrlVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 粘贴CtrlVToolStripMenuItem.Click
        EnterCode.Text = Clipboard.GetData(DataFormats.Text)
    End Sub

    Private Sub 粘贴并生成ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 粘贴并生成ToolStripMenuItem.Click
        EnterCode.Text = Clipboard.GetData(DataFormats.Text)
        ReadCode_Click(sender, e)
    End Sub

    Private Sub 复制内容ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复制内容ToolStripMenuItem.Click
        Clipboard.SetData(DataFormats.Text, EnterCode.Text)
    End Sub

    Private Sub 清空ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 清空ToolStripMenuItem.Click
        EnterCode.Text = ""
    End Sub

#End Region

#End Region

#Region "Tab：种植"

#Region "负责种植"

    '种植间隔计时器
    Private Sub PlantDeltaTime_Tick(sender As Object, e As EventArgs) Handles PlantDeltaTime.Tick
        PlantDeltaTime.Enabled = False
    End Sub

    '检测鼠标位置
    Private Sub MouseMoveDetector_Tick(sender As Object, e As EventArgs) Handles MouseMoveDetector.Tick
        '范围圈定
        If PVZ.Mouse.InGameArea Then

            PlantSwitch.Checked = True
            PlantSwitchText.Text = "种植已启用"

        Else

            PlantSwitch.Checked = False
            PlantSwitchText.Text = "种植已关闭"

        End If
    End Sub

    '根据按键应用功能
    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_HOTKEY Then '判断是否为热键消息
            Select Case m.WParam.ToInt32 '判断热键消息的注册ID

                '对应卡片
                Case 1

                    If Plantable = True And PlantDeltaTime.Enabled = False And PVZ.LevelState = PVZ.GameState.Playing Then

                        Try

                            If CardType >= 0 And CardType <= 52 Then

                                Dim plant As PVZ.Plant = PVZ.CreatePlant(CardType, PVZ.MousePointer.Row, PVZ.MousePointer.Column)

                                '残血坚果模式
                                'If CardType = CardType.Garlic Then
                                'plant.Hp = 132
                                'End If

                                If RealPlants.Checked = False Then
                                    plant.Fix()
                                End If

                            ElseIf CardType = 53 Then
                                PVZ.CreateLadder(PVZ.MousePointer.Row, PVZ.MousePointer.Column)
                            ElseIf CardType = 54 Then
                                PVZ.CreateRake(PVZ.MousePointer.Row, PVZ.MousePointer.Column)
                            ElseIf CardType = 55 Then
                                PVZ.CreateGrave(PVZ.MousePointer.Row, PVZ.MousePointer.Column)
                            ElseIf CardType = 56 Then
                                PVZ.CreateCrater(PVZ.MousePointer.Row, PVZ.MousePointer.Column, 18000)



                            End If

                            PlantsPlanted += 1

                        Catch
                            '鼠标位置异常
                        End Try

                        PlantDeltaTime.Enabled = True

                    End If

                '一次性铲子
                Case 2
                    PVZ.MousePointer.Index = -1
                    PVZ.MousePointer.ImitativeCardType = 0
                    PVZ.MousePointer.CardType = -1
                    PVZ.MousePointer.Type = PVZ.MouseType.Shovel
                    CreateSound(75)

                '倍速（热键）
                Case 3
                    If SpeedUp.Checked = False Then
                        SpeedUp.Checked = True
                    Else
                        SpeedUp.Checked = False
                    End If

            End Select
        End If

        MyBase.WndProc(m) '循环监听消息

    End Sub
    '是否能种
    Private Sub PlantSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles PlantSwitch.CheckedChanged

        If PlantSwitch.Checked = True Then

            Plantable = True

            RegisterHotKey(Me.Handle.ToInt32, 1, 0, Plant_Key) '种植
            RegisterHotKey(Me.Handle.ToInt32, 2, 0, ShovelOnce_Key) '铲子
            RegisterHotKey(Me.Handle.ToInt32, 3, 0, SpeedUp_Key) '倍速

            '第三个参数意义
            '0=nothing 1 -alt 2-ctrl 3-ctrl+alt 4-shift 5-alt+shift 6-ctrl+shift 7-ctrl+shift+alt
        Else

            For i = 0 To 3
                UnregisterHotKey(Handle, i)
            Next

            Plantable = False

        End If
    End Sub



#End Region

#Region "植物卡"

    '植物卡
    Private Sub Card1_Click(sender As Object, e As EventArgs) Handles Card1.Click
        CardType = PlantType.Peashooter
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "豌豆射手"
        Selected.Location = Card1.Location + YPlusUp
    End Sub

    Private Sub Card2_Click(sender As Object, e As EventArgs) Handles Card2.Click
        CardType = PlantType.Sunflower
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "向日葵"
        Selected.Location = Card2.Location + YPlusUp
    End Sub

    Private Sub Card3_Click(sender As Object, e As EventArgs) Handles Card3.Click
        CardType = PlantType.CherryBomb
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "樱桃炸弹"
        Selected.Location = Card3.Location + YPlusUp
    End Sub


    Private Sub Card4_Click(sender As Object, e As EventArgs) Handles Card4.Click
        CardType = PlantType.Wallnut
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "坚果墙"
        Selected.Location = Card4.Location + YPlusUp
    End Sub

    Private Sub Card5_Click(sender As Object, e As EventArgs) Handles Card5.Click
        CardType = PlantType.PotatoMine
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "土豆雷"
        Selected.Location = Card5.Location + YPlusUp
    End Sub

    Private Sub Card6_Click(sender As Object, e As EventArgs) Handles Card6.Click
        CardType = PlantType.SnowPea
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "寒冰射手"
        Selected.Location = Card6.Location + YPlusUp
    End Sub

    Private Sub Card7_Click(sender As Object, e As EventArgs) Handles Card7.Click
        CardType = PlantType.Chomper
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "大嘴花"
        Selected.Location = Card7.Location + YPlusUp
    End Sub

    Private Sub Card8_Click(sender As Object, e As EventArgs) Handles Card8.Click
        CardType = PlantType.Repeater
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "双发射手"
        Selected.Location = Card8.Location + YPlusUp
    End Sub

    Private Sub Card9_Click(sender As Object, e As EventArgs) Handles Card9.Click
        CardType = PlantType.Puffshroom
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "小喷菇"
        Selected.Location = Card9.Location + YPlusUp
    End Sub

    Private Sub Card10_Click(sender As Object, e As EventArgs) Handles Card10.Click
        CardType = PlantType.Sunshroom
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "阳光菇"
        Selected.Location = Card10.Location + YPlusUp
    End Sub

    Private Sub Card11_Click(sender As Object, e As EventArgs) Handles Card11.Click
        CardType = PlantType.Fumeshroom
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "大喷菇"
        Selected.Location = Card11.Location + YPlusUp
    End Sub

    Private Sub Card12_Click(sender As Object, e As EventArgs) Handles Card12.Click
        CardType = PlantType.GraveBuster
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "墓碑吞噬者"
        Selected.Location = Card12.Location + YPlusUp
    End Sub

    Private Sub Card13_Click(sender As Object, e As EventArgs) Handles Card13.Click
        CardType = PlantType.Hypnoshroom
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "魅惑菇"
        Selected.Location = Card13.Location + YPlusUp
    End Sub

    Private Sub Card14_Click(sender As Object, e As EventArgs) Handles Card14.Click
        CardType = PlantType.Scaredyshroom
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "胆小菇"
        Selected.Location = Card14.Location + YPlusUp
    End Sub

    Private Sub Card15_Click(sender As Object, e As EventArgs) Handles Card15.Click
        CardType = PlantType.Iceshroom
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "寒冰菇"
        Selected.Location = Card15.Location + YPlusUp
    End Sub

    Private Sub Card16_Click(sender As Object, e As EventArgs) Handles Card16.Click
        CardType = PlantType.Doomshroom
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "毁灭菇"
        Selected.Location = Card16.Location + YPlusUp
    End Sub

    Private Sub Card17_Click(sender As Object, e As EventArgs) Handles Card17.Click
        CardType = PlantType.LilyPad
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "睡莲"
        Selected.Location = Card17.Location + YPlusUp
    End Sub

    Private Sub Card18_Click(sender As Object, e As EventArgs) Handles Card18.Click
        CardType = PlantType.Squash
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "窝瓜"
        Selected.Location = Card18.Location + YPlusUp
    End Sub

    Private Sub Card19_Click(sender As Object, e As EventArgs) Handles Card19.Click
        CardType = PlantType.Threepeater
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "三线射手"
        Selected.Location = Card19.Location + YPlusUp
    End Sub

    Private Sub Card20_Click(sender As Object, e As EventArgs) Handles Card20.Click
        CardType = PlantType.TangleKelp
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "缠绕海草"
        Selected.Location = Card20.Location + YPlusUp
    End Sub

    Private Sub Card21_Click(sender As Object, e As EventArgs) Handles Card21.Click
        CardType = PlantType.Jalapeno
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "火爆辣椒"
        Selected.Location = Card21.Location + YPlusUp
    End Sub

    Private Sub Card22_Click(sender As Object, e As EventArgs) Handles Card22.Click
        CardType = PlantType.Caltrop
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "地刺"
        Selected.Location = Card22.Location + YPlusUp
    End Sub

    Private Sub Card23_Click(sender As Object, e As EventArgs) Handles Card23.Click
        CardType = PlantType.Torchwood
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "火炬树桩"
        Selected.Location = Card23.Location + YPlusUp
    End Sub

    Private Sub Card24_Click(sender As Object, e As EventArgs) Handles Card24.Click
        CardType = PlantType.Tallnut
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "高坚果"
        Selected.Location = Card24.Location + YPlusUp
    End Sub

    Private Sub Card25_Click(sender As Object, e As EventArgs) Handles Card25.Click
        CardType = PlantType.Seashroom
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "海蘑菇"
        Selected.Location = Card25.Location + YPlusUp
    End Sub

    Private Sub Card26_Click(sender As Object, e As EventArgs) Handles Card26.Click
        CardType = PlantType.Plantern
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "路灯花"
        Selected.Location = Card26.Location + YPlusUp
    End Sub

    Private Sub Card27_Click(sender As Object, e As EventArgs) Handles Card27.Click
        CardType = PlantType.Cactus
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "仙人掌"
        Selected.Location = Card27.Location + YPlusUp
    End Sub

    Private Sub Card28_Click(sender As Object, e As EventArgs) Handles Card28.Click
        CardType = PlantType.Blover
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "三叶草"
        Selected.Location = Card28.Location + YPlusUp
    End Sub

    Private Sub Card29_Click(sender As Object, e As EventArgs) Handles Card29.Click
        CardType = PlantType.SplitPea
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "裂荚射手"
        Selected.Location = Card29.Location + YPlusUp
    End Sub

    Private Sub Card30_Click(sender As Object, e As EventArgs) Handles Card30.Click
        CardType = PlantType.Starfruit
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "杨桃"
        Selected.Location = Card30.Location + YPlusUp
    End Sub

    Private Sub Card31_Click(sender As Object, e As EventArgs) Handles Card31.Click
        CardType = PlantType.Pumpkin
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "南瓜头"
        Selected.Location = Card31.Location + YPlusUp
    End Sub

    Private Sub Card32_Click(sender As Object, e As EventArgs) Handles Card32.Click
        CardType = PlantType.Magnetshroom
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "磁力菇"
        Selected.Location = Card32.Location + YPlusUp
    End Sub

    Private Sub Card33_Click(sender As Object, e As EventArgs) Handles Card33.Click
        CardType = PlantType.Cabbagepult
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "卷心菜投手"
        Selected.Location = Card33.Location + YPlusUp
    End Sub

    Private Sub Card34_Click(sender As Object, e As EventArgs) Handles Card34.Click
        CardType = PlantType.Pot
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "花盆"
        Selected.Location = Card34.Location + YPlusUp
    End Sub

    Private Sub Card35_Click(sender As Object, e As EventArgs) Handles Card35.Click
        CardType = PlantType.Cornpult
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "玉米投手"
        Selected.Location = Card35.Location + YPlusUp
    End Sub

    Private Sub Card36_Click(sender As Object, e As EventArgs) Handles Card36.Click
        CardType = PlantType.CoffeeBean
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "咖啡豆"
        Selected.Location = Card36.Location + YPlusUp
    End Sub

    Private Sub Card37_Click(sender As Object, e As EventArgs) Handles Card37.Click
        CardType = PlantType.Garlic
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "大蒜"
        Selected.Location = Card37.Location + YPlusUp
    End Sub

    Private Sub Card38_Click(sender As Object, e As EventArgs) Handles Card38.Click
        CardType = PlantType.UmbrellaLeaf
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "叶子保护伞"
        Selected.Location = Card38.Location + YPlusUp
    End Sub

    Private Sub Card39_Click(sender As Object, e As EventArgs) Handles Card39.Click
        CardType = PlantType.Marigold
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "金盏花"
        Selected.Location = Card39.Location + YPlusUp
    End Sub

    Private Sub Card40_Click(sender As Object, e As EventArgs) Handles Card40.Click
        CardType = PlantType.Melonpult
        SelectedPlantName.ForeColor = Color.DarkGreen
        SelectedPlantName.Text = "西瓜投手"
        Selected.Location = Card40.Location + YPlusUp
    End Sub

    Private Sub Card41_Click(sender As Object, e As EventArgs) Handles Card41.Click
        CardType = PlantType.GatlingPea
        SelectedPlantName.ForeColor = Color.DarkSlateBlue
        SelectedPlantName.Text = "机枪射手"
        Selected.Location = Card41.Location + YPlusUp
    End Sub

    Private Sub Card42_Click(sender As Object, e As EventArgs) Handles Card42.Click
        CardType = PlantType.TwinSunflower
        SelectedPlantName.ForeColor = Color.DarkSlateBlue
        SelectedPlantName.Text = "双子向日葵"
        Selected.Location = Card42.Location + YPlusUp
    End Sub

    Private Sub Card43_Click(sender As Object, e As EventArgs) Handles Card43.Click
        CardType = PlantType.Gloomshroom
        SelectedPlantName.ForeColor = Color.DarkSlateBlue
        SelectedPlantName.Text = "忧郁菇"
        Selected.Location = Card43.Location + YPlusUp
    End Sub

    Private Sub Card44_Click(sender As Object, e As EventArgs) Handles Card44.Click
        CardType = PlantType.Cattail
        SelectedPlantName.ForeColor = Color.DarkSlateBlue
        SelectedPlantName.Text = "香蒲"
        Selected.Location = Card44.Location + YPlusUp
    End Sub

    Private Sub Card45_Click(sender As Object, e As EventArgs) Handles Card45.Click
        CardType = PlantType.WinterMelon
        SelectedPlantName.ForeColor = Color.DarkSlateBlue
        SelectedPlantName.Text = """冰""瓜"
        Selected.Location = Card45.Location + YPlusUp
    End Sub

    Private Sub Card46_Click(sender As Object, e As EventArgs) Handles Card46.Click
        CardType = PlantType.GoldMagnet
        SelectedPlantName.ForeColor = Color.DarkSlateBlue
        SelectedPlantName.Text = "吸金磁"
        Selected.Location = Card46.Location + YPlusUp
    End Sub

    Private Sub Card47_Click(sender As Object, e As EventArgs) Handles Card47.Click
        CardType = PlantType.Spikerock
        SelectedPlantName.ForeColor = Color.DarkSlateBlue
        SelectedPlantName.Text = "地刺王"
        Selected.Location = Card47.Location + YPlusUp
    End Sub

    Private Sub Card48_Click(sender As Object, e As EventArgs) Handles Card48.Click
        CardType = PlantType.CobCannon
        SelectedPlantName.ForeColor = Color.DarkSlateBlue
        SelectedPlantName.Text = "玉米加农炮"
        Selected.Location = Card48.Location + YPlusUp
    End Sub

    Private Sub Card49_Click(sender As Object, e As EventArgs) Handles Card49.Click
        CardType = PlantType.Explodenut
        SelectedPlantName.ForeColor = Color.IndianRed
        SelectedPlantName.Text = "爆炸坚果"
        Selected.Location = Card49.Location + YPlusUp
    End Sub

    Private Sub Card50_Click(sender As Object, e As EventArgs) Handles Card50.Click
        CardType = PlantType.GiantWallnut
        SelectedPlantName.ForeColor = Color.IndianRed
        SelectedPlantName.Text = "巨型坚果"
        Selected.Location = Card50.Location + YPlusUp
    End Sub

    Private Sub Card51_Click(sender As Object, e As EventArgs) Handles Card51.Click
        CardType = PlantType.Sprout
        SelectedPlantName.ForeColor = Color.IndianRed
        SelectedPlantName.Text = "芽"
        Selected.Location = Card51.Location + YPlusUp
    End Sub

    Private Sub Card52_Click(sender As Object, e As EventArgs) Handles Card52.Click
        CardType = PlantType.LeftRepeater
        SelectedPlantName.ForeColor = Color.IndianRed
        SelectedPlantName.Text = "左向双发射手"
        Selected.Location = Card52.Location + YPlusUp
    End Sub

    Private Sub Card53_Click(sender As Object, e As EventArgs) Handles Card53.Click
        CardType = 53
        SelectedPlantName.ForeColor = Color.IndianRed
        SelectedPlantName.Text = "梯子"
        Selected.Location = Card53.Location + YPlusUp
    End Sub

    Private Sub Card54_Click(sender As Object, e As EventArgs) Handles Card54.Click
        CardType = 54
        SelectedPlantName.ForeColor = Color.IndianRed
        SelectedPlantName.Text = "草耙"
        Selected.Location = Card54.Location + YPlusUp
    End Sub

    Private Sub Card55_Click(sender As Object, e As EventArgs) Handles Card55.Click
        CardType = 55
        SelectedPlantName.ForeColor = Color.IndianRed
        SelectedPlantName.Text = "墓碑"
        Selected.Location = Card55.Location + YPlusUp
    End Sub

    Private Sub Card56_Click(sender As Object, e As EventArgs) Handles Card56.Click
        CardType = 56
        SelectedPlantName.ForeColor = Color.IndianRed
        SelectedPlantName.Text = "弹坑"
        Selected.Location = Card56.Location + YPlusUp
    End Sub

    '坐标种植
    Private Sub PlantXY_Click(sender As Object, e As EventArgs) Handles PlantXY.Click

        If CardType >= 0 And CardType <= 52 Then

            Dim plant As PVZ.Plant = CreatePlant(CardType, PlantX.SelectedIndex, PlantY.SelectedIndex)

            If RealPlants.Checked = False Then
                plant.Fix()
            End If
        ElseIf CardType = 53 Then
            PVZ.CreateLadder(PlantX.SelectedIndex, PlantY.SelectedIndex)
        ElseIf CardType = 54 Then
            PVZ.CreateRake(PlantX.SelectedIndex, PlantY.SelectedIndex)
        ElseIf CardType = 55 Then
            PVZ.CreateGrave(PlantX.SelectedIndex, PlantY.SelectedIndex)
        ElseIf CardType = 56 Then
            PVZ.CreateCrater(PlantX.SelectedIndex, PlantY.SelectedIndex, 18000)

        End If

    End Sub

#End Region

#Region "游戏内修改"

    '锁定玉米粒
    Private Sub LockKernel_CheckedChanged(sender As Object, e As EventArgs) Handles LockKernel.CheckedChanged
        If LockKernel.Checked Then
            PVZ.Memory.WriteByte(&H45F1EC, 235)
            LockButter.Enabled = False
            LockButter.Checked = False
        Else
            PVZ.Memory.WriteByte(&H45F1EC, 117)
            LockButter.Enabled = True
        End If
    End Sub

    '锁定黄油
    Private Sub LockButter_CheckedChanged(sender As Object, e As EventArgs) Handles LockButter.CheckedChanged
        If LockButter.Checked = True Then
            PVZ.Memory.WriteByte(&H45F1EC, 112)
            LockKernel.Enabled = False
            LockKernel.Checked = False
        Else
            PVZ.Memory.WriteByte(&H45F1EC, 117)
            LockKernel.Enabled = True
        End If
    End Sub

    '创建传送门
    Private Sub CreatePortalButton_Click(sender As Object, e As EventArgs) Handles CreatePortalButton.Click
        CreatePortal(PBAX.Text - 1, PBAY.Text, PBBX.Text - 1, PBBY.Text, PWAX.Text - 1, PWAY.Text, PWBX.Text - 1, PWBY.Text)
        FixPortal()
    End Sub
    '启动传送门
    Private Sub ActivePortal_CheckedChanged(sender As Object, e As EventArgs) Handles ActivePortal.CheckedChanged



        If ActivePortal.Checked Then
            PWAX.Enabled = True
            PWAY.Enabled = True
            PWBX.Enabled = True
            PWBY.Enabled = True
            PBAX.Enabled = True
            PBAY.Enabled = True
            PBBX.Enabled = True
            PBBY.Enabled = True
            CreatePortalButton.Enabled = True
            CreatePortalButton_Click(sender, e)
            EnablePortal(ActivePortal.Checked)
        Else
            PWAX.Enabled = False
            PWAY.Enabled = False
            PWBX.Enabled = False
            PWBY.Enabled = False
            PBAX.Enabled = False
            PBAY.Enabled = False
            PBBX.Enabled = False
            PBBY.Enabled = False

            For Each Por In PVZ.AllGriditems
                If Por.Type = 4 Or Por.Type = 5 Then
                    Por.Remove()
                End If
            Next


            EnablePortal(ActivePortal.Checked)
            CreatePortalButton.Enabled = False
        End If



    End Sub


    '植物行互换
    Private Sub SwitchRow_Click(sender As Object, e As EventArgs) Handles SwitchRow.Click
        If SwRow1.Text <> SwRow2.Text Then
            SwitchRowPlants(SwRow1.Text, SwRow2.Text)
        End If

    End Sub

    Private Sub SwitchCol_Click(sender As Object, e As EventArgs) Handles SwitchCol.Click
        If SwCol1.Text <> SwCol2.Text Then
            SwitchColPlants(SwCol1.Text, SwCol2.Text)
        End If

    End Sub

    '植物行互换功能实现
    Public Sub SwitchRowPlants(RowA As Integer, RowB As Integer)

        For Each pcol In AllPlants

            If pcol.Row = RowA - 1 Then '将A行植物移动到第七行
                pcol.Row = 6 '纵坐标第7行
                pcol.Y = 1000  'Y坐标1000

            End If

            If pcol.Row = RowB - 1 Then
                pcol.Row = RowA - 1
                pcol.Y = 80 + (RowA - 1) * 100

            End If

            If pcol.Y = 1000 Then
                pcol.Row = RowB - 1
                pcol.Y = 80 + (RowB - 1) * 100

            End If

        Next

    End Sub

    '植物列互换函数
    Public Sub SwitchColPlants(ColA As Integer, ColB As Integer)

        For Each pcol In AllPlants

            If pcol.Column = ColA - 1 Then '将A列植物移动到第十一列
                pcol.Column = 10 '纵坐标第11行
                pcol.X = 1000  'X坐标1000

            End If

            If pcol.Column = ColB - 1 Then
                pcol.Column = ColA - 1
                pcol.X = 40 + (ColA - 1) * 80

            End If

            If pcol.X = 1000 Then
                pcol.Column = ColB - 1
                pcol.X = 40 + (ColB - 1) * 80

            End If

        Next

    End Sub
#End Region

#End Region

#Region "Tab：预设"
    '打开创意工坊窗口
    Private Sub OpenWS_Click(sender As Object, e As EventArgs) Handles OpenWS.Click
        If Workshop.Visible = True Then
            MessageBox.Show("该窗口已打开！")

        Else Workshop.Show()
        End If
    End Sub

    '限制关卡ID输入
    Private Sub WSLevelID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WSLevelID.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or (e.KeyChar = Chr(8)) Or (e.KeyChar = Chr(13)))

        If e.KeyChar = Chr(13) Then
            DownloadWSLevel_Click(sender, e)
        End If
    End Sub

    '获取关卡下载并生成
    Private Sub DownloadWSLevel_Click(sender As Object, e As EventArgs) Handles DownloadWSLevel.Click

        Try

            If Not WSLevelID.Text = "" Then



                Dim getResourceDetail As ResourceDetailResponse = Api.GetResourceDetail(WSLevelID.Text, "BQUa7-AM1DRB8eJi6S3p-tlB7W4VVVxQ")

                Dim WSLevelCode As String = getResourceDetail.CustomFields("level")


                '接管

                Dim portal_code As String

                '去掉所有的空格
                WSLevelCode = WSLevelCode.Replace(" ", "")

                '有传送门吗

                Dim find_char As Integer = WSLevelCode.IndexOf("|")  '没找到为-1

                '有
                If find_char <> -1 AndAlso find_char < WSLevelCode.Length - 1 Then

                    '获取传送门代码
                    portal_code = GetPortalCode(WSLevelCode)

                    '删除传送门代码
                    WSLevelCode = RemoveSlash(WSLevelCode, find_char)

                Else portal_code = "" '没有传送门代码

                End If

                If LevelState = PVZ.GameState.Playing Then

                    Select Case StrToPla(WSLevelCode, portal_code)
                        Case 1
                            LevelStateinInformation.ForeColor = Color.Indigo
                            LevelStateinInformation.Text = "关卡已生成"
                            DeleteReset.Enabled = False
                            DeleteReset.Enabled = True
                        Case 2
                            LevelStateinInformation.ForeColor = Color.Red
                            LevelStateinInformation.Text = "错误的代码"
                            DeleteReset.Enabled = False
                            DeleteReset.Enabled = True
                        Case 3
                            LevelStateinInformation.ForeColor = Color.Red
                            LevelStateinInformation.Text = "代码异常"
                            DeleteReset.Enabled = False
                            DeleteReset.Enabled = True
                        Case 4
                            LevelStateinInformation.ForeColor = Color.Red
                            LevelStateinInformation.Text = "传送门错误"
                            DeleteReset.Enabled = False
                            DeleteReset.Enabled = True
                    End Select

                Else LevelStateinInformation.ForeColor = Color.Red
                    LevelStateinInformation.Text = "不在关卡中"
                    DeleteReset.Enabled = False
                    DeleteReset.Enabled = True

                End If


            End If

        Catch ex As Exception

            LevelStateinInformation.ForeColor = Color.Red
            LevelStateinInformation.Text = "获取失败"
            DeleteReset.Enabled = False
            DeleteReset.Enabled = True
            MessageBox.Show("关卡ID输入有误或网络连接失败", “无法获取关卡”, MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try




    End Sub


    '关卡分类切换时
    Private Sub LevelCollectionListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LevelCollectionListBox.SelectedIndexChanged
        Select Case LevelCollectionListBox.SelectedIndex

            Case 0 '新手
                CloseLevelInput()

                LevelListView.Items.Clear()

                LevelListView.BeginUpdate()


                For i = 1 To Levels_ForBeginners.Length

                    '创建关卡序号
                    If i <= 9 Then
                        LevelListView.Items.Add("00" + i.ToString)
                    ElseIf i >= 10 And i <= 99 Then
                        LevelListView.Items.Add("0" + i.ToString)
                    ElseIf i > 99 Then
                        LevelListView.Items.Add(i.ToString)
                    End If
                Next

                For i = 0 To Levels_ForBeginners.Length - 1 '=11
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_ForBeginners(i), 1))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_ForBeginners(i), 2))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_ForBeginners(i), 3))
                Next


                LevelListView.EndUpdate()

                SaveYourLevel.Text = "保存"

            Case 1 '雪线
                CloseLevelInput()

                LevelListView.Items.Clear()

                LevelListView.BeginUpdate()


                For i = 1 To Levels_Winkle.Length

                    '创建关卡序号
                    If i <= 9 Then
                        LevelListView.Items.Add("00" + i.ToString)
                    ElseIf i >= 10 And i <= 99 Then
                        LevelListView.Items.Add("0" + i.ToString)
                    ElseIf i > 99 Then
                        LevelListView.Items.Add(i.ToString)
                    End If
                Next

                For i = 0 To Levels_Winkle.Length - 1 '=11
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Winkle(i), 1))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Winkle(i), 2))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Winkle(i), 3))
                Next


                LevelListView.EndUpdate()

                SaveYourLevel.Text = "保存"

            Case 2 '控磁
                CloseLevelInput()

                LevelListView.Items.Clear()

                LevelListView.BeginUpdate()

                For i = 1 To Levels_Magnet.Length

                    '创建关卡序号
                    If i <= 9 Then
                        LevelListView.Items.Add("00" + i.ToString)
                    ElseIf i >= 10 And i <= 99 Then
                        LevelListView.Items.Add("0" + i.ToString)
                    ElseIf i > 99 Then
                        LevelListView.Items.Add(i.ToString)
                    End If
                Next

                For i = 0 To Levels_Magnet.Length - 1
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Magnet(i), 1))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Magnet(i), 2))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Magnet(i), 3))
                Next

                LevelListView.EndUpdate()

                SaveYourLevel.Text = "保存"

            Case 3 '残局
                CloseLevelInput()

                LevelListView.Items.Clear()

                LevelListView.BeginUpdate()

                For i = 1 To Levels_NotFull.Length

                    '创建关卡序号
                    If i <= 9 Then
                        LevelListView.Items.Add("00" + i.ToString)
                    ElseIf i >= 10 And i <= 99 Then
                        LevelListView.Items.Add("0" + i.ToString)
                    ElseIf i > 99 Then
                        LevelListView.Items.Add(i.ToString)
                    End If
                Next

                For i = 0 To Levels_NotFull.Length - 1
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_NotFull(i), 1))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_NotFull(i), 2))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_NotFull(i), 3))
                Next

                LevelListView.EndUpdate()

                SaveYourLevel.Text = "保存"

            Case 4 '奇妙冒险
                CloseLevelInput()

                LevelListView.Items.Clear()

                LevelListView.BeginUpdate()


                For i = 1 To Levels_Adventure.Length

                    '创建关卡序号
                    If i <= 9 Then
                        LevelListView.Items.Add("00" + i.ToString)
                    ElseIf i >= 10 And i <= 99 Then
                        LevelListView.Items.Add("0" + i.ToString)
                    ElseIf i > 99 Then
                        LevelListView.Items.Add(i.ToString)
                    End If
                Next

                For i = 0 To Levels_Adventure.Length - 1
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Adventure(i), 1))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Adventure(i), 2))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Adventure(i), 3))
                Next

                LevelListView.EndUpdate()

                SaveYourLevel.Text = "保存"

            Case 5 '大展宏图
                CloseLevelInput()

                LevelListView.Items.Clear()

                LevelListView.BeginUpdate()

                For i = 1 To Levels_OutOfRange.Length

                    '创建关卡序号
                    If i <= 9 Then
                        LevelListView.Items.Add("00" + i.ToString)
                    ElseIf i >= 10 And i <= 99 Then
                        LevelListView.Items.Add("0" + i.ToString)
                    ElseIf i > 99 Then
                        LevelListView.Items.Add(i.ToString)
                    End If
                Next

                For i = 0 To Levels_OutOfRange.Length - 1
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_OutOfRange(i), 1))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_OutOfRange(i), 2))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_OutOfRange(i), 3))
                Next

                LevelListView.EndUpdate()

                SaveYourLevel.Text = "保存"
'新增
            Case 6 '保护传送门

                CloseLevelInput()

                LevelListView.Items.Clear()

                LevelListView.BeginUpdate()

                For i = 1 To Levels_Portal.Length

                    '创建关卡序号
                    If i <= 9 Then
                        LevelListView.Items.Add("00" + i.ToString)
                    ElseIf i >= 10 And i <= 99 Then
                        LevelListView.Items.Add("0" + i.ToString)
                    ElseIf i > 99 Then
                        LevelListView.Items.Add(i.ToString)
                    End If
                Next

                For i = 0 To Levels_Portal.Length - 1
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Portal(i), 1))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Portal(i), 2))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Portal(i), 3))
                Next

                LevelListView.EndUpdate()

                SaveYourLevel.Text = "保存"

            Case 7 '比赛用图

                CloseLevelInput()

                LevelListView.Items.Clear()

                LevelListView.BeginUpdate()

                For i = 1 To Levels_Competition.Length

                    '创建关卡序号
                    If i <= 9 Then
                        LevelListView.Items.Add("00" + i.ToString)
                    ElseIf i >= 10 And i <= 99 Then
                        LevelListView.Items.Add("0" + i.ToString)
                    ElseIf i > 99 Then
                        LevelListView.Items.Add(i.ToString)
                    End If
                Next

                For i = 0 To Levels_Competition.Length - 1
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Competition(i), 1))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Competition(i), 2))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_Competition(i), 3))
                Next

                LevelListView.EndUpdate()

                SaveYourLevel.Text = "保存"

            Case 8 'IZE

                CloseLevelInput()

                LevelListView.Items.Clear()

                LevelListView.BeginUpdate()

                For i = 1 To Levels_IZECollections.Length

                    '创建关卡序号
                    If i <= 9 Then
                        LevelListView.Items.Add("00" + i.ToString)
                    ElseIf i >= 10 And i <= 99 Then
                        LevelListView.Items.Add("0" + i.ToString)
                    ElseIf i > 99 Then
                        LevelListView.Items.Add(i.ToString)
                    End If
                Next

                For i = 0 To Levels_IZECollections.Length - 1
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_IZECollections(i), 1))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_IZECollections(i), 2))
                    LevelListView.Items(i).SubItems.Add(ListLevelProCodeString(Levels_IZECollections(i), 3))
                Next

                LevelListView.EndUpdate()

                SaveYourLevel.Text = "保存"

            Case LevelCollectionListBox.Items.Count - 1   '我的关卡

                OpenLevelInput()

                LevelListView.Items.Clear()
                LevelListView.BeginUpdate()

                For LevelIndex = 1 To 100
                    If LevelIndex <= 9 Then
                        LevelListView.Items.Add("00" + LevelIndex.ToString)

                    ElseIf LevelIndex >= 10 And LevelIndex <= 99 Then
                        LevelListView.Items.Add("0" + LevelIndex.ToString)

                    ElseIf LevelIndex > 99 Then
                        LevelListView.Items.Add(LevelIndex.ToString)
                    End If
                Next

                For LevelIndex = 0 To 99

                    LevelListView.Items(LevelIndex).SubItems.Add(ListLevelProCodeString(MyLevelCollection(LevelIndex), 1))
                    LevelListView.Items(LevelIndex).SubItems.Add(ListLevelProCodeString(MyLevelCollection(LevelIndex), 2))
                    LevelListView.Items(LevelIndex).SubItems.Add(ListLevelProCodeString(MyLevelCollection(LevelIndex), 3))

                Next


                LevelListView.EndUpdate()

        End Select
    End Sub

    '选择预设关卡时，关闭修改按钮
    Private Sub CloseLevelInput()
        YourLevelName.ReadOnly = True
        YourName.ReadOnly = True

        CBLevelDifficulty.Enabled = False
        YourLevelDescription.ReadOnly = True
        YourLevelCode.ReadOnly = True
        SaveYourLevel.Enabled = False
        ResetYourLevel.Enabled = False
        ResetYourLevel.Visible = True
        ResetYourLevel_ConfirmT.Visible = False
        ResetYourLevel_ConfirmF.Visible = False
    End Sub
    '开启修改按钮
    Private Sub OpenLevelInput()
        YourLevelName.ReadOnly = False
        YourName.ReadOnly = False
        CBLevelDifficulty.Enabled = True
        YourLevelDescription.ReadOnly = False
        YourLevelCode.ReadOnly = False
        SaveYourLevel.Enabled = True
        ResetYourLevel.Enabled = True
    End Sub

    '切割Pro代码
    Private Function ListLevelProCodeString(ModifiedCode As String, Index As Integer) As String

        Dim LevelCodeProSplit() As String
        '0 Code 1 Name 2 Designer 3 Difficulty 4 Annotation

        LevelCodeProSplit = ModifiedCode.Split("\")

        '如果注释中含有\符号，要合并内容
        If LevelCodeProSplit.Length > 5 Then
            For MyString = 5 To LevelCodeProSplit.Length - 1
                LevelCodeProSplit(4) = LevelCodeProSplit(4) + "\" & LevelCodeProSplit(MyString)
            Next
        End If


        Return LevelCodeProSplit(Index)

    End Function

    Private Sub LevelListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LevelListView.SelectedIndexChanged
        If LevelListView.SelectedItems.Count > 0 Then

            '生成关卡信息文字

            Select Case LevelCollectionListBox.SelectedIndex

                Case 0 '新手
                    YourLevelCode.Text = ListLevelProCodeString(Levels_ForBeginners(LevelListView.SelectedItems(0).Index), 0)
                    YourLevelName.Text = ListLevelProCodeString(Levels_ForBeginners(LevelListView.SelectedItems(0).Index), 1)
                    YourName.Text = ListLevelProCodeString(Levels_ForBeginners(LevelListView.SelectedItems(0).Index), 2)
                    CBLevelDifficulty.SelectedIndex = DifficultyToIndex(ListLevelProCodeString(Levels_ForBeginners(LevelListView.SelectedItems(0).Index), 3))
                    YourLevelDescription.Text = ListLevelProCodeString(Levels_ForBeginners(LevelListView.SelectedItems(0).Index), 4)

                Case 1 '雪线
                    YourLevelCode.Text = ListLevelProCodeString(Levels_Winkle(LevelListView.SelectedItems(0).Index), 0)
                    YourLevelName.Text = ListLevelProCodeString(Levels_Winkle(LevelListView.SelectedItems(0).Index), 1)
                    YourName.Text = ListLevelProCodeString(Levels_Winkle(LevelListView.SelectedItems(0).Index), 2)
                    CBLevelDifficulty.SelectedIndex = DifficultyToIndex(ListLevelProCodeString(Levels_Winkle(LevelListView.SelectedItems(0).Index), 3))
                    YourLevelDescription.Text = ListLevelProCodeString(Levels_Winkle(LevelListView.SelectedItems(0).Index), 4)

                Case 2 '控磁
                    YourLevelCode.Text = ListLevelProCodeString(Levels_Magnet(LevelListView.SelectedItems(0).Index), 0)
                    YourLevelName.Text = ListLevelProCodeString(Levels_Magnet(LevelListView.SelectedItems(0).Index), 1)
                    YourName.Text = ListLevelProCodeString(Levels_Magnet(LevelListView.SelectedItems(0).Index), 2)
                    CBLevelDifficulty.SelectedIndex = DifficultyToIndex(ListLevelProCodeString(Levels_Magnet(LevelListView.SelectedItems(0).Index), 3))
                    YourLevelDescription.Text = ListLevelProCodeString(Levels_Magnet(LevelListView.SelectedItems(0).Index), 4)

                Case 3 '残局
                    YourLevelCode.Text = ListLevelProCodeString(Levels_NotFull(LevelListView.SelectedItems(0).Index), 0)
                    YourLevelName.Text = ListLevelProCodeString(Levels_NotFull(LevelListView.SelectedItems(0).Index), 1)
                    YourName.Text = ListLevelProCodeString(Levels_NotFull(LevelListView.SelectedItems(0).Index), 2)
                    CBLevelDifficulty.SelectedIndex = DifficultyToIndex(ListLevelProCodeString(Levels_NotFull(LevelListView.SelectedItems(0).Index), 3))
                    YourLevelDescription.Text = ListLevelProCodeString(Levels_NotFull(LevelListView.SelectedItems(0).Index), 4)

                Case 4 '奇妙冒险
                    YourLevelCode.Text = ListLevelProCodeString(Levels_Adventure(LevelListView.SelectedItems(0).Index), 0)
                    YourLevelName.Text = ListLevelProCodeString(Levels_Adventure(LevelListView.SelectedItems(0).Index), 1)
                    YourName.Text = ListLevelProCodeString(Levels_Adventure(LevelListView.SelectedItems(0).Index), 2)
                    CBLevelDifficulty.SelectedIndex = DifficultyToIndex(ListLevelProCodeString(Levels_Adventure(LevelListView.SelectedItems(0).Index), 3))
                    YourLevelDescription.Text = ListLevelProCodeString(Levels_Adventure(LevelListView.SelectedItems(0).Index), 4)

                Case 5 '大展宏图
                    YourLevelCode.Text = ListLevelProCodeString(Levels_OutOfRange(LevelListView.SelectedItems(0).Index), 0)
                    YourLevelName.Text = ListLevelProCodeString(Levels_OutOfRange(LevelListView.SelectedItems(0).Index), 1)
                    YourName.Text = ListLevelProCodeString(Levels_OutOfRange(LevelListView.SelectedItems(0).Index), 2)
                    CBLevelDifficulty.SelectedIndex = DifficultyToIndex(ListLevelProCodeString(Levels_OutOfRange(LevelListView.SelectedItems(0).Index), 3))
                    YourLevelDescription.Text = ListLevelProCodeString(Levels_OutOfRange(LevelListView.SelectedItems(0).Index), 4)

                Case 6 '传送门
                    YourLevelCode.Text = ListLevelProCodeString(Levels_Portal(LevelListView.SelectedItems(0).Index), 0)
                    YourLevelName.Text = ListLevelProCodeString(Levels_Portal(LevelListView.SelectedItems(0).Index), 1)
                    YourName.Text = ListLevelProCodeString(Levels_Portal(LevelListView.SelectedItems(0).Index), 2)
                    CBLevelDifficulty.SelectedIndex = DifficultyToIndex(ListLevelProCodeString(Levels_Portal(LevelListView.SelectedItems(0).Index), 3))
                    YourLevelDescription.Text = ListLevelProCodeString(Levels_Portal(LevelListView.SelectedItems(0).Index), 4)

                Case 7 '比赛用图
                    YourLevelCode.Text = ListLevelProCodeString(Levels_Competition(LevelListView.SelectedItems(0).Index), 0)
                    YourLevelName.Text = ListLevelProCodeString(Levels_Competition(LevelListView.SelectedItems(0).Index), 1)
                    YourName.Text = ListLevelProCodeString(Levels_Competition(LevelListView.SelectedItems(0).Index), 2)
                    CBLevelDifficulty.SelectedIndex = DifficultyToIndex(ListLevelProCodeString(Levels_Competition(LevelListView.SelectedItems(0).Index), 3))
                    YourLevelDescription.Text = ListLevelProCodeString(Levels_Competition(LevelListView.SelectedItems(0).Index), 4)

                Case 8 'IZE
                    YourLevelCode.Text = ListLevelProCodeString(Levels_IZECollections(LevelListView.SelectedItems(0).Index), 0)
                    YourLevelName.Text = ListLevelProCodeString(Levels_IZECollections(LevelListView.SelectedItems(0).Index), 1)
                    YourName.Text = ListLevelProCodeString(Levels_IZECollections(LevelListView.SelectedItems(0).Index), 2)
                    CBLevelDifficulty.SelectedIndex = DifficultyToIndex(ListLevelProCodeString(Levels_IZECollections(LevelListView.SelectedItems(0).Index), 3))
                    YourLevelDescription.Text = ListLevelProCodeString(Levels_IZECollections(LevelListView.SelectedItems(0).Index), 4)


                Case LevelCollectionListBox.Items.Count - 1   '我的关卡
                    YourLevelCode.Text = ListLevelProCodeString(MyLevelCollection(LevelListView.SelectedItems(0).Index), 0)
                    YourLevelName.Text = ListLevelProCodeString(MyLevelCollection(LevelListView.SelectedItems(0).Index), 1)
                    YourName.Text = ListLevelProCodeString(MyLevelCollection(LevelListView.SelectedItems(0).Index), 2)
                    CBLevelDifficulty.SelectedIndex = DifficultyToIndex(ListLevelProCodeString(MyLevelCollection(LevelListView.SelectedItems(0).Index), 3))
                    YourLevelDescription.Text = ListLevelProCodeString(MyLevelCollection(LevelListView.SelectedItems(0).Index), 4)
            End Select


            If LevelListView.SelectedItems(0).Index < 100 And LevelCollectionListBox.SelectedIndex = LevelCollectionListBox.Items.Count - 1 Then

                If MyLevelCollection(LevelListView.SelectedItems(0).Index) = "\\\\" Then
                    SaveYourLevel.Text = "保存"
                Else SaveYourLevel.Text = "覆盖"

                End If

            End If




            ResetYourLevel.Visible = True
            ResetYourLevel_ConfirmT.Visible = False
            ResetYourLevel_ConfirmF.Visible = False

        End If
    End Sub


    Private Function DifficultyToIndex(DifficultyString As String) As Integer
        Select Case DifficultyString
            Case "1"
                Return 0
            Case "2"
                Return 1
            Case "3"
                Return 2
            Case "4"
                Return 3
            Case "5"
                Return 4
            Case "6"
                Return 5
            Case "7"
                Return 6
            Case "8"
                Return 7
            Case "9"
                Return 8
            Case "10"
                Return 9
            Case "10+"
                Return 10
            Case Else
                Return -1
        End Select
    End Function

    Private Function IndexToDifficulty(Index As Integer) As String
        Select Case Index
            Case 0
                Return "1"
            Case 1
                Return "2"
            Case 2
                Return "3"
            Case 3
                Return "4"
            Case 4
                Return "5"
            Case 5
                Return "6"
            Case 6
                Return "7"
            Case 7
                Return "8"
            Case 8
                Return "9"
            Case 9
                Return "10"
            Case 10
                Return "10+"
            Case -1
                Return ""
            Case Else
                Return Nothing
        End Select
    End Function


    Private Sub SaveYourLevel_Click(sender As Object, e As EventArgs) Handles SaveYourLevel.Click


        If LevelListView.SelectedItems.Count > 0 Then

            Dim code As String = YourLevelCode.Text

            code = code.Replace(" ", "")

            Dim YourLevelProCode As String = code + "\" + YourLevelName.Text + "\" + YourName.Text + "\" + IndexToDifficulty(CBLevelDifficulty.SelectedIndex) + "\" + YourLevelDescription.Text

            MyLevelCollection(LevelListView.SelectedItems(0).Index) = YourLevelProCode

            SaveSetting("IZ_Format_Designer_V2", "MyLevelCollection", "MyLevel(" + LevelListView.SelectedItems(0).Index.ToString + ")", YourLevelProCode)

            LevelListView.Items(LevelListView.SelectedItems(0).Index).SubItems(1).Text = YourLevelName.Text

            LevelListView.Items(LevelListView.SelectedItems(0).Index).SubItems(2).Text = YourName.Text

            LevelListView.Items(LevelListView.SelectedItems(0).Index).SubItems(3).Text = IndexToDifficulty(CBLevelDifficulty.SelectedIndex)

            If MyLevelCollection(LevelListView.SelectedItems(0).Index) = "\\\\" Then
                SaveYourLevel.Text = "保存"
            Else SaveYourLevel.Text = "覆盖"
            End If

            LevelStateinInformation.ForeColor = Color.Indigo
            LevelStateinInformation.Text = "已保存"
            DeleteReset.Enabled = False
            DeleteReset.Enabled = True



        End If

    End Sub

    '传送门坐标膨胀（生成关卡用）
    Private Function P4to8(w1 As Integer, w2 As Integer, b1 As Integer, b2 As Integer) As Integer()

        Dim size As Integer = 11

        Dim p8() As Integer = {0, 0, 0, 0, 0, 0, 0, 0}

        p8(0) = w1 Mod size

        '锁定最大行数
        If p8(0) > 7 Then
            p8(0) = 7
        End If

        p8(1) = w1 \ size
        '锁定最大列数
        If p8(1) > 10 Then
            p8(1) = 10
        End If

        p8(2) = w2 Mod size
        If p8(2) > 7 Then
            p8(2) = 7
        End If

        p8(3) = w2 \ size
        If p8(3) > 10 Then
            p8(3) = 10
        End If

        p8(4) = b1 Mod size
        If p8(4) > 7 Then
            p8(4) = 7
        End If

        p8(5) = b1 \ size
        If p8(5) > 10 Then
            p8(5) = 10
        End If

        p8(6) = b2 Mod size
        If p8(6) > 7 Then
            p8(6) = 7
        End If

        p8(7) = b2 \ size
        If p8(7) > 10 Then
            p8(7) = 10
        End If

        Return p8

    End Function

    '读取传送门代码
    Public Function GetPortalCode(code As String) As String

        '拆分

        Dim sepIndex As Integer

        Dim separator As String = "\"

        sepIndex = code.IndexOf(separator)

        If sepIndex <> -1 And sepIndex < code.Length - 1 Then

            code = code.Substring(sepIndex + 1)

        End If

        Return code



    End Function


    '删除斜杠后内容
    Public Function RemoveSlash(text As String, position As Integer) As String

        text = text.Remove(position)

        Return text

    End Function

    '删除关卡
    Private Sub ResetYourLevel_Click(sender As Object, e As EventArgs) Handles ResetYourLevel.Click

        If LevelListView.SelectedItems.Count > 0 Then



            LevelStateinInformation.ForeColor = Color.Indigo
            LevelStateinInformation.Text = "删除？"

            ResetYourLevel.Visible = False

            ResetYourLevel_ConfirmT.Visible = True

            ResetYourLevel_ConfirmF.Visible = True

            DeleteReset.Enabled = False
            DeleteReset.Enabled = True

        End If

    End Sub
    '复制关卡代码
    Private Sub CopyYourLevelInfo_Click(sender As Object, e As EventArgs) Handles CopyYourLevelInfo.Click

        Clipboard.SetText("◆关卡 " & vbCrLf & YourLevelName.Text & " / " + YourName.Text & " / " + CBLevelDifficulty.Text & vbCrLf & "◆简介 " & vbCrLf & YourLevelDescription.Text & vbCrLf & "◆代码 " & vbCrLf & YourLevelCode.Text & vbCrLf & "——————————————" & vbCrLf & "本关卡代码由""我是僵尸布阵器(2.2)""生成，请使用布阵器粘贴代码生成关卡！")
        LevelStateinInformation.ForeColor = Color.Indigo
        LevelStateinInformation.Text = "已复制"
        DeleteReset.Enabled = False
        DeleteReset.Enabled = True
    End Sub

    '生成关卡
    Private Sub GenerateThisLevel_Click(sender As Object, e As EventArgs) Handles GenerateThisLevel.Click

        Dim code As String = YourLevelCode.Text

        Dim portal_code As String

        '去掉所有的空格
        code = code.Replace(" ", "")

        '有传送门吗

        Dim find_char As Integer = code.IndexOf("|")  '没找到为-1

        '有
        If find_char <> -1 AndAlso find_char < code.Length - 1 Then

            '获取传送门代码
            portal_code = GetPortalCode(code)

            '删除传送门代码
            code = RemoveSlash(code, find_char)

        Else portal_code = "" '没有传送门代码

        End If

        If LevelState = PVZ.GameState.Playing Then

            Select Case StrToPla(code, portal_code)
                Case 1
                    LevelStateinInformation.ForeColor = Color.Indigo
                    LevelStateinInformation.Text = "关卡已生成"
                    DeleteReset.Enabled = False
                    DeleteReset.Enabled = True
                Case 2
                    LevelStateinInformation.ForeColor = Color.Red
                    LevelStateinInformation.Text = "错误的代码"
                    DeleteReset.Enabled = False
                    DeleteReset.Enabled = True
                Case 3
                    LevelStateinInformation.ForeColor = Color.Red
                    LevelStateinInformation.Text = "代码异常"
                    DeleteReset.Enabled = False
                    DeleteReset.Enabled = True
                Case 4
                    LevelStateinInformation.ForeColor = Color.Red
                    LevelStateinInformation.Text = "传送门错误"
                    DeleteReset.Enabled = False
                    DeleteReset.Enabled = True
            End Select

        Else LevelStateinInformation.ForeColor = Color.Red
            LevelStateinInformation.Text = "不在关卡中"
            DeleteReset.Enabled = False
            DeleteReset.Enabled = True

        End If

    End Sub

    Private Sub ResetYourLevel_ConfirmT_Click(sender As Object, e As EventArgs) Handles ResetYourLevel_ConfirmT.Click
        If LevelListView.SelectedItems.Count > 0 Then

            MyLevelCollection(LevelListView.SelectedItems(0).Index) = "\\\\"

            SaveSetting("IZ_Format_Designer_V2", "MyLevelCollection", "MyLevel(" + LevelListView.SelectedItems(0).Index.ToString + ")", "\\\\")

            LevelListView.Items(LevelListView.SelectedItems(0).Index).SubItems(1).Text = ""

            LevelListView.Items(LevelListView.SelectedItems(0).Index).SubItems(2).Text = ""

            LevelListView.Items(LevelListView.SelectedItems(0).Index).SubItems(3).Text = ""

            YourLevelName.Text = ""

            YourName.Text = ""

            CBLevelDifficulty.SelectedIndex = -1

            YourLevelDescription.Text = ""

            YourLevelCode.Text = ""

            DeleteSetting("IZ_Format_Designer_V2", "MyLevelCollection", "MyLevel(" + LevelListView.SelectedItems(0).Index.ToString + ")")

            If MyLevelCollection(LevelListView.SelectedItems(0).Index) = "\\\\" Then
                SaveYourLevel.Text = "保存"
            Else SaveYourLevel.Text = "覆盖"
            End If


            ResetYourLevel.Visible = True
            ResetYourLevel_ConfirmT.Visible = False
            ResetYourLevel_ConfirmF.Visible = False
            LevelStateinInformation.Text = "已删除"

            DeleteReset.Enabled = False
            DeleteReset.Enabled = True


        End If
    End Sub

    Private Sub ResetYourLevel_ConfirmF_Click(sender As Object, e As EventArgs) Handles ResetYourLevel_ConfirmF.Click


        ResetYourLevel.Visible = True
        ResetYourLevel_ConfirmT.Visible = False
        ResetYourLevel_ConfirmF.Visible = False
        LevelStateinInformation.Text = "取消删除"

        DeleteReset.Enabled = False
        DeleteReset.Enabled = True

    End Sub

    Private Sub DeleteReset_Tick(sender As Object, e As EventArgs) Handles DeleteReset.Tick
        ResetYourLevel.Visible = True
        ResetYourLevel_ConfirmT.Visible = False
        ResetYourLevel_ConfirmF.Visible = False
        LevelStateinInformation.Text = ""
        DeleteReset.Enabled = False
    End Sub

    Private Sub CopyMyCode_Click(sender As Object, e As EventArgs) Handles CopyMyCode.Click
        Clipboard.SetData(DataFormats.Text, YourLevelCode.Text)
        LevelStateinInformation.Text = "已复制"

        DeleteReset.Enabled = False
        DeleteReset.Enabled = True
    End Sub


    Public yourScoreIZE As Integer


    Private Sub Randomizer_Click(sender As Object, e As EventArgs) Handles Randomizer.Click


        If RandomEndless.Checked = False Then

            If LevelState = PVZ.GameState.Playing Then



                '读取红线位置
                Dim RedLinePos As Integer = RedLineBar.Value
                If PVZ.LevelId >= 61 And PVZ.LevelId <= 65 Then '表示四列 基地址&H4253C7, 10 + 83 * 0，0表示列数
                    RedLinePos = (PVZ.Memory.ReadInteger(&H4253C7) - 10) / 83
                ElseIf (PVZ.LevelId >= 66 And PVZ.LevelId <= 68) Or PVZ.LevelId = 70 Then '表示五列 基地址&H4253F7
                    RedLinePos = (PVZ.Memory.ReadInteger(&H4253F7) - 10) / 83
                ElseIf PVZ.LevelId = 69 Then '表示六列 基地址&H425416
                    RedLinePos = (PVZ.Memory.ReadInteger(&H425416) - 10) / 83
                End If

                If RedLinePos = 0 Or RedLinePos = 9 Then
                    MessageBox.Show("无法创建关卡，请调整红线位置", "红线不得为0或9")
                Else

                    CreateEffect(81, 0, 0) '闪屏特效

                    '清空全部内容
                    AllClr()

                    Dim rand As New Random
                    Dim gridsun(4, RedLinePos - 1) As Boolean

                    '创建向日葵
                    Dim suns As Integer = 0
                    Do

                        Dim randsunrow As Integer = rand.Next(0, 4)
                        Dim randsuncol As Integer = rand.Next(0, RedLinePos - 1)

                        If gridsun(randsunrow, randsuncol) = False Then
                            CreatePlant(1, randsunrow, randsuncol).Fix()
                            gridsun(randsunrow, randsuncol) = True
                            suns += 1
                        End If

                    Loop Until suns = RedLinePos

                    '添加其他随机植物
                    Dim randplants() As Integer = {0, 1, 3, 4, 5, 6, 7, 8, 10, 12, 13, 17, 18, 21, 22, 23, 26, 28, 29, 31, 32, 34, 36, 37, 39, 40, 42, 43, 44, 46, 52}
                    Dim randplantype As Integer

                    For row As Integer = 0 To 4
                        For col As Integer = 0 To RedLinePos - 1

                            '检测该格是否已经有向日葵
                            If gridsun(row, col) = False Then

                                '随机数组中的植物类型序号
                                randplantype = rand.Next(0, randplants.Length)

                                '种植植物
                                CreatePlant(randplants(randplantype), row, col).Fix()

                            End If

                        Next
                    Next

                    '添加南瓜头
                    For row As Integer = 0 To 4
                        For col As Integer = 0 To RedLinePos - 1
                            Dim isPumpkin As Integer = rand.Next(1, 101)
                            If (isPumpkin <= 9) Then
                                CreatePlant(30, row, col).Fix()
                            End If
                        Next
                    Next

                    Dim initialsunset1() As Integer = {100, 125, 150}
                    Dim initialsunset2() As Integer = {150, 175, 200, 225, 250, 275, 300}
                    Dim initialsunset3() As Integer = {200, 250, 275, 300, 325, 350, 375, 400, 425, 450, 475, 500, 525, 550, 575, 600}
                    '调整初始阳光
                    If RedLinePos <= 3 Then
                        PVZ.Sun() = initialsunset1(rand.Next(0, 3))
                    ElseIf RedLinePos <= 6 Then
                        PVZ.Sun() = initialsunset2(rand.Next(0, initialsunset2.Length))
                    Else
                        PVZ.Sun() = initialsunset3(rand.Next(0, initialsunset3.Length))
                    End If

                    '调整初始阵容
                    If RedLinePos <= 3 Then
                        RandomZCardSlot(rand.Next(1, 5))
                    ElseIf RedLinePos <= 6 Then
                        RandomZCardSlot(rand.Next(5, 11))
                    Else
                        RandomZCardSlot(rand.Next(11, 17))
                    End If

                    LevelStateinInformation.ForeColor = Color.Indigo
                    LevelStateinInformation.Text = "关卡已生成"
                    DeleteReset.Enabled = False
                    DeleteReset.Enabled = True


                End If

            Else

                LevelStateinInformation.ForeColor = Color.Red
                LevelStateinInformation.Text = "不在关卡中"
                DeleteReset.Enabled = False
                DeleteReset.Enabled = True

            End If

            If AutoPaste.Checked = True Then
                Dim thisRandomcode As String = PlaToStr()
                EnterCode.Text = thisRandomcode
            End If

        Else '此后为开始IZE无尽模式 目前仅处于IZE才可开始

            If LevelState = PVZ.GameState.Playing And PVZ.LevelId = 70 Then


                Dim RedLinePosEL As Integer = (PVZ.Memory.ReadInteger(&H4253F7) - 10) / 83

                If RedLinePosEL = 0 Or RedLinePosEL = 9 Then

                    MessageBox.Show("无法开始无尽，请调整红线位置。请注意，在IZE开始过程中，无法再调整红线位置", "红线不得为0或9")

                Else


                    '重置系统得分
                    yourScoreIZE = 0
                    '禁用红线调整
                    RedLineBar.Enabled = False
                    '启动计时器
                    IZEStateChecker.Enabled = True

                    '调整初始阳光
                    If RedLinePosEL <= 3 Then
                        PVZ.Sun() = 300
                    ElseIf RedLinePosEL <= 6 Then
                        PVZ.Sun() = 500
                    Else
                        PVZ.Sun() = 600
                    End If

                End If


            Else

                MessageBox.Show("必须处于IZE模式中才可开始游戏！", “IZE随机已开启”)
                LevelStateinInformation.ForeColor = Color.Red
                LevelStateinInformation.Text = "不在IZE中"
                DeleteReset.Enabled = False
                DeleteReset.Enabled = True


            End If

        End If






    End Sub


    '计时器不断读取当前关卡
    Private Sub IZEStateChecker_Tick(sender As Object, e As EventArgs) Handles IZEStateChecker.Tick

        '持续读取当前关卡数字
        Dim levelnow As Integer = Memory.GetAddress(&H6A9EC0, &H768, &H160, &H6C)

        '初始 关卡0 计数器0

        '检测分数异常
        If Math.Abs(yourScoreIZE - levelnow) > 1 Then '非重新开始 读取关卡和实际关卡已出现差错 游戏结束

            RandIZEScore.Text = "请重新开始"

            RandomEndless.Checked = False

            MessageBox.Show("分数异常，请重新开始", "游戏已结束")

            LevelStateinInformation.ForeColor = Color.Red
            LevelStateinInformation.Text = "游戏已结束"
            DeleteReset.Enabled = False
            DeleteReset.Enabled = True

            Exit Sub
        End If


        '读取游戏已经结束


        If Memory.GetAddress(&H6A9EC0, &H888) = 2 Then
            RandIZEScore.Text = "请重新开始"

            RandomEndless.Checked = False

            MessageBox.Show("游戏结束", "游戏已结束")

            LevelStateinInformation.ForeColor = Color.Red
            LevelStateinInformation.Text = "游戏已结束"
            DeleteReset.Enabled = False
            DeleteReset.Enabled = True
            Exit Sub
        End If



        If levelnow = yourScoreIZE Then '得分已相等 可创建关卡

            '更新得分
            RandIZEScore.Text = "得分 " + yourScoreIZE.ToString


            '新关卡

            Dim ReadLineEL As Integer = (PVZ.Memory.ReadInteger(&H4253F7) - 10) / 83

            If ReadLineEL = 0 Or ReadLineEL = 9 Then '红线位置非法 游戏结束

                RandIZEScore.Text = "请重新开始"

                RandomEndless.Checked = False

                MessageBox.Show("红线位置异常，请重新开始", "游戏已结束")

                Exit Sub

            End If


            '执行一遍循环以创建关卡

            '清空全部内容
            AllClr()

            Dim rand As New Random

            Dim gridsun(4, ReadLineEL - 1) As Boolean

            '创建向日葵

            '关卡创建 读取是否为5的倍数
            If (levelnow + 1) Mod 5 = 0 Then '这是一个5倍数的奖励关卡
                Select Case levelnow + 1
                    Case 5 '第五关
                        If ReadLineEL <= 5 Then '红线小等6
                            For row As Integer = 0 To 4
                                For col As Integer = 0 To ReadLineEL - 1
                                    Dim whatPlant As Integer = rand.Next(1, 101)
                                    If whatPlant <= 50 Then
                                        CreatePlant(PlantType.Sunflower, row, col).Fix()
                                    ElseIf whatPlant <= 80 Then
                                        CreatePlant(PlantType.Scaredyshroom, row, col).Fix()
                                    Else CreatePlant(PlantType.Puffshroom, row, col).Fix() '100%-scare小喷
                                    End If
                                Next
                            Next
                        Else '红线7和8
                            For row As Integer = 0 To 4
                                For col As Integer = 0 To ReadLineEL - 1
                                    Dim whatPlant As Integer = rand.Next(1, 101)
                                    If whatPlant <= 30 Then
                                        CreatePlant(PlantType.Sunflower, row, col).Fix()
                                    ElseIf whatPlant <= 80 Then
                                        CreatePlant(PlantType.Scaredyshroom, row, col).Fix()
                                    Else CreatePlant(PlantType.Puffshroom, row, col).Fix() '100%-scare小喷
                                    End If
                                Next
                            Next
                        End If
                    Case 10 '第十关
                        If ReadLineEL <= 5 Then '红线小于6
                            For row As Integer = 0 To 4
                                For col As Integer = 0 To ReadLineEL - 1
                                    Dim whatPlant As Integer = rand.Next(1, 101)
                                    If whatPlant <= 40 Then
                                        CreatePlant(PlantType.Sunflower, row, col).Fix()
                                    ElseIf whatPlant <= 80 Then
                                        CreatePlant(PlantType.Scaredyshroom, row, col).Fix()
                                    Else CreatePlant(PlantType.Puffshroom, row, col).Fix() '100%-scare小喷
                                    End If
                                Next
                            Next
                        Else
                            For row As Integer = 0 To 4
                                For col As Integer = 0 To ReadLineEL - 1
                                    Dim whatPlant As Integer = rand.Next(1, 101)
                                    If whatPlant <= 25 Then
                                        CreatePlant(PlantType.Sunflower, row, col).Fix()
                                    ElseIf whatPlant <= 65 Then
                                        CreatePlant(PlantType.Scaredyshroom, row, col).Fix()
                                    Else CreatePlant(PlantType.Puffshroom, row, col).Fix() '100%-scare小喷
                                    End If
                                Next
                            Next
                        End If

                    Case 15 '第十五关
                        If ReadLineEL <= 5 Then '红线小于6
                            For row As Integer = 0 To 4
                                For col As Integer = 0 To ReadLineEL - 1
                                    Dim whatPlant As Integer = rand.Next(1, 101)
                                    If whatPlant <= 30 Then
                                        CreatePlant(PlantType.Sunflower, row, col).Fix()
                                    ElseIf whatPlant <= 70 Then
                                        CreatePlant(PlantType.Scaredyshroom, row, col).Fix()
                                    Else CreatePlant(PlantType.Puffshroom, row, col).Fix() '100%-scare小喷
                                    End If
                                Next
                            Next
                        Else
                            For row As Integer = 0 To 4
                                For col As Integer = 0 To ReadLineEL - 1
                                    Dim whatPlant As Integer = rand.Next(1, 101)
                                    If whatPlant <= 20 Then
                                        CreatePlant(PlantType.Sunflower, row, col).Fix()
                                    ElseIf whatPlant <= 60 Then
                                        CreatePlant(PlantType.Scaredyshroom, row, col).Fix()
                                    Else CreatePlant(PlantType.Puffshroom, row, col).Fix() '100%-scare小喷
                                    End If
                                Next
                            Next
                        End If

                    Case Else '第二十关及以上
                        If ReadLineEL <= 5 Then '红线小于6
                            For row As Integer = 0 To 4
                                For col As Integer = 0 To ReadLineEL - 1
                                    Dim whatPlant As Integer = rand.Next(1, 101)
                                    If whatPlant <= 20 Then
                                        CreatePlant(PlantType.Sunflower, row, col).Fix()
                                    ElseIf whatPlant <= 60 Then
                                        CreatePlant(PlantType.Scaredyshroom, row, col).Fix()
                                    Else CreatePlant(PlantType.Puffshroom, row, col).Fix() '100%-scare小喷
                                    End If
                                Next
                            Next
                        Else
                            For row As Integer = 0 To 4
                                For col As Integer = 0 To ReadLineEL - 1
                                    Dim whatPlant As Integer = rand.Next(1, 101)
                                    If whatPlant <= 15 Then
                                        CreatePlant(PlantType.Sunflower, row, col).Fix()
                                    ElseIf whatPlant <= 55 Then
                                        CreatePlant(PlantType.Scaredyshroom, row, col).Fix()
                                    Else CreatePlant(PlantType.Puffshroom, row, col).Fix() '100%-scare小喷
                                    End If
                                Next
                            Next
                        End If
                End Select



            Else '这不是一个5倍数的奖励关卡 按照标准随机关卡流程

                '定义花数
                Dim Line1Sun() As Integer = {2, 1}


                '花数计数器
                Dim suns As Integer = 0

                '确定本关花数
                Dim getSuns As Integer



                Select Case ReadLineEL '根据红线
                    Case 1

                        If levelnow + 1 <= 6 Then '根据关卡
                            getSuns = Line1Sun(0)
                        Else
                            getSuns = Line1Sun(1)
                        End If

                    Case 2, 3 '增幅系数1

                        '得到当前关卡是第几个3倍关卡
                        Dim levelindex As Integer = levelnow \ 3

                        getSuns = ReadLineEL + 1 - levelindex

                        If getSuns < 1 Then
                            getSuns = 1
                        End If

                    Case 4, 5, 6 '增幅系数2

                        '得到当前关卡是第几个3倍关卡
                        Dim levelindex As Integer = levelnow \ 3

                        getSuns = ReadLineEL + 2 - levelindex

                        If getSuns < 2 Then
                            getSuns = 2
                        End If

                    Case Else '增幅系数3

                        '得到当前关卡是第几个3倍关卡
                        Dim levelindex As Integer = levelnow \ 3

                        getSuns = ReadLineEL + 3 - levelindex

                        If getSuns < 3 Then
                            getSuns = 3
                        End If


                End Select

                '排除0
                If getSuns <> 0 Then
                    Do

                        Dim randsunrow As Integer = rand.Next(0, 4)
                        Dim randsuncol As Integer = rand.Next(0, ReadLineEL - 1)

                        If gridsun(randsunrow, randsuncol) = False Then
                            CreatePlant(1, randsunrow, randsuncol).Fix()
                            gridsun(randsunrow, randsuncol) = True
                            suns += 1
                        End If

                    Loop Until suns = getSuns
                End If

                '创建向日葵


                '添加其他随机植物
                Dim plantsAttack() As Integer = {0, 5, 7, 8, 10, 13, 18, 21, 26, 28, 29, 32, 34, 39, 52}
                Dim plantsDefense() As Integer = {3, 23, 36}
                Dim plantsSupport() As Integer = {4, 6, 12, 17, 22, 31, 36, 37}
                Dim plantsUltimate() As Integer = {40, 42, 43, 44, 46}

                Dim chosen() As String = {"ATK", "ATK", "ATK", "ATK", "SPT", "SPT", "DEF", "ULT"}

                Dim randplantype As Integer

                For row As Integer = 0 To 4
                    For col As Integer = 0 To ReadLineEL - 1

                        '检测该格是否已经有向日葵
                        If gridsun(row, col) = False Then

                            Dim randchoose As String = chosen(rand.Next(0, chosen.Length))

                            Select Case randchoose
                                Case "ATK"
                                    '随机数组中的植物类型序号
                                    randplantype = rand.Next(0, plantsAttack.Length)
                                    '种植植物
                                    CreatePlant(plantsAttack(randplantype), row, col).Fix()
                                Case "DEF"
                                    randplantype = rand.Next(0, plantsDefense.Length)
                                    CreatePlant(plantsDefense(randplantype), row, col).Fix()
                                Case "SPT"
                                    randplantype = rand.Next(0, plantsSupport.Length)
                                    CreatePlant(plantsSupport(randplantype), row, col).Fix()
                                Case "ULT"
                                    randplantype = rand.Next(0, plantsUltimate.Length)
                                    CreatePlant(plantsUltimate(randplantype), row, col).Fix()
                            End Select

                        End If

                    Next
                Next

                '添加南瓜头
                For row As Integer = 0 To 4
                    For col As Integer = 0 To ReadLineEL - 1
                        Dim isPumpkin As Integer = rand.Next(1, 101)
                        If (isPumpkin <= 6) Then
                            CreatePlant(30, row, col).Fix()
                        End If
                    Next
                Next

                '添加梯子 IZE独家
                For row As Integer = 0 To 4
                    For col As Integer = 0 To ReadLineEL - 1
                        Dim isLadder As Integer = rand.Next(1, 101)
                        If (isLadder <= 3) Then
                            CreateLadder(row, col)
                        End If
                    Next
                Next


            End If

            '调整初始阵容
            If ReadLineEL <= 5 Then
                RandomZCardSlot(rand.Next(5, 11))
            Else
                RandomZCardSlot(rand.Next(11, 17))
            End If

            '本关卡已生成完毕 结算关卡分数数值



            yourScoreIZE += 1

            LevelStateinInformation.ForeColor = Color.Indigo
            LevelStateinInformation.Text = "关卡 " + yourScoreIZE.ToString
            DeleteReset.Enabled = False
            DeleteReset.Enabled = True

            CreateCaption("Level " + yourScoreIZE.ToString, 6, 300)

            If AutoPaste.Checked = True Then
                Dim thisRandomcode As String = PlaToStr()
                EnterCode.Text = thisRandomcode
            End If

        End If

        'IZE阳光耗尽 游戏已结束

    End Sub
    Private Sub RandomEndless_CheckedChanged(sender As Object, e As EventArgs) Handles RandomEndless.CheckedChanged
        If RandomEndless.Checked = False Then
            IZEStateChecker.Enabled = False
            Randomizer.Text = "随机关卡"
            RedLineBar.Enabled = True
            RandIZEScore.Text = "得分 "
        Else
            Randomizer.Text = "重新开始"
        End If
    End Sub

    Public Function RandomZCardSlot(index As Integer)

        Select Case index
            Case 1 '鬼障杆
                PVZ.CardSlot.SetCardNum(4)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Imp
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.BungeeZombie

            Case 2 '僵障杆
                PVZ.CardSlot.SetCardNum(4)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Zombie
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.BungeeZombie
            Case 3 '鬼障杆桶
                PVZ.CardSlot.SetCardNum(5)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Imp
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.BucketheadZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.BungeeZombie
            Case 4 '鬼障杆蹦
                PVZ.CardSlot.SetCardNum(5)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Zombie
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.BungeeZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.LadderZombie

            Case 5 '标准八格
                PVZ.CardSlot.SetCardNum(8)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Imp
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.BucketheadZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.BungeeZombie
                PVZ.CardSlot.GetCard(5).CardType = PVZ.CardType.DiggerZombie
                PVZ.CardSlot.GetCard(6).CardType = PVZ.CardType.FootballZombie
                PVZ.CardSlot.GetCard(7).CardType = PVZ.CardType.DancingZombie
            Case 6
                PVZ.CardSlot.SetCardNum(8)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Imp
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.BucketheadZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.BungeeZombie
                PVZ.CardSlot.GetCard(5).CardType = PVZ.CardType.DiggerZombie
                PVZ.CardSlot.GetCard(6).CardType = PVZ.CardType.LadderZombie
                PVZ.CardSlot.GetCard(7).CardType = PVZ.CardType.FootballZombie
            Case 7 '无鬼有冰车
                PVZ.CardSlot.SetCardNum(8)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Zombie
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.ScreenDoorZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.BungeeZombie
                PVZ.CardSlot.GetCard(5).CardType = PVZ.CardType.DiggerZombie
                PVZ.CardSlot.GetCard(6).CardType = PVZ.CardType.FootballZombie
                PVZ.CardSlot.GetCard(7).CardType = PVZ.CardType.Zomboin
            Case 8 '无鬼有舞王
                PVZ.CardSlot.SetCardNum(8)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Zombie
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.ScreenDoorZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.BucketheadZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.BungeeZombie
                PVZ.CardSlot.GetCard(5).CardType = PVZ.CardType.LadderZombie
                PVZ.CardSlot.GetCard(6).CardType = PVZ.CardType.FootballZombie
                PVZ.CardSlot.GetCard(7).CardType = PVZ.CardType.DancingZombie

            Case 9 '鬼巨人
                PVZ.CardSlot.SetCardNum(8)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Imp
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.BucketheadZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.DiggerZombie
                PVZ.CardSlot.GetCard(5).CardType = PVZ.CardType.LadderZombie
                PVZ.CardSlot.GetCard(6).CardType = PVZ.CardType.FootballZombie
                PVZ.CardSlot.GetCard(7).CardType = PVZ.CardType.Gargantuar

            Case 10 '气球
                PVZ.CardSlot.SetCardNum(8)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Zombie
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.BucketheadZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.BungeeZombie
                PVZ.CardSlot.GetCard(5).CardType = PVZ.CardType.DiggerZombie
                PVZ.CardSlot.GetCard(6).CardType = PVZ.CardType.BalloonZombie
                PVZ.CardSlot.GetCard(7).CardType = PVZ.CardType.FootballZombie

            Case 11 '标准+门板
                PVZ.CardSlot.SetCardNum(10)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Imp
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.ScreenDoorZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.BucketheadZombie
                PVZ.CardSlot.GetCard(5).CardType = PVZ.CardType.BungeeZombie
                PVZ.CardSlot.GetCard(6).CardType = PVZ.CardType.DiggerZombie
                PVZ.CardSlot.GetCard(7).CardType = PVZ.CardType.LadderZombie
                PVZ.CardSlot.GetCard(8).CardType = PVZ.CardType.FootballZombie
                PVZ.CardSlot.GetCard(9).CardType = PVZ.CardType.DancingZombie

            Case 12 '气球
                PVZ.CardSlot.SetCardNum(10)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Imp
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.ScreenDoorZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.BungeeZombie
                PVZ.CardSlot.GetCard(5).CardType = PVZ.CardType.DiggerZombie
                PVZ.CardSlot.GetCard(6).CardType = PVZ.CardType.BalloonZombie
                PVZ.CardSlot.GetCard(7).CardType = PVZ.CardType.LadderZombie
                PVZ.CardSlot.GetCard(8).CardType = PVZ.CardType.FootballZombie
                PVZ.CardSlot.GetCard(9).CardType = PVZ.CardType.DancingZombie

            Case 13 '冰车
                PVZ.CardSlot.SetCardNum(10)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Imp
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.Zombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.BucketheadZombie
                PVZ.CardSlot.GetCard(5).CardType = PVZ.CardType.BungeeZombie
                PVZ.CardSlot.GetCard(6).CardType = PVZ.CardType.DiggerZombie
                PVZ.CardSlot.GetCard(7).CardType = PVZ.CardType.LadderZombie
                PVZ.CardSlot.GetCard(8).CardType = PVZ.CardType.FootballZombie
                PVZ.CardSlot.GetCard(9).CardType = PVZ.CardType.Zomboin

            Case 14 '巨人
                PVZ.CardSlot.SetCardNum(10)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Imp
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.BucketheadZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.BungeeZombie
                PVZ.CardSlot.GetCard(5).CardType = PVZ.CardType.DiggerZombie
                PVZ.CardSlot.GetCard(6).CardType = PVZ.CardType.LadderZombie
                PVZ.CardSlot.GetCard(7).CardType = PVZ.CardType.FootballZombie
                PVZ.CardSlot.GetCard(8).CardType = PVZ.CardType.Gargantuar
                PVZ.CardSlot.GetCard(9).CardType = PVZ.CardType.DancingZombie

            Case 15 '全家福
                PVZ.CardSlot.SetCardNum(10)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Imp
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.ScreenDoorZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.BungeeZombie
                PVZ.CardSlot.GetCard(5).CardType = PVZ.CardType.BalloonZombie
                PVZ.CardSlot.GetCard(6).CardType = PVZ.CardType.FootballZombie
                PVZ.CardSlot.GetCard(7).CardType = PVZ.CardType.Zomboin
                PVZ.CardSlot.GetCard(8).CardType = PVZ.CardType.Gargantuar
                PVZ.CardSlot.GetCard(9).CardType = PVZ.CardType.DancingZombie

            Case 16 '投石车
                PVZ.CardSlot.SetCardNum(10)
                PVZ.CardSlot.GetCard(0).CardType = PVZ.CardType.Imp
                PVZ.CardSlot.GetCard(1).CardType = PVZ.CardType.ConeheadZombie
                PVZ.CardSlot.GetCard(2).CardType = PVZ.CardType.PoleVaultingZombie
                PVZ.CardSlot.GetCard(3).CardType = PVZ.CardType.BucketheadZombie
                PVZ.CardSlot.GetCard(4).CardType = PVZ.CardType.BungeeZombie
                PVZ.CardSlot.GetCard(5).CardType = PVZ.CardType.DiggerZombie
                PVZ.CardSlot.GetCard(6).CardType = PVZ.CardType.LadderZombie
                PVZ.CardSlot.GetCard(7).CardType = PVZ.CardType.FootballZombie
                PVZ.CardSlot.GetCard(8).CardType = PVZ.CardType.Zomboin
                PVZ.CardSlot.GetCard(9).CardType = PVZ.CardType.Torchwood
            Case Else
                Return Nothing

        End Select

        Return Nothing

    End Function

#End Region

#Region "Tab：设置"

    '关闭磁铁倒计时
    Private Sub MagnetTimerSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles MagnetTimerSwitch.CheckedChanged
        If MagnetTimerSwitch.Checked = True Then
            FinderMagnet.Enabled = False
            MagnetT.Enabled = False
            Mtimer1.Text = "已关闭"
            Mtimer2.Text = ""
            Mtimer3.Text = ""
            Mtimer4.Text = ""
            Mtimer5.Text = ""
            M1XY.Text = ""
            M2XY.Text = ""
            M3XY.Text = ""
            M4XY.Text = ""
            M5XY.Text = ""
        Else FinderMagnet.Enabled = True
        End If
    End Sub

    '只显示IZE植物
    Private Sub IzePlantOnly_CheckedChanged(sender As Object, e As EventArgs) Handles IZECardOnly.CheckedChanged
        If IZECardOnly.Checked = True Then
            Card1_Click(sender, e)
            Card3.Visible = False
            Card10.Visible = False
            Card12.Visible = False
            Card13.Visible = False
            Card15.Visible = False
            Card16.Visible = False
            Card17.Visible = False
            Card20.Visible = False
            Card21.Visible = False
            Card24.Visible = False
            Card25.Visible = False
            Card26.Visible = False
            Card27.Visible = False
            Card28.Visible = False
            Card31.Visible = False
            Card33.Visible = False
            Card34.Visible = False
            Card36.Visible = False
            Card37.Visible = False
            Card39.Visible = False
            Card40.Visible = False
            Card41.Visible = False
            Card42.Visible = False
            Card43.Visible = False
            Card44.Visible = False
            Card45.Visible = False
            Card46.Visible = False
            Card47.Visible = False
            Card48.Visible = False
            Card49.Visible = False
            Card50.Visible = False
            Card51.Visible = False
            Card52.Visible = False
            Card53.Visible = False
            Card54.Visible = False
            Card55.Visible = False
            Card56.Visible = False
        Else
            Card3.Visible = True
            Card10.Visible = True
            Card12.Visible = True
            Card13.Visible = True
            Card15.Visible = True
            Card16.Visible = True
            Card17.Visible = True
            Card20.Visible = True
            Card21.Visible = True
            Card24.Visible = True
            Card25.Visible = True
            Card26.Visible = True
            Card27.Visible = True
            Card28.Visible = True
            Card31.Visible = True
            Card33.Visible = True
            Card34.Visible = True
            Card36.Visible = True
            Card37.Visible = True
            Card39.Visible = True
            Card40.Visible = True
            Card41.Visible = True
            Card42.Visible = True
            Card43.Visible = True
            Card44.Visible = True
            Card45.Visible = True
            Card46.Visible = True
            Card47.Visible = True
            Card48.Visible = True
            Card49.Visible = True
            Card50.Visible = True
            Card51.Visible = True
            Card52.Visible = True
            Card53.Visible = True
            Card54.Visible = True
            Card55.Visible = True
            Card56.Visible = True
        End If
    End Sub

    '手动控制开启种植模式
    Private Sub ManualCtrl_CheckedChanged(sender As Object, e As EventArgs) Handles ManualCtrl.CheckedChanged
        If ManualCtrl.Checked = True Then

            PlantMode.Text = "种植模式 : 手动"
            MouseMoveDetector.Enabled = False
            PlantSwitch.Enabled = True
            PlantSwitchText.Text = "自动识别已关闭"
            PlantSwitchText.Enabled = False


        Else PlantMode.Text = "种植模式"
            MouseMoveDetector.Enabled = True
            PlantSwitch.Enabled = False
            PlantSwitchText.Enabled = True
        End If
    End Sub

    '修改键位
    Private Sub ExchangeKeys_Click(sender As Object, e As EventArgs) Handles ExchangeKeys.Click
        If PlantKeyEdit.SelectedIndex = ShovelOnceKeyEdit.SelectedIndex Or PlantKeyEdit.SelectedIndex = SpeedUpKeyEdit.SelectedIndex Or ShovelOnceKeyEdit.SelectedIndex = SpeedUpKeyEdit.SelectedIndex Then
            ResetKeySet_Click(sender, e)
        Else
            Plant_Key = KeysIndexDictionary(PlantKeyEdit.SelectedIndex)
            ShovelOnce_Key = KeysIndexDictionary(ShovelOnceKeyEdit.SelectedIndex)
            SpeedUp_Key = KeysIndexDictionary(SpeedUpKeyEdit.SelectedIndex)
        End If
    End Sub

    '恢复默认键位
    Private Sub ResetKeySet_Click(sender As Object, e As EventArgs) Handles ResetKeySet.Click
        PlantKeyEdit.SelectedIndex = 15
        ShovelOnceKeyEdit.SelectedIndex = 16
        SpeedUpKeyEdit.SelectedIndex = 17
        Plant_Key = Keys.Z
        ShovelOnce_Key = Keys.X
        SpeedUp_Key = Keys.C

    End Sub

    '宣传视频按钮
    Private Sub VideoButton_Click(sender As Object, e As EventArgs) Handles VideoButton.Click
        Call ShellExecute(hWndOpenLink, "open", "https://www.bilibili.com/video/BV1Rj421X7D6", vbNullString, vbNullString, &H0)
    End Sub

    '更新日志按钮
    Private Sub UpdateInfoButton_Click(sender As Object, e As EventArgs) Handles UpdateInfoButton.Click
        Call ShellExecute(hWndOpenLink, "open", "https://www.bilibili.com/read/cv31369245", vbNullString, vbNullString, &H0)
    End Sub

    '显示统计信息

    Private Sub StatisticsInfo_Click(sender As Object, e As EventArgs) Handles StatisticsInfo.Click

        '计算点击按钮时的总时长
        Dim elapsedTime As TimeSpan = DateTime.Now - StartTime
        Dim TotalTime As Long = RunningTime + CInt(elapsedTime.TotalSeconds)

        If TotalTime < 600000 Then

            '少于9999分钟 总时长秒数转换为分秒制
            Dim TotalMin As Integer = TotalTime \ 60
            Dim RemainSec As Integer = TotalTime Mod 60

            MessageBox.Show("您已经手动种下了 " + PlantsPlanted.ToString + " 棵植物，" & vbCrLf & "共生成了 " + LevelsGenerated.ToString + " 个关卡，" & vbCrLf & "本程序已累计运行 " + TotalMin.ToString + " 分 " + RemainSec.ToString + " 秒！", "统计数据", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf TotalTime >= 600000 And TotalTime < 360000000 Then

            '大于9999分钟 总时长秒数转换为时分制
            Dim TotalHour As Integer = TotalTime \ 3600
            Dim RemainMin As Integer = (TotalTime Mod 3600) \ 60

            MessageBox.Show("您已经手动种下了 " + PlantsPlanted.ToString + " 棵植物，" & vbCrLf & "共生成了 " + LevelsGenerated.ToString + " 个关卡，" & vbCrLf & "本程序已累计运行 " + TotalHour.ToString + " 小时 " + RemainMin.ToString + " 分钟！", "统计数据", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("您已经手动种下了 " + PlantsPlanted.ToString + " 棵植物，" & vbCrLf & "共生成了 " + LevelsGenerated.ToString + " 个关卡，" & vbCrLf & "本程序已累计运行超过 100000 小时，感谢您的使用！", "统计数据", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub ShowTip(RangeMax As Integer)
        Dim RandomTipIndex As Integer = TipRandomizer.Next(1, RangeMax + 1)  '生成大于等于前数，小于后数的整数
        LabelTips.Text = RandomTip(RandomTipIndex)
        TipsNumber.Text = "(" + RandomTipIndex.ToString + "/" + RangeMax.ToString + ")"
    End Sub

    '随机寄语 在此定义
    Public Function RandomTip(Index As Integer) As String 'MAX=50   ShowTip(50)
        Select Case Index
            Case 1
                Return "本程序支持的游戏版本为1.0.0.1051"
            Case 2
                Return "PVZClass作者：""烟楼-天青-鸣"""
            Case 3
                Return "阵型代码转换算法作者：""天盟琉璃"""
            Case 4
                Return "本程序作者：Winkle雪线，可加入QQ群518803703获得最新更新"
            Case 5
                Return """忧郁菇""+""土豆雷""的设计往往不能踩掉土豆雷，因为撑杆需要跳过它"
            Case 6
                Return "僵尸啃食防御类植物时若5秒钟不受到伤害，则啃食伤害翻倍"
            Case 7
                Return "窝瓜对于其左侧身位的僵尸判定很小"
            Case 8
                Return "磁力菇的恢复时间是15秒，矿工在地下每前进一格的时间大概为1.2秒"
            Case 9
                Return "打困难阵法的时候别忘记存档！"
            Case 10
                Return "瞬杀植物：土豆雷，窝瓜，大嘴花，魅惑菇和草耙，每个都有自己的特点"
            Case 11
                Return "两个小鬼在恰当的时机可以走过双地刺或一个地刺王"
            Case 12
                Return "扶梯僵尸给南瓜头搭梯的时候，梯子实际上放在了里面的植物上"
            Case 13
                Return "有的时候你会看见三只手的扶梯"
            Case 14
                Return "PVZ，启动！（启动的小曲）"
            Case 15
                Return "南瓜头左侧的土豆雷在一定情况下可以被引爆"
            Case 16
                Return "做阵法时可以先确定核心操作，再去缝合其他模型"
            Case 17
                Return "扶梯和撑杆是很高效的组合，有时橄榄带慢速僵尸冲锋也是不错的选择"
            Case 18
                Return "有的时候垫小鬼真的很有用"
            Case 19
                Return "蹦极偷磁力菇的过程中被秒杀，同时让矿工渡过植物的操作叫做水中月"
            Case 20
                Return "QQ群的密码是什么？你还不知道关卡代码以什么开头吗？"
            Case 21
                Return "提问的艺术：尽量提有意义的问题"
            Case 22
                Return "你觉得在IZE中是小鬼强一点还是普僵强一点呢？"
            Case 23
                Return "如果反向矿工堵住了反向双发的枪口，双发就不敢射子弹了"
            Case 24
                Return "向日葵被子弹攻击，炸掉都不会给阳光"
            Case 25
                Return "只有正向且平射的子弹才能穿过传送门"
            Case 26
                Return "传送门相关功能容易导致游戏崩溃，这是正常情况哦"
            Case 27
                Return "小鬼单挑单发成功的概率有多高？"
            Case 28
                Return "用暂停控制舞王僵尸前进或停止的操作叫做女仆秘籍"
            Case 29
                Return "伴舞僵尸被黄油击中后会脱离队伍"
            Case 30
                Return "IZE中有八种阵型：综合，控制，输出，爆炸，倾斜，穿刺，即死，回复"
            Case 31
                Return "今天又是磁力菇当内鬼的一天啊"
            Case 32
                Return "梯子僵尸本体和梯子血一样厚"
            Case 33
                Return "IZE的题目是综合最优解"
            Case 34
                Return "豌豆僵尸即使被魅惑，子弹依旧会打向左边的植物"
            Case 35
                Return "让我康康你的统计数据！↘"
            Case 36
                Return "大嘴花消化时间大约为42秒"
            Case 37
                Return "扶梯僵尸可以给花盆中的地刺搭梯"
            Case 38
                Return "玉米投手投出黄油的概率是1000%（？）"
            Case 39
                Return "大蒜要比其他普通植物多100点血量"
            Case 40
                Return "磁力菇对处于啃食状态下的僵尸吸引范围增大"
            Case 41
                Return "为什么杨桃是神？"
            Case 42
                Return "原版中存在的裂荚Bug：当前后均有僵尸时，会朝前朝后各发射两颗豌豆"
            Case 43
                Return "即使是尸体也可以触发草耙"
            Case 44
                Return "小秘密：点击下面的数字就可以换一条贴士"
            Case 45
                Return "早上好，中午好或晚上好！今天也来做关卡吧！"
            Case 46
                Return "其实橄榄只比铁桶多了15颗子弹的血量……"
            Case 47
                Return "点击右下角的图标，就可以到我的主页啦！点个关注吧qwq"
            Case 48
                Return "冰车僵尸在一定时间内不受到伤害，就会进行加速"
            Case 49
                Return "有猫先打猫尾草……吗？"
            Case 50
                Return "撑杆面对机枪火炬时竟可以毫发无伤"
            Case 51
                Return "真想知道点击下面的数字会发生什么呐~？"
            Case 52
                Return "你发现了吗，杨桃打普僵，有的时候会受到2颗子弹，有的时候是5颗"
            Case 53
                Return "矿工僵尸在IZ模式中走的比其他模式更快"
            Case 54
                Return "高坚果并非不会被撑杆越过"
            Case 55
                Return "如果内置关卡过不去了，不妨搜索一下通关视频"
            Case 56
                Return "如果游戏崩溃了，那一定是游戏的问题！"
            Case 57
                Return "携带南瓜头的植物会更优先受到碾压伤害，导致整体消失"
            Case 58
                Return "点击上方""更新日志""按钮可以查看本程序使用说明"
            Case 59
                Return "所有的自定义关卡、软件设置、统计数据都保存在注册表中，谨慎清理"
            Case 60
                Return "如果感觉内置的关卡有难度，那就从""萌新友好""专辑开始吧！"
            Case 61
                Return "欢迎使用我是僵尸布阵器2.2版本！"
            Case 62
                Return "随机关卡只会在红线左侧创建植物"
            Case 63
                Return "随机关卡中的植物一定不是灰烬或是无用植物"
            Case 64
                Return "按C键就可以切换倍速模式（可以在本页面改掉默认按键）"
            Case 65
                Return "随机关卡中有10%的概率给植物套南瓜头，IZE中为6%"
            Case 66
                Return "你有尝试过新版本中的创意工坊功能吗？"
            Case 67
                Return "在屏幕左侧的冰车只要一段时间不受到伤害，就会突然加速哦"
            Case 68
                Return "随机IZE中，每5关就会碰到一个回复关卡！尽情享受吧~"
            Case 69
                Return "矿工不会爬梯子"
            Case 70
                Return "倒车的舞王如果和僵尸互啃，结束后竟然会往反方向移动一段距离！"
            Case 71
                Return "随机IZE中，每关的僵尸阵容也是随机的！"
            Case 72
                Return "传送门是一个非常好玩的设计，来试试""保护传送门""专题吧！"
            Case 73
                Return "最难的关卡难度：10+！目前还没有收录……"
            Case 74
                Return "冰车在原版中定价175，简直是太超模了"
            Case 75
                Return "随机关卡中，每关的向日葵数量一定不会少于红线位置的数量"
            Case 76
                Return "不同僵尸啃食大蒜，对其造成的伤害不同。最高的是潜水"
            Case 77
                Return "如果你的关卡上传到了创意工坊，以后就可以用很短的ID来生成它"
            Case 78
                Return "跳跳僵尸定价200实在是太贵了！"
            Case 79
                Return "如遇倍速功能失效，请重新打开游戏"
            Case 80
                Return "本程序完全免费，谨防上当受骗"


            Case Else
                Return "LabelTips Here"

        End Select
    End Function



    '跳转主页
    Private Sub WinkleLogo_Click(sender As Object, e As EventArgs) Handles WinkleLogo.Click
        Call ShellExecute(hWndOpenLink, "open", "https://space.bilibili.com/2198423", vbNullString, vbNullString, &H0)

    End Sub


    Private Sub SpeedIndex_Scroll(sender As Object, e As EventArgs) Handles SpeedIndex.Scroll

        Select Case SpeedIndex.Value
            Case 0
                SpeedIndexText.Text = "2x"
                SpeedUp.Text = "二倍速"
            Case 1
                SpeedIndexText.Text = "4x"
                SpeedUp.Text = "四倍速"
            Case 2
                SpeedIndexText.Text = "8x"
                SpeedUp.Text = "八倍速"
            Case 3
                SpeedIndexText.Text = "16x"
                SpeedUp.Text = "十六倍速"
            Case 4
                SpeedIndexText.Text = "32x"
                SpeedUp.Text = "三十二倍速"
            Case 5
                SpeedIndexText.Text = "64x"
                SpeedUp.Text = "六十四倍速"
        End Select

    End Sub

    Private Sub OpenSaveFold_Click(sender As Object, e As EventArgs) Handles OpenSaveFold.Click
        Dim folderPath As String = "C:\ProgramData\PopCap Games\PlantsVsZombies\userdata"
        Try
            Process.Start("explorer.exe", folderPath)
        Catch ex As Exception
            ' 处理异常情况
            MessageBox.Show("无法打开: " & ex.Message)
        End Try
    End Sub


    '换一句
    Private Sub TipsNumber_Click(sender As Object, e As EventArgs) Handles TipsNumber.Click
        ShowTip(80)
    End Sub



    '按键检测器 (其中37为键盘← 键盘码，按键激活为1，否则为0。)

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Label.Text = Memory.ReadByte(KeyAddress + &HF4 + 37)
    'End Sub


    '清空注册表（按钮已隐藏）
    Private Sub ResetProgramme_Click(sender As Object, e As EventArgs) Handles ResetProgramme.Click
        DeleteSetting("IZ_Format_Designer_V2")
    End Sub



#End Region

End Class
