// Structured PAL4 reconstruction for M07.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M07_1_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar <= 40500 /* 第一章 / 3-2-1.风水惊变 / 向北前行 */)
    {
        giScriptMusicPlay("P60", 0, 2.5, 0.0);
        giArenaReadyRestore();
    }
    if (global_mvar != 40401)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2001();
    }
}

void M07_2_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M07_3_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M07_4_init()
{
    if (global_mvar < 50100 /* 离开王墓 */)
    {
        giSetObjectVisible("entrance1", false);
        giSetObjectVisible("entrance2", false);
        giArenaReadyRestore();
    }
    if (global_mvar < 41000 /* 第一章 / 3-2-3.风水惊变 / 进入秘道 */)
    {
        giSetObjectVisible("entrance3", false);
        giArenaReadyRestore();
    }
    if (global_mvar < 50100 || var_mo < 1 /* 离开王墓 */)
    {
        if (global_mvar < 41000 || var_mo != 0 /* 第一章 / 3-2-3.风水惊变 / 进入秘道 */)
        {
            giArenaReadyRestore();
        }
        else
        {
            giArenaReadyRestore();
            giGOBMovment("MO004", 0.01, 73.9254, 244.1573, 1365.8572, false);
            giGOBMovment("MO005", 0.01, -79.5744, 244.1672, -1637.6202, false);
        }
    }
    else
    {
        giArenaReadyRestore();
        giGOBMovment("MO004", 0.01, 73.9254, 552.1573, 1365.8572, false);
        giGOBMovment("MO005", 0.01, -76.7712, 490.6672, -1635.8625, false);
    }
}

void M07_5_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M07_6_init()
{
    if (global_mvar != 41000 /* 第一章 / 3-2-3.风水惊变 / 进入秘道 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetObjectVisible("MO002", true);
        giArenaReadyRestore();
    }
    if (var_mo == 1)
    {
        giArenaReadyRestore();
        giEventVolumeVisible("wall01", false);
    }
}

void M07_7_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M07_8_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M07_9_init()
{
    if (var_zhu != 2)
    {
        giTimeScript(180.0, "func9001");
        giArenaReadyRestore();
    }
    else
    {
        func3001();
    }
}

void M07_10A_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M07_10B_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M07_10C_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M07_11A_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M07_11B_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void EarthBall()
{
    int leader_player_id = 0;

    if (global_mvar >= 41000 /* 第一章 / 3-2-3.风水惊变 / 进入秘道 */)
    {
        if (global_mvar < 51000 || var_mo < 1)
        {
            leader_player_id = giPlayerGetLeader();
            giShowHint("现在不可使用土灵珠", 0.5, 0.15);
        }
        else
        {
            giPlayerLock();
            giFlashOutBlack(1.0, true, true);
            if (!giBGMConfigIsInArea("1"))
            {
                giArenaLoad("M07", "1", "", true);
            }
            giPlayerCurrentSetPos(-377.61365, 0.945543, 1262.4222);
            giPlayerCurrentSetAng(90.0);
            giCameraSetMode(5, true);
            giFlashInBlack(1.0, true);
            giArenaReady();
            giPlayerUnLock();
        }
    }
    else
    {
        giPlayerLock();
        giFlashOutBlack(1.0, true, true);
        if (!giBGMConfigIsInArea("1"))
        {
            giArenaLoad("M07", "1", "", true);
        }
        giPlayerCurrentSetPos(-377.61365, 0.945543, 1262.4222);
        giPlayerCurrentSetAng(90.0);
        giCameraSetMode(5, true);
        giFlashInBlack(1.0, true);
        giArenaReady();
        giPlayerUnLock();
    }
}

void func1001()
{
    if (giGetVisibleObject("entrance2"))
    {
        giArenaLoad("M07", "2", "", true);
        giPlayerCurrentSetPos(11.173015, 0.136925, 1551.496);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
}

void func1002()
{
    giArenaLoad("M07", "1", "", true);
    giPlayerCurrentSetPos(-4.124262, 0.897173, -1561.2278);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("M07", "3", "", true);
    giPlayerCurrentSetPos(-16.870352, 81.15117, 1778.0151);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("M07", "2", "", true);
    giPlayerCurrentSetPos(-1913.7733, -57.401093, -1220.6619);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("M07", "11", "11a", true);
    giPlayerCurrentSetPos(431.4358, -0.208239, 819.7177);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("M07", "2", "", true);
    giPlayerCurrentSetPos(10.985705, 0.136925, -1556.068);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1007()
{
    giArenaLoad("M07", "10", "10a", true);
    giPlayerCurrentSetPos(-0.106093, 0.611963, 470.3585);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1008()
{
    giArenaLoad("M07", "2", "", true);
    giPlayerCurrentSetPos(1933.1138, 0.136921, -1232.4099);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1009()
{
    giArenaLoad("M07", "4", "", true);
    giPlayerCurrentSetPos(-1.242241, 0.13151, 1375.4314);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1010()
{
    giArenaLoad("M07", "3", "", true);
    giPlayerCurrentSetPos(-9.188637, 233.86118, -1709.9886);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1011()
{
    giArenaLoad("M07", "5", "", true);
    giPlayerCurrentSetPos(2218.4956, -72.32734, -1029.546);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1012()
{
    giArenaLoad("M07", "4", "", true);
    giPlayerCurrentSetPos(-1372.5043, 0.157389, -59.115913);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1013()
{
    giArenaLoad("M07", "8", "", true);
    giPlayerCurrentSetPos(-1122.6952, 9.601944, 2687.0603);
    giPlayerCurrentSetAng(182.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1014()
{
    giArenaLoad("M07", "4", "", true);
    giPlayerCurrentSetPos(-0.991638, 0.157412, -1619.3889);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1015()
{
    giArenaLoad("M07", "10", "10b", true);
    giPlayerCurrentSetPos(-0.106093, 0.611963, 470.3585);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1016()
{
    giArenaLoad("M07", "5", "", true);
    giPlayerCurrentSetPos(-1414.1935, 0.370872, -1723.4735);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1017()
{
    giArenaLoad("M07", "10", "10c", true);
    giPlayerCurrentSetPos(-0.106093, 0.611963, 470.3585);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1018()
{
    giArenaLoad("M07", "5", "", true);
    giPlayerCurrentSetPos(-1768.7631, 0.370872, 540.5164);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1019()
{
    giArenaLoad("M07", "6", "", true);
    giPlayerCurrentSetPos(1260.8549, 0.162436, -2.998711);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1020()
{
    giArenaLoad("M07", "5", "", true);
    giPlayerCurrentSetPos(-2230.1143, 0.370874, 1635.826);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1021()
{
    giArenaLoad("M07", "11", "11b", true);
    giPlayerCurrentSetPos(431.4358, -0.208239, 819.7177);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1022()
{
    giArenaLoad("M07", "5", "", true);
    giPlayerCurrentSetPos(1255.3794, 0.370871, 1168.7852);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1023()
{
    int local_4 = 0;

    giArenaLoad("M07", "7", "", true);
    giPlayerLock();
    giIMMBegin();
    giCameraAutoSeek(false);
    giCameraSetCollide(false);
    giPlayerCurrentSetPos(-1290.1357, 177.5731, 1698.2054);
    giPlayerCurrentSetAng(174.0);
    giIMMEnd();
    giCameraPrepare("viewLadder_out");
    giCameraRunSingle("viewLadder_out", false);
    local_4 = gi2DSoundPlay("wc001", -1);
    giWait(0.5);
    giFlashInBlack(1.5, false);
    giIMMBegin();
    giArenaReady();
    giGOMTouch("ladder");
    giPlayerCurrentMovment(3.0, -1290.1357, 60.5731, 1698.2054, false);
    giIMMEnd();
    giWait(2.0);
    giFlashOutBlack(0.8, true, false);
    giWait(1.5);
    giIMMBegin();
    gi2DSoundStopID(local_4);
    giPlayerCurrentSetPos(-1265.3817, -0.426886, 1548.4672);
    giPlayerCurrentSetAng(161.0);
    giCameraAutoSeek(false);
    giCameraRunSingle("viewLadder_out", false);
    giIMMEnd();
    giWait(0.800000011920929);
    giFlashInBlack(0.5, true);
    local_4 = gi2DSoundPlay("wc001", -1);
    giGOBMovment("ladder", 3.0, -1279.7418, 222.5731, 1749.4895, false);
    giWait(2.200000047683716);
    giFlashOutBlack(0.5, true, true);
    giCameraSetMode(5, true);
    gi2DSoundStopID(local_4);
    giFlashInBlack(0.5, true);
    giPlayerUnLock();
}

void func1024()
{
}

void func1025()
{
    if (global_mvar != 41602 /* 第一章 / 3-2-4.风水惊变 / 破解机关 */)
    {
        giArenaLoad("M07", "8", "", true);
        giPlayerCurrentSetPos(-2040.9624, 9.602798, 1899.2831);
        giPlayerCurrentSetAng(90.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
    else
    {
        func2005();
    }
}

void func1026()
{
    giArenaLoad("M07", "7", "", true);
    giPlayerCurrentSetPos(1327.34, -43.668797, -1725.8666);
    giPlayerCurrentSetAng(305.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1027()
{
    if (var_zhu != 2)
    {
        giArenaLoad("M07", "9", "", true);
        giPlayerCurrentSetPos(-865.6085, 262.45312, 860.75867);
        giPlayerCurrentSetAng(195.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("M07", "9", "", true);
    }
}

void func1028()
{
    giArenaLoad("M07", "8", "", true);
    giPlayerCurrentSetPos(-288.02744, 0.184406, -2304.3347);
    giPlayerCurrentSetAng(339.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1029()
{
    if (global_mvar != 50100 /* 离开王墓 */)
    {
        giArenaLoad("Q04", "Q04C", "", true);
        giPlayerCurrentSetPos(-1439.1438, 65.634094, 2732.9912);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giFlashOutBlack(0.1, true, true);
        giArenaLoad("Q04", "Q04C", "", true);
    }
}

void func1030()
{
    giMonsterStopPursuit();
    giPlayerLock();
    giPlayerSetLeader(0);
    giPlayerWalkTo(0, 1482.389, -294.35797, -475.36566, true);
    giPlayerSetDir(0, 278.0, true);
    giCameraAutoSeek(true);
    giCameraSetMode(5, true);
    giSetPortrait("101D", true);
    giTalk("云天河：好像走错路了，去另一边找找吧。", "");
    giPlayerUnLock();
}

void func1031()
{
    giArenaLoad("M05", "1", "", true);
    giPlayerCurrentSetPos(2991.13, 932.19, -2105.61);
    giPlayerCurrentSetAng(287.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func2001()
{
    if (global_mvar == 40401)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giScriptMusicPlay("P60", 0, 2.5, 0.0);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, -245.0905, 0.8972, 1429.5255);
        giPlayerSetAng(0, 135.0);
        giPlayerSetPos(1, -197.6922, 0.8972, 1389.5143);
        giPlayerSetAng(1, 163.0);
        giPlayerSetPos(2, -180.3664, 0.8972, 1452.5931);
        giPlayerSetAng(2, 170.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giSetObjectVisible("save1", false);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        gi2DSoundPlay("WJ041", 1);
        giWait(2.0);
        giFlashInBlack(3.5, false);
        giArenaReady();
        giPlayerWalkTo(2, 51.3899, 0.8972, 1349.8942, false);
        giWait(0.6000000238418579);
        giPlayerWalkTo(0, 2.5889, 0.8972, 1288.1711, false);
        giPlayerWalkTo(1, -17.9577, 0.8972, 1362.1332, false);
        giPlayerEndMove(2);
        giPlayerSetDir(2, 195.0, false);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 174.0, false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 164.0, true);
        giCameraRunSingle("002", true);
        giWait(0.800000011920929);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：……从前只在书上读到王墓“巍峨雄浑、气象万千”，如今亲眼所见，确是一点不差。", "41722");
        giPlayerSetDir(1, 106.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：这还只算一般的，若是皇帝老儿的墓，常常要国库相倾，数十万工匠修上二三十年才修成，不知有多华美呢！", "41723");
        giIMMBegin();
        giPlayerSetDir(2, 280.0, false);
        giPlayerSetDir(0, 342.0, false);
        giIMMEnd();
        giCameraRunSingle("003", true);
        giWait(1.0);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106E", false);
        giTalk("柳梦璃：……如此劳民伤财，竟然只为一个死人，未免也太、太……", "41724");
        giPlayerEndAction(2);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：太混帐了！对吧？", "41725");
        giWait(0.30000001192092896);
        giPlayerDoAction(2, "C08", 1, true);
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：好梦璃！我就知道你和我想的一样，所以我们借过一下这老头子的墓，那是一点都问心无愧的～", "41726");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giCameraRunSingle("004", true);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101J", false);
        giTalk("云天河：这里、不太好……周围好像有杀气。", "41727");
        giPlayerEndAction(1);
        giPlayerSetDir(1, 165.0, false);
        giPlayerSetDir(2, 224.0, false);
        giCameraRunSingle("003", true);
        giWait(0.800000011920929);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：啊？又是杀气？！", "41728");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：少唬人了，这八公山风水算是不错，最难得的是看那石林便知道，此处的山由石变木、由木变石，千百年来不知经过多少次，正是“脱卸剥换”之象，好比凡人脱胎换骨，是了不得的吉兆呢！", "41729");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：这么个好地方，又怎会有什么不干净的东西～", "41730");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(0, 270.0, true);
        giPlayerDoAction(0, "J13", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：咦？", "41731");
        giWait(0.5);
        giCameraRunSingle("010", true);
        giWait(1.0);
        giSetPortrait("101A", false);
        giTalk("云天河：这是什么？老虎吗？眼睛还会冒火！", "41732");
        giWait(1.2000000476837158);
        giPlayerSetAng(2, 254.0);
        giCameraRunSingle("007", false);
        giWait(0.5);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：（……………………又～没～在～听……留着体力赶路，我忍！）", "41733");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：这个东西，我在书上见过，好像叫“辟邪兽”……", "41734");
        giPlayerSetDir(1, 106.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：没错没错，还是梦璃有见识！不像某只野人……哼。", "41735");
        giIMMBegin();
        giPlayerSetDir(2, 280.0, false);
        giPlayerSetDir(0, 342.0, false);
        giIMMEnd();
        giWait(0.800000011920929);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：……？", "41736");
        giSetPortrait("103A", true);
        giTalk("韩菱纱：辟邪兽是为了镇住墓中邪气，王陵内肯定要有的。", "41737");
        giSetPortrait("103M", true);
        giTalk("韩菱纱：至于这一对，除了镇邪，还在肚子里灌满了油，被当作“长明灯”来用。", "41738");
        giCameraRunSingle("015", false);
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106D", true);
        giTalk("柳梦璃：这灯火……竟能百年不熄？", "41739");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：嘻嘻～何止百年，传说长明灯的灯油是秘法制成，点亮以后能千万年不灭。", "41740");
        giSetPortrait("103B", false);
        giTalk("韩菱纱：淮南王老头怎么说也是一方镇侯，用得起这种宝贝，倒也不稀奇呢！", "41741");
        giWait(0.5);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：世间之物真的千奇百怪，让人大长见识～", "41742");
        giCameraRunSingle("017", true);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：其实这儿早有其他人来过，还在墓道里打了个大洞通到碗丘山，估计冥宫里值钱的东西都被拿得差不多了……", "41743");
        giPlayerSetDir(1, 191.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：所以呢，我们只要沿着墓道一直往南，轻轻松松就能到陈州。", "41744");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：南？那边不是南啊？", "41745");
        giPlayerSetDir(2, 224.0, false);
        giWait(0.5);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：不是南？那是东？是东吧！", "41746");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：哈、哈哈，不小心说错，你少斤斤计较！", "41747");
        giPlayerEndAction(1);
        giSetPortrait("101D", true);
        giTalk("云天河：……那边也不是东……", "41748");
        giSetPortrait("106B", false);
        giTalk("柳梦璃：……墓中昏暗，恐怕也不易辨识方向……", "41749");
        giSetPortrait("101C", true);
        giTalk("云天河：方向？还蛮好认的～ ", "41750");
        giPlayerSetDir(0, 189.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：前面是北，后面是南，左面是西，右面是东，所以<colour red=255 green=187 blue=0 alpha=255>我们是要往北走</colour><dc0>啰？</dc0>", "41751");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：云～天～河！！", "41752");
        giPlayerSetDir(0, 342.0, true);
        giPlayerDoAction(0, "J02", 1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：你不要给我得理不饶人！就算姑娘我有那么一～点～点认不清方向，一～点～点路痴，用鼻子闻的我都知道出口在哪！总之我们往那边走就对了！！", "41753");
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：没、没有啦，我就是想问问清楚……", "41754");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("103G", false);
        giTalk("韩菱纱：哼，问那么多干嘛，少说话多走路！", "41755");
        giSetPortrait("101E", true);
        giTalk("云天河：哦……", "41756");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：我看我们就顺着菱纱所指的方向赶路吧，我相信菱纱，一定不会有错的。", "41757");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerSetDir(1, 103.0, true);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：还是梦璃你最好！不像某只野人……哼。", "41758");
        giPlayerSetDir(2, 278.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(2, "J14", 1, false);
        giWait(0.699999988079071);
        giSetPortrait("101E", true);
        giTalk("云天河：…………", "41759");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(2);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giSetObjectVisible("save1", true);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(-5.375, 0.8972, 1450.6504);
        giPlayerCurrentSetAng(175.0);
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 40500; // 0x00009E34, 第一章 / 3-2-1.风水惊变 / 向北前行
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2002()
{
    if (global_mvar == 40500 /* 第一章 / 3-2-1.风水惊变 / 向北前行 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giScriptMusicStop(0, 2.5);
        giFlashOutBlack(1.5, true, true);
        giMonsterStopPursuit();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giHideGASkillObject();
        giPlayerSetPos(0, -146.0222, 0.8972, -570.8776);
        giPlayerSetAng(0, 197.0);
        giPlayerSetPos(2, -134.6716, 0.8972, -497.2726);
        giPlayerSetAng(2, 188.0);
        giPlayerSetPos(1, -85.8932, 0.8972, -568.7925);
        giPlayerSetAng(1, 236.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giMonsterSetHide("m07-01-07", false);
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("003", true);
        giFlashInBlack(1.5, true);
        giPlayerDoAction(0, "J13", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：前面……真的有杀气！", "41760");
        giWait(0.30000001192092896);
        giSetPortrait("106D", true);
        giTalk("柳梦璃：会不会是误闯进墓中的野兽？", "41761");
        giSetPortrait("103C", false);
        giTalk("韩菱纱：一点声响都没有啊……", "41762");
        gi2DSoundPlay("WJ020", 1);
        giWait(1.0);
        giCameraRunSingle("002", true);
        giSetNpcVisible("MN001", true);
        giNpcWalkTo("MN001", -403.8321, 0.8972, -791.2979, true);
        giSetPortrait("101D", true);
        giTalk("云天河：咦？是个女孩子？", "41763");
        giNpcWalkTo("MN001", -181.9255, 0.8972, -656.4593, false);
        giNpcSetDir("MN001", 18.0, true);
        giCameraRunSingle("004", true);
        giSetPortrait("101D", true);
        giTalk("云天河：……穿这么少？", "41764");
        giPlayerDoAction(2, "J01", 1, false);
        giSetPortrait("106G", true);
        giTalk("柳梦璃：小心！她身上戾气很重！", "41765");
        gi2DSoundPlay("WJ020", 1);
        giNpcDoAction("MN001", "J01", 1, false);
        giWait(0.800000011920929);
        giCameraRunSingle("007", true);
        giIMMBegin();
        giSetObjectVisible("Jeffect001", true);
        gi2DSoundPlay("WF004", 1);
        giPlayerDoAction(1, "Z04", 1, false);
        giIMMEnd();
        giWait(0.20000000298023224);
        giSetObjectVisible("Jeffect001", false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：啊！", "41766");
        giWait(0.30000001192092896);
        giPlayerRunTo(0, -169.5673, 0.8972, -613.4592, true);
        giPlayerDoAction(0, "Z03", 1, false);
        gi2DSoundPlay("WH028", 1);
        giPlayerDoAction(1, "J02", 1, false);
        giWait(0.5);
        gi2DSoundPlay("WH007", 1);
        giEffectPlayWithNPC("H_091", 1, "MN001");
        giNpcBlendOut("MN001", 1.5, true);
        giPlayerEndAction(0);
        giWait(1.600000023841858);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：她不见了……怎么办？爹说过的，不能打女孩子…………", "41767");
        giWait(0.5);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：打都打了，刚才也没见你手软，现在还说这个……", "41768");
        giCameraRunSingle("010", false);
        giPlayerSetDir(0, 44.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(0, "J17", 1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：话是这么说没错，但是……总不能看着你和梦璃挨打吧……", "41769");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：……那个女子，恐怕不是活人，反倒像是戾气凝成的魂魄，十分凶煞。", "41770");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giIMMBegin();
        giPlayerSetDir(1, 330.0, false);
        giPlayerSetDir(0, 12.0, false);
        giIMMEnd();
        giWait(0.800000011920929);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：不妙！这淮南王陵中一定出了什么大事，不然不会风水生变，连厉鬼怨魂都冒出来了！", "41771");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(2, 139.0, true);
        giSetPortrait("106D", false);
        giTalk("柳梦璃：这……怎么会这样……", "41772");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：原来那就是“鬼”啊……爹死了以后……也会变成那个样子吗？", "41773");
        giWait(0.4000000059604645);
        giPlayerSetDir(2, 188.0, true);
        giWait(0.4000000059604645);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：刚刚那个是厉鬼怨魂，我相信云叔绝对不会变成那样的。", "41774");
        giPlayerEndAction(2);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：唉，人算不如天算，看样子淮南王陵是不能走了……", "41775");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(2, 154.0, false);
        giCameraRunSingle("012", true);
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106D", false);
        giTalk("柳梦璃：唔……这座陵墓距离寿阳如此接近，万一那些厉鬼危害到城中百姓怎么办？", "41776");
        giSetPortrait("106A", false);
        giTalk("柳梦璃：我反倒想<colour red=255 green=187 blue=0 alpha=255>将此事查清</colour><dc0>，看看能不能断绝祸害……</dc0>", "41777");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerWalkTo(0, -154.8633, 0.8972, -557.7019, true);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：梦璃，你、你说的有道理！我帮你！", "41778");
        giPlayerSetDir(2, 191.0, true);
        giWait(0.5);
        giPlayerDoAction(2, "C08", 1, true);
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：……哎～既然这样，我当然也只有舍命陪美人了，嘻嘻，你们都不怕，我还有什么好顾忌的～不过风水突变的陵墓，我也是头一回遇上，大家千万要小心些，剑仙还没做成，万一有个闪失，可太不划算了！", "41779");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(2, 139.0, true);
        giWait(0.5);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：嗯，谢谢你们～", "41780");
        giPlayerEndAction(2);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：没、没什么，我又不怕鬼，我也要保护柳波波，还有柳波母。", "41781");
        giIMMBegin();
        giPlayerSetDir(2, 191.0, false);
        giPlayerSetDir(1, 301.0, false);
        giIMMEnd();
        giWait(0.800000011920929);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：（瞎说……如果是你爹，看你怕不怕……）", "41782");
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giShowSignpost();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giMonsterSetHide("m07-01-07", true);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(-14.3154, 0.8972, -642.7092);
        giPlayerCurrentSetAng(180.0);
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 40900; // 0x00009FC4, 查清祸害
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2003()
{
    if (global_mvar == 40900 /* 查清祸害 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giHideGASkillObject();
        giPlayerSetPos(0, -7.8449, 139.2568, 805.8798);
        giPlayerSetPos(1, -7.8449, 139.2568, 805.8798);
        giPlayerSetPos(2, -7.8449, 139.2568, 805.8798);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("007", true);
        giFlashInBlack(3.5, false);
        giPlayerWalkTo(0, 35.6173, 150.6664, 559.1547, false);
        giWait(0.5);
        giPlayerWalkTo(1, 58.3026, 150.6664, 655.8481, false);
        giWait(0.5);
        giPlayerWalkTo(2, -25.6755, 150.6664, 620.1794, false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 188.0, true);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 214.0, true);
        giPlayerEndMove(2);
        giCameraRunSingle("021", false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：在墓中走了这么久，除去鬼怪，却是一点其他的线索都没有……", "41783");
        giPlayerSetDir(1, 257.0, true);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：梦璃别急，你仔细看看这间后殿，里面十之八九藏有大秘密！", "41784");
        giWait(0.5);
        giPlayerSetDir(1, 214.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "J13", -1, false);
        giWait(0.699999988079071);
        giCameraWait();
        giWait(0.5);
        giCameraRunSingle("022", true);
        giWait(0.5);
        giCameraRunSingle("023", true);
        giCameraRunSingle("024", false);
        giWait(2.0);
        giSetPortrait("101C", false);
        giTalk("云天河：有吗？长得和其他房间差不多啊……", "41785");
        giCameraWait();
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetAng(2, 86.0);
        giPlayerSetAng(1, 259.0);
        giIMMEnd();
        giCameraRunSingle("031", true);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106D", false);
        giTalk("柳梦璃：菱纱，你是说……这里并无鬼怪？", "41786");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：嘻，好梦璃，还是你聪明～", "41787");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：我先前几回进来淮南王陵时也没细看，如今厉鬼尽出，才觉得这儿很古怪。", "41788");
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：按理说呢，“鬼”属阴寒而畏阳，陵墓入口处被我挖了个大洞，生气泄入，鬼当然都不敢靠近，就不晓得这后殿没鬼是怎么一回事……", "41789");
        giSetPortrait("101B", false);
        giTalk("云天河：你们看！", "41790");
        giIMMBegin();
        giPlayerSetDir(1, 196.0, false);
        giPlayerSetDir(2, 170.0, false);
        giIMMEnd();
        giWait(1.0);
        giCameraRunSingle("003", true);
        giPlayerSetPos(0, -108.274, 235.3718, -216.5481);
        giPlayerSetPos(1, 10.1477, 235.3718, -249.1394);
        giPlayerSetPos(2, 7.9565, 235.3718, -216.3662);
        giSetPortrait("101B", false);
        giTalk("云天河：是蛤蟆，还有两只～", "41791");
        giPlayerRunTo(0, -156.5614, 235.3718, -451.882, false);
        giWait(0.5);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 60.0, true);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：……蛤蟆就蛤蟆，恶心死了，还嚷嚷什么……", "41792");
        giPlayerWalkTo(1, 139.3631, 235.3717, -441.8426, false);
        giWait(2.5);
        giIMMBegin();
        giCameraRunSingle("004", false);
        giPlayerSetPos(1, 128.9076, 235.3716, -449.3428);
        giPlayerSetAng(1, 267.0);
        giPlayerSetAng(0, 95.0);
        giIMMEnd();
        giPlayerWalkTo(2, 89.105, 235.3717, -354.4086, false);
        giWait(0.30000001192092896);
        giPlayerEndMove(1);
        giPlayerDoAction(1, "J14", -1, false);
        giWait(1.0);
        giPlayerEndMove(2);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：我记得书中好像把蛤蟆叫作“蟾蜍”，却还是个吉物呢。 ", "41793");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 343.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：那倒是！传说嫦娥奔月，飞升成仙，月亮里就有只很大很大的蛤蟆，所以这丑东西也变得讨人喜欢起来。", "41794");
        giSetPortrait("106A", true);
        giTalk("柳梦璃：据说淮南王生前笃好寻仙修炼之术，最后同八位老者服食仙丹而飞升，“八公山”也因此得名，不知是真是假……", "41795");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：天知道呐～反正我进他的冥宫看过，那老头的棺椁里没有尸骨，说不定真的变神仙去了……", "41796");
        giPlayerSetDir(1, 278.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：你们看这两只蛤蟆，用的玉也不同，左面是红玉，右面是黄玉，我猜是分别对应“日中赤气上皇真君”、“月中黄气上黄神母”，哈哈，太阳月亮都到齐了，可不正是暗合仙籍典故里常说的阴阳顺调、天人合一～", "41797");
        giWait(0.800000011920929);
        giCameraRunSingle("033", true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：我听不太懂……不过，原来蛤蟆是这么厉害的东西……", "41798");
        giPlayerDoAction(0, "C07", -1, false);
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("034", false);
        giPlayerSetPosRot(1, 126.8965, 235.3716, -448.4559, 274.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：咦？！", "41799");
        giSetObjectVisible("Jeffect001", true);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：怎么回事？！", "41800");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPosRot(1, 126.8965, 235.3716, -448.4559, 274.0);
        giPlayerSetPosRot(0, -149.588, 235.3718, -448.87, 91.0);
        giPlayerSetAng(2, 215.0);
        giCameraRunSingle("017", false);
        giIMMEnd();
        giWait(2.5);
        giFlashOutBlack(1.0, true, true);
        giCameraPrepare("viewMO004");
        giCameraRunSingle("viewMO004_1", true);
        giFlashInBlack(1.0, true);
        giWait(0.800000011920929);
        giGOMTouch("MO004");
        giCameraRunSingle("viewMO004_2", false);
        giWait(1.399999976158142);
        gi2DSoundPlay("WJ048", 1);
        giWait(2.0);
        giFlashOutBlack(1.0, true, true);
        giCameraPrepare("viewMO005");
        giCameraRunSingle("viewMO005_1", true);
        giFlashInBlack(1.0, true);
        giWait(0.800000011920929);
        giGOMTouch("MO005");
        giCameraRunSingle("viewMO005_2", false);
        giWait(1.399999976158142);
        gi2DSoundPlay("WJ048", 1);
        giWait(2.0);
        giCameraPrepare("MC001");
        giCameraRunSingle("013", true);
        giWait(0.800000011920929);
        giPlayerSetPos(1, -3.2224, 235.3718, -343.5106);
        giPlayerSetAng(1, 345.0);
        giGOMTouch("MO001");
        giWait(2.299999952316284);
        giIMMBegin();
        giPlayerSetPos(0, -103.7195, 235.3718, -333.1149);
        giPlayerSetPos(2, -15.7684, 235.3718, -265.8474);
        giPlayerSetAng(0, 90.0);
        giPlayerSetAng(2, 180.0);
        giIMMEnd();
        giCameraRunSingle("035", true);
        giSetObjectVisible("Jeffect001", false);
        giWait(0.4000000059604645);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：真没想到……难怪、难怪我之前一直找不到地宫的秘室……", "41801");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("036", true);
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106D", false);
        giTalk("柳梦璃：这两块玉石莫非是通灵之物？", "41802");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：唔……刚刚竟然看走眼了，那根本不是什么黄玉红玉嘛，是传说中的宝物，名为“阴阳紫阕”，我还是头一回亲眼见到呢！", "41803");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：阴阳紫阕？好特别的名字……", "41804");
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：这东西我晓得～可以吃！就是不知味道怎样～", "41805");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("037", false);
        giPlayerSetAng(1, 280.0);
        giPlayerSetAng(2, 220.0);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：你？……鬼才信你这野人晓得什么呢……", "41806");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101B", true);
        giTalk("云天河：真的！是爹告诉我的，他说有种叫“阴阳紫阕”的好东西，人吃了以后身体就会变很壮～", "41807");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：……哼，算你说对一半。", "41808");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(2, 195.0, false);
        giWait(0.5);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：听名字就知道，阴阳紫阕分为阴、阳两部分，长是长在一块儿，在地下一千年才能成玉石之形，这个时候把它挖出来做成玉器，就已经是无价的宝贝了！", "41809");
        giSetPortrait("106E", true);
        giTalk("柳梦璃：既然是“玉”……又怎能服食？", "41810");
        giPlayerSetDir(1, 5.0, true);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：这个嘛，就是它最最神奇的地方啰～", "41811");
        giIMMBegin();
        giPlayerSetAng(2, 186.0);
        giCameraRunSingle("038", true);
        giIMMEnd();
        giIMMBegin();
        giPlayerSetPos(0, -148.6613, 235.3718, -392.4504);
        giPlayerSetAng(0, 110.0);
        giIMMEnd();
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：要是阴阳紫阕成为玉石后，没有被人挖出来，再过上一千年，玉髓成精，就能用来填肚子了，至于功效怎样，我可不清楚。", "41812");
        giSetPortrait("103A", true);
        giTalk("韩菱纱：只是听说它有了灵性便要乱跑，阳实和阴实会分开，凡人如果只得其中一个吃下去，反而不好！", "41813");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：那不是和成了精的人参差不多？真是有趣得很～", "41814");
        giPlayerEndAction(2);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：有趣的还多着呢！", "41815");
        giSetPortrait("103M", true);
        giTalk("韩菱纱：这阴阳紫阕如果感应到极盛的阳气与阴气，便会激发灵力，只碰触一边，或是阴阳互换，就一点用都没有。", "41816");
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：看来淮南王是请了奇人把它们做成机关，恰好男为阳、女为阴，被我和天河碰到，倒把这机关给破了。", "41817");
        giSetPortrait("103B", true);
        giTalk("韩菱纱：走吧，我们赶快进到秘道里，看看淮南王老头用了这么贵重的宝物当开门锁，门里面又有什么呢～", "41818");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：嗯，不知和墓中的厉鬼有无关系……", "41819");
        giWait(0.5);
        giPlayerSetDir(1, 256.0, false);
        giWait(0.5);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：天河，我们走吧——", "41820");
        giPlayerDoAction(1, "J02", 1, false);
        giPlayerDoAction(0, "Z03", 0, false);
        giWait(0.4000000059604645);
        giCameraRunSingle("033", true);
        gi2DSoundPlay("WJ042", 0);
        giIMMBegin();
        giPlayerSetPos(2, -82.6539, 235.3718, -311.2882);
        giPlayerSetAng(2, 232.0);
        giPlayerSetPos(1, -78.0082, 235.3718, -355.549);
        giPlayerSetAng(1, 255.0);
        giIMMEnd();
        giSetPortrait("103D", false);
        giTalk("韩菱纱：你！你做什么？！", "41821");
        gi2DSoundStop();
        giPlayerEndAction(0);
        giCameraRunSingle("039", true);
        giWait(0.5);
        giPlayerSetDir(0, 69.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：菱纱，你不是说这东西再在地下埋一千年，就能变吃的吗？", "41822");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("101B", true);
        giTalk("云天河：这么奇怪的东西，我要带走，找个地方埋起来～", "41823");
        giSetPortrait("106C", false);
        giTalk("柳梦璃：……", "41824");
        giSetPortrait("103E", false);
        giTalk("韩菱纱：难道你能活一千年再吃吗？", "41825");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：……走啦！那东西那么大只，我们还要赶路，带了根本就是累赘……", "41826");
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：也对啊，好吧……可惜了……", "41827");
        giFlashOutBlack(1.5, true, true);
        giCameraWait();
        giPlayerEndAction(2);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giSetObjectVisible("entrance3", true);
        giShowSignpost();
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(-6.9542, 235.3717, -264.2103);
        giPlayerCurrentSetAng(181.0);
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 41000; // 0x0000A028, 第一章 / 3-2-3.风水惊变 / 进入秘道
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2004()
{
    if (global_mvar == 41000 /* 第一章 / 3-2-3.风水惊变 / 进入秘道 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giFlashOutBlack(1.5, true, true);
        giHideGASkillObject();
        giMonsterStopPursuit();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, 230.4189, 153.4516, -168.0094);
        giPlayerSetAng(0, 305.0);
        giPlayerSetPos(1, 201.5469, 153.4516, -78.7842);
        giPlayerSetAng(1, 290.0101);
        giPlayerSetPos(2, 142.968, 153.4516, -105.6654);
        giPlayerSetAng(2, 317.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giSetObjectVisible("entrance1", false);
        giSetObjectVisible("save1", false);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(3.0, false);
        giWait(0.5);
        giCameraRunSingle("003", false);
        giWait(2.5);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：这里！这里就是传说中的淮南王丹室呀！", "41828");
        giSetPortrait("106D", false);
        giTalk("柳梦璃：此处也同方才经过的后殿一样，不见任何鬼怪……", "41829");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：没有鬼怪，那就是大有玄机啰……我们先仔细找一找，说不定就能发现王陵闹鬼的原因了，而且这里又是丹室，或许还藏着什么仙丹灵药呢。", "41830");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(2, 247.0, false);
        giWait(0.4000000059604645);
        giCameraRunSingle("004", true);
        giWait(0.30000001192092896);
        giPlayerWalkTo(2, 107.0398, 153.4516, -134.6424, false);
        giWait(0.800000011920929);
        giIMMBegin();
        giPlayerSetDir(1, 229.0, false);
        giPlayerSetDir(0, 284.0, false);
        giIMMEnd();
        giPlayerEndMove(2);
        giPlayerSetDir(2, 272.0, true);
        giPlayerDoAction(2, "J03", -1, true);
        giWait(1.0);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：唔……玉鼎……灵丹……文…………", "41831");
        giSetPortrait("106A", true);
        giTalk("柳梦璃：这上面好像记载了一些和丹药有关的东西……", "41832");
        giSetPortrait("103B", true);
        giTalk("韩菱纱：真的吗？都写了些什么？！", "41833");
        giSetPortrait("106A", true);
        giTalk("柳梦璃：……各种丹药的炼制法……", "41834");
        giSetPortrait("106D", true);
        giTalk("柳梦璃：咦？最后这页……", "41835");
        giWait(0.5);
        giSetObjectVisible("MO001", false);
        giWait(0.5);
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerWalkTo(2, 159.0122, 153.4516, -115.9325, false);
        giIMMBegin();
        giPlayerSetAng(1, 238.0101);
        giCameraRunSingle("005", false);
        giIMMEnd();
        giPlayerEndMove(2);
        giPlayerSetDir(2, 69.0, true);
        giSetNpcVisible("MN001", true);
        giPlayerSetVisible(2, false);
        giIMMBegin();
        giNpcDoAction("MN001", "J15", -1, false);
        giWait(1.5);
        giIMMEnd();
        giWait(0.5);
        gi2DSoundPlay("WJ075", 1);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：“……夜半，王梦于青云之上，太一神君现明轮间，瑞气千重，光普三界，垂目示下尔……鸡鸣日出，炉紫气龙腾，顶现晕华，敛于赤绯玉壶，气凝若神丸，方知‘太仙霞丹’乃成，王与八公顿首而拜，心悦服食，终脱胎换骨，白日飞升！……”", "41836");
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：呀！这么说淮南王真的是做了神仙！", "41837");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", false);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：那个仙丹有这么神……书上说“敛于赤绯玉壶”，这壶又是什么东西？淮南王的冥宫里可没有这件明器作陪葬，是不是被人盗走了？", "41838");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetAng(0, 230.0);
        giCameraRunSingle("006", false);
        giObjectDoAction("MO002", "OJ17", 0, false);
        giWait(0.5);
        giPlayerDoAction(0, "Z01", 0, false);
        giWait(0.5);
        giSetPortrait("101I", true);
        giTalk("云天河：有杀气！很强！！", "41839");
        giIMMBegin();
        giPlayerSetDir(1, 206.0, false);
        giNpcSetDir("MN001", 211.0, false);
        giIMMEnd();
        giWait(0.800000011920929);
        giPlayerDoAction(1, "Z01", 0, false);
        giWait(0.5);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：哪里？！", "41840");
        giWait(1.7999999523162842);
        giSetPortrait("106D", false);
        giTalk("柳梦璃：…………", "41841");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：…………那个……杀气好像一会儿强……一会儿弱的……", "41842");
        giWait(0.30000001192092896);
        giPlayerWalkTo(1, 214.6787, 153.4516, -143.2533, false);
        giPlayerEndAction(0);
        giWait(0.5);
        giCameraRunSingle("007", true);
        giPlayerSetVisible(2, true);
        giSetNpcVisible("MN001", false);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 156.0, true);
        giPlayerDoAction(1, "J20", 1, false);
        giWait(0.30000001192092896);
        gi2DSoundPlay("WJ012", 1);
        giWait(1.2000000476837158);
        giPlayerSetDir(0, 328.0, true);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：杀什么杀！从一进淮南王陵就念个不停，有这工夫还不快帮忙找找宝贝！", "41843");
        giPlayerDoAction(0, "J21", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：痛……", "41844");
        giWait(1.5);
        gi2DSoundPlay("WJ021", 1);
        giWait(1.399999976158142);
        giPlayerSetDir(0, 241.0, true);
        giSetPortrait("101H", true);
        giTalk("云天河：菱纱你听到没？我没说错吧？", "41845");
        giPlayerSetDir(1, 224.0, true);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：糟糕！不会是碰到厉鬼了吧？", "41846");
        giWait(0.5);
        gi2DSoundPlay("WJ050", 0);
        giWait(0.5);
        giCameraRunSingle("008", true);
        giIMMBegin();
        giPlayerSetPos(2, 46.383, 153.4516, -185.6831);
        giPlayerSetAng(2, 286.0);
        giPlayerSetPos(1, 1.2493, 153.4516, -228.8398);
        giPlayerSetAng(1, 321.0101);
        giPlayerSetPos(0, -21.7279, 153.4516, -273.3336);
        giPlayerSetAng(0, 328.0);
        giIMMEnd();
        giWait(1.0);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：是那个壶发出的声音！大家小心！", "41847");
        giObjectDoAction("MO002", "OJ16", -1, false);
        gi2DSoundStop();
        giScriptMusicPlay("P44", 2, 0.0, 2.5);
        giSetObjectVisible("Jeffect002", true);
        giWait(1.5);
        giCameraRunSingle("030", false);
        gi2DSoundPlay("WJ051", 1);
        giWait(1.0);
        giSetNpcVisible("MN002", true);
        giSetObjectVisible("MO002", false);
        giNpcDoAction("MN002", "J01", -1, false);
        giSetPortrait("B05A", false);
        giTalk("？？：哈哈哈！本王重见天日了！！", "41848");
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", false);
        giCameraRunSingle("012", true);
        giSetPortrait("B05A", false);
        giTalk("？？：唔？！尔等何人？！", "41849");
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：本王？难道是……", "41850");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：笨……王……？", "41851");
        giSetPortrait("B05A", false);
        giTalk("？？：尔等竟敢如此无礼？！受死！", "41852");
        giFlashOutBlack(1.0, true, true);
        giIMMBegin();
        giPlayerDoAction(0, "C01", 1, false);
        giPlayerDoAction(1, "C01", 1, false);
        giPlayerDoAction(2, "C01", 1, false);
        giSetFullHP();
        giSetFullMP();
        giAddPlayerFavor(0, 1, 20);
        giAddPlayerFavor(0, 2, 30);
        giAddPlayerFavor(2, 0, 10);
        giSetObjectVisible("Jeffect002", false);
        giIMMEnd();
        giAddCombatMonster(2583, 1);
        giAddCombatMonster(2520, 0);
        giAddCombatMonster(2520, 2);
        giConfigCombatBgm("P44");
        giConfigCombatCamera("CA6");
        giConfigCombatGroundCamera("CA13");
        giConfigCombatParam(true, 0, 0, 0);
        giStartCombat("M07B");
        giScriptMusicPlay("P36", 2, 0.0, 2.5);
        giFlashInBlack(1.0, true);
        giSetPortrait("B05A", false);
        giTalk("淮南王：……尔等究竟何人？莫非是那妖道的门徒？！", "41853");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：你、你自称“本王”，难道是淮南王？！你不是已经成仙了？", "41854");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("B05A", false);
        giTalk("淮南王：成仙？", "41855");
        giSetPortrait("B05A", false);
        giTalk("淮南王：当初本王自是积功德、求仙道，却不想被一个无耻道士所欺，和八位贤人服下所谓“太仙霞丹”，反而送掉性命！", "41856");
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：啊！！", "41857");
        giSetPortrait("B05A", false);
        giTalk("淮南王：那妖道一心骗取荣华富贵，眼见酿成大祸，又心恐本王索命报复，便将本王与八公的魂魄封于赤绯玉壶，自行逃之夭夭！", "41858");
        giNpcDoAction("MN002", "J01", 1, false);
        giSetPortrait("B05A", false);
        giTalk("淮南王：如今真乃天助我也！", "41859");
        giSetPortrait("B05A", false);
        giTalk("淮南王：这玉壶力量渐失，尔等又闯入此间，有生人阳气为助力，本王与八公得以更早脱出，日后定要索那妖道性命！ ", "41860");
        giCameraRunSingle("016", false);
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：……我说老头你啊……你死都死了，还让手下写什么《玉鼎灵丹文》骗人，又把地宫修得神神秘秘，让姑娘我白白高兴一场！", "41861");
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：实在太可恶了！ ", "41862");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("B05A", false);
        giTalk("淮南王：大胆刁民！竟一再放肆！", "41863");
        giSetPortrait("103K", true);
        giTalk("韩菱纱：哼，老头，我劝你好好投胎去吧！", "41864");
        giSetPortrait("106G", true);
        giTalk("柳梦璃：世间改朝易代，你早已不是淮南王了，你要找的道士已经不在世上，你如何报仇？", "41865");
        giSetPortrait("B05A", false);
        giTalk("淮南王：……一派胡言！！", "41866");
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106G", true);
        giTalk("柳梦璃：你应该知道，你是在自欺欺人。", "41867");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giSetPortrait("B05A", false);
        giTalk("淮南王：好！那么本王即刻出去，杀光全天下的道士！以泄本王数载怨恨！！", "41868");
        giSetPortrait("106G", true);
        giTalk("柳梦璃：那些墓中的鬼魂可是因你而出？", "41869");
        giSetPortrait("B05A", false);
        giTalk("淮南王：鬼魂？", "41870");
        giNpcDoAction("MN002", "J01", 1, false);
        giSetPortrait("B05A", false);
        giTalk("淮南王：哈哈哈哈，看来本王的仆役也都醒了，如此甚妙！", "41871");
        giSetPortrait("106H", true);
        giTalk("柳梦璃：害你的人早已不在人世，你怎能以这股怨气伤及无辜？！", "41872");
        giSetPortrait("B05A", false);
        giTalk("淮南王：区区几个贱民竟然非议本王！本王就先吸干尔等的精血，再出去杀光全天下的道士！", "41873");
        giPlayerRunTo(0, -18.1165, 153.4518, -188.6737, true);
        giPlayerSetDir(0, 309.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(0, "Z01", 0, false);
        giSetPortrait("101I", true);
        giTalk("云天河：哼！又是一个先不仁的家伙，虽然你说的话我听不大懂，但我不会让你出去乱杀人的！", "41874");
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：（这野人被惹毛了……）", "41875");
        giSetPortrait("101I", true);
        giTalk("云天河：他也不怎么经打，刚刚都被打败了，我一个人就可以对付他！", "41876");
        giNpcDoAction("MN002", "J01", 1, false);
        giSetPortrait("B05A", false);
        giTalk("淮南王：哈哈！本王便让尔等见识见识八公的怨力！", "41877");
        giSetObjectVisible("Jeffect001", true);
        giPlayerDoAction(0, "J02", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：啥？！……八加一等于九……那个，我们要不要一起打？", "41878");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("106D", true);
        giTalk("柳梦璃：……", "41879");
        giSetPortrait("103F", true);
        giTalk("韩菱纱：（真想揍扁你这笨蛋……）", "41880");
        giCameraRunSingle("033", false);
        giSetObjectVisible("Jeffect001", false);
        giEffectPlayWithNPC("H_095", 1, "MN002");
        giWait(1.0);
        giIMMBegin();
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("MN003", true);
        giIMMEnd();
        giWait(0.6000000238418579);
        giNpcDoAction("MN003", "X02", 1, false);
        giWait(1.5);
        giFlashOutBlack(1.0, true, true);
        giSetFullHP();
        giSetFullMP();
        giAddCombatMonster(2584, 1);
        giConfigCombatBgm("P44");
        giConfigCombatCamera("CA6");
        giConfigCombatGroundCamera("CA13");
        giConfigCombatParam(true, 0, 0, 0);
        giStartCombat("M07B");
        giScriptMusicPlay("P35", 2, 0.0, 0.0);
        giIMMBegin();
        giCameraRunSingle("031", false);
        giPlayerSetPos(0, -5.4877, 153.4516, -169.5293);
        giPlayerSetAng(0, 314.0);
        giPlayerSetPos(1, -57.4002, 153.4517, -202.7735);
        giPlayerSetAng(1, 356.0);
        giSetNpcVisible("MN002", true);
        giSetNpcVisible("MN003", false);
        giIMMEnd();
        giFlashInBlack(1.0, true);
        giWait(0.4000000059604645);
        giSetPortrait("B05A", false);
        giTalk("淮南王：不可能！这不可能……", "41881");
        giCameraRunSingle("032", false);
        giNpcDoAction("MN002", "J01", -1, false);
        giSetPortrait("B05A", false);
        giTalk("淮南王：本王……本王还要千秋……万代……与……天同……寿…………", "41882");
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", false);
        giSetPortrait("B05A", false);
        giTalk("淮南王：……我不甘心……我……诅咒……你们…………", "41883");
        giNpcDoAction("MN002", "J02", 1, false);
        gi2DSoundPlay("WJ076", 1);
        giWait(0.5);
        giEffectPlayWithNPC("H_096", 1, "MN002");
        giNpcBlendOut("MN002", 2.3, true);
        giSetNpcVisible("MN002", false);
        giCameraWait();
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(2, -89.0162, 153.4516, -169.2789);
        giPlayerSetAng(2, 9.0);
        giIMMEnd();
        giCameraRunSingle("018", false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：好险……还以为这次真的要去见玉皇大帝了呢……", "41884");
        giIMMBegin();
        giPlayerFaceToPlayer(0, 1, false);
        giPlayerSetDir(2, 135.0, false);
        giIMMEnd();
        giWait(0.800000011920929);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：为什么去见玉黄大弟？他大哥是谁？", "41885");
        giSetPortrait("106B", true);
        giTalk("柳梦璃：幸好……这淮南王生前求仙不成，心里怨恨极重，若是让他跑了出去，不知有多少百姓要遭殃……", "41886");
        giPlayerSetDir(1, 325.0, true);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：总之啊，都怪那臭老头不好！明明没有成仙，还故弄玄虚，浪费人家感情！", "41887");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：……还以为真的能找到长生不老药呢，结果又是空欢喜一场……", "41888");
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：讨厌讨厌讨厌！！", "41889");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：唔……菱纱你在找那种药，莫非是想长生不老吗？", "41890");
        giCameraRunSingle("021", true);
        giWait(0.5);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：…………", "41891");
        giWait(0.5);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：也许……也许我不该这么说，可是人生在世虽然只有短短数十年，只要能和喜欢的人在一起，也好过一个人孤孤单单过上百年千年……那样的日子，不是更让人痛苦……", "41892");
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：长生之法，人人艳羡，却又有几人真正明白自己想要什么——", "41893");
        giIMMBegin();
        giCameraRunSingle("019", true);
        giPlayerSetAng(1, 310.0);
        giPlayerSetAng(0, 238.0);
        giIMMEnd();
        giPlayerEndAction(1);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：不是的！你什么都不知道！", "41894");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("106E", false);
        giTalk("柳梦璃：……！", "41895");
        giSetPortrait("101D", false);
        giTalk("云天河：菱纱，你……", "41896");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：啊！对、对不起，我不是…………我只不过……只不过…………", "41897");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(1, 151.0, true);
        giWait(1.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：…………我……我要救人，我要找到长生药，救整个村子的人！", "41898");
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：如果我找不到，他们就要永远永远受苦下去……每次一想到这个……我就、我就…………", "41899");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：……都怪我不好……我真的什么都不知道……有没有可以帮你的？", "41900");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 310.0, true);
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：谢谢，可是……这是我们韩家的事……我不想再多说了……", "41901");
        giSetPortrait("101B", false);
        giTalk("云天河：呵呵，不说就不说，反正我帮你一起找就好了！", "41902");
        giIMMBegin();
        giCameraRunSingle("018", true);
        giPlayerSetAng(0, 230.0);
        giIMMEnd();
        giIMMBegin();
        giPlayerSetDir(1, 57.0, false);
        giPlayerSetDir(2, 97.0, false);
        giIMMEnd();
        giWait(0.800000011920929);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：原来你不是只会玩，还像爹说过的一样，救人于水火之中～他说这种人最了不起了！", "41903");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：……什、什么啊，你这野人突然说这么正经的话……", "41904");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerEndAction(1);
        giPlayerSetDir(0, 269.0, true);
        giWait(0.5);
        giSetPortrait("101B", false);
        giTalk("云天河：梦璃，你说过，看一个人顺眼，就会想要嫁给他对不对？", "41905");
        giSetPortrait("106D", true);
        giTalk("柳梦璃：是啊……", "41906");
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P23", 2, 2.5, 0.0);
        giPlayerSetDir(0, 230.0, true);
        giWait(0.5);
        giSetPortrait("101K", false);
        giTalk("云天河：哈哈，菱纱！我越看你越顺眼，干脆我嫁给你～以后我们俩都一起玩，找什么东西也可以一起找！", "41907");
        giSetPortrait("106E", true);
        giTalk("柳梦璃：………………", "41908");
        giSetPortrait("103D", true);
        giTalk("韩菱纱：………………", "41909");
        giWait(0.5);
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("106C", true);
        giTalk("柳梦璃：噗～～～", "41910");
        giIMMBegin();
        giCameraRunSingle("021", false);
        giPlayerSetAng(2, 107.0);
        giIMMEnd();
        giPlayerWalkTo(1, -21.5495, 153.4517, -181.7618, true);
        giPlayerDoAction(1, "J20", 1, false);
        giWait(0.30000001192092896);
        gi2DSoundPlay("WJ012", 1);
        giWait(1.5);
        giPlayerDoAction(0, "J21", -1, false);
        giSetPortrait("103K", false);
        giTalk("韩菱纱：你！你白痴啊！！猪头！！什么嫁、嫁给我！我才不要你这种野人！！", "41911");
        giWait(0.4000000059604645);
        giSetPortrait("101E", true);
        giTalk("云天河：痛！", "41912");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerEndAction(1);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103G", false);
        giTalk("韩菱纱：不！不对，根本不是这个问题！", "41913");
        giSetPortrait("103G", false);
        giTalk("韩菱纱：气死我了！不晓得是不是上辈子作了什么孽，这辈子遭报应才遇到你！", "41914");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：菱、菱纱，你别气……你脸都红了，是不是气上不来……", "41915");
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103G", false);
        giTalk("韩菱纱：多话！我哪有脸红！哼！！", "41916");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.6000000238418579);
        giPlayerRunTo(1, -107.9268, 153.4517, -283.9083, true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：……又怎么了？她今天特别生气……", "41917");
        giPlayerDoAction(2, "J14", 1, true);
        giWait(0.6000000238418579);
        giPlayerWalkTo(2, -45.7826, 153.4517, -167.7854, true);
        giPlayerSetDir(2, 107.0, true);
        giWait(0.5);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：云公子……", "41918");
        giPlayerSetDir(0, 268.0, false);
        giCameraRunSingle("034", true);
        giWait(0.5);
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：你看菱纱很顺眼，所以就想要“嫁”给她？", "41919");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：是啊。不过我看你也很顺眼就是了，可以的话，我嫁你们两个，以后我们三个都一起四处玩，找什么东西也一起找！", "41920");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：云公子，只有女孩子才能嫁人，男孩子是不能嫁的～", "41921");
        giPlayerDoAction(0, "J02", -1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：啊？那男孩子不是很可怜？", "41922");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("106C", false);
        giTalk("柳梦璃：……噗～", "41923");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：……？", "41924");
        giPlayerEndAction(0);
        giSetPortrait("106C", false);
        giTalk("柳梦璃：没什么，给你这样一闹，至少菱纱没那么伤心了～我们也快点离开这儿吧。", "41925");
        giSetPortrait("101B", true);
        giTalk("云天河：是、是吗？好！", "41926");
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetPos(0, -1028.574, 0.1623, -122.566);
        giPlayerSetPos(1, -1028.574, 0.1623, -122.566);
        giPlayerSetPos(2, -1028.574, 0.1623, -122.566);
        giIMMEnd();
        giCameraRunSingle("023", true);
        giWait(0.5);
        giPlayerWalkTo(1, -1267.8129, 0.1623, -124.5505, false);
        giWait(0.800000011920929);
        giPlayerWalkTo(0, -1247.6104, 0.1623, 43.5332, false);
        giWait(0.800000011920929);
        giPlayerWalkTo(2, -1188.5195, 0.1623, -65.6838, false);
        giFlashInBlack(1.5, false);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 311.0, true);
        giPlayerEndMove(2);
        giPlayerSetDir(2, 261.0, true);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 241.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：……你们看，<colour red=255 green=187 blue=0 alpha=255>这儿又有个机关。</colour>", "41927");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：我猜<colour red=255 green=187 blue=0 alpha=255>只要解开它，丹室里就会打开其他的路了。</colour>", "41928");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：那我们快些试试吧～", "41929");
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giShowSignpost();
        giSetObjectVisible("entrance1", true);
        giSetObjectVisible("save1", true);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giIMMEnd();
        var_mo = 0;
        giPlayerCurrentSetVisible(true);
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 41602; // 0x0000A282, 第一章 / 3-2-4.风水惊变 / 破解机关
        giScriptMusicStop(1, 2.5);
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2005()
{
    if (global_mvar == 41602 /* 第一章 / 3-2-4.风水惊变 / 破解机关 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giHideGASkillObject();
        giFlashOutBlack(0.5, true, true);
        giArenaLoad("M07", "8", "", true);
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, -2166.3997, 15.9974, 1886.6058);
        giPlayerSetPos(1, -2166.3997, 15.9974, 1886.6058);
        giPlayerSetPos(2, -2166.3997, 15.9974, 1886.6058);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giSetObjectVisible("entrance2", false);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giPlayerWalkTo(1, -2019.1188, 9.5466, 1910.9849, true);
        giWait(1.0);
        giPlayerSetDir(1, 212.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：这……天呐！", "41930");
        giPlayerEndAction(1);
        giPlayerWalkTo(0, -1982.2819, 9.4838, 1777.9095, false);
        giWait(1.0);
        giPlayerWalkTo(2, -1942.007, 9.5602, 1866.573, false);
        giWait(0.6000000238418579);
        giPlayerRunTo(1, -1902.9191, 9.6241, 1797.9391, true);
        giPlayerSetDir(1, 180.0, true);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 142.0, true);
        giPlayerEndMove(2);
        giPlayerSetDir(2, 158.0, true);
        giWait(0.4000000059604645);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：有人、有人把淮南王的冥宫风水给破了！难怪那些鬼怪都跑出来！", "41931");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("106D", false);
        giTalk("柳梦璃：菱纱，你是说……墓道中的厉鬼和淮南王要从玉壶里出来，并无半点因由？", "41932");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("003", false);
        giPlayerSetAng(2, 151.0);
        giPlayerSetAng(1, 338.0);
        giPlayerSetAng(0, 20.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：……嗯，话这么说也没错啦！", "41933");
        giSetPortrait("103G", false);
        giTalk("韩菱纱：（呃……我竟然被野人感染，说话跟他一样……）", "41934");
        giWait(0.5);
        giPlayerDoAction(2, "J13", 1, false);
        giWait(0.5);
        giSetPortrait("106D", true);
        giTalk("柳梦璃：我虽不懂风水之说，但也明白这种事关系甚大，莫非是有人和淮南王结下了深仇大怨？", "41935");
        giPlayerEndAction(2);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……是有这种可能。", "41936");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：我倒觉得弄得这么乱七八糟，或许只是不懂事的小毛贼，一味蛮干，闯了大祸自己都不一定晓得……", "41937");
        giSetPortrait("103C", false);
        giTalk("韩菱纱：唉～墓道吹着这种怪风，冥宫里肯定被破坏得更厉害，那帮白痴……丢脸……", "41938");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：……", "41939");
        giIMMBegin();
        giCameraRunSingle("002", true);
        giPlayerSetAng(2, 168.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：梦璃你放心～淮南王老头选的风水还不是顶好，这地宫虽然在龙脉处，但怎么看也只是个小旁支，就算风水骤变，也成不了灭族绝后的大凶地。", "41940");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：可是这些鬼怪不会出去害人吗？", "41941");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：算是不幸中的大幸吧～这儿如今成了地缚之象，怨魂都被束缚住，跑不出地宫，以后我们找个厉害的道士来收魂，也算做件大好事！", "41942");
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：但愿不要有人误闯进来，枉送了性命……", "41943");
        giSetPortrait("103M", false);
        giTalk("韩菱纱：嘻嘻～这种地方，除非是亡命之徒，寻常人应该不会想靠近吧？", "41944");
        giPlayerSetDir(0, 60.0, true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：菱纱，我不懂……风水被弄坏了，可是你那么厉害，再把它改回来不就好了？", "41945");
        giIMMBegin();
        giPlayerSetDir(1, 258.0, false);
        giPlayerSetDir(2, 205.0, false);
        giIMMEnd();
        giWait(0.800000011920929);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：……说什么傻话，你当改风水跟吃吃喝喝一样简单呐，弄得不好可要遭天谴的！", "41946");
        giSetPortrait("101A", true);
        giTalk("云天河：哦……", "41947");
        giSetPortrait("103F", false);
        giTalk("韩菱纱：你可别想跑进冥宫胡闹哦！", "41948");
        giSetPortrait("103F", false);
        giTalk("韩菱纱：那是淮南王安置棺椁的地方，机关重重，现在更成了凶地，我们几个就这样进去，有几条命都不够死的！", "41949");
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：……不会，我随便问问……", "41950");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：哼，最好是这样！刚才的事我可还没原谅你，再惹麻烦就给我小心点！", "41951");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：……刚才的事？什么事啊？", "41952");
        giSetPortrait("103E", false);
        giTalk("韩菱纱：………………", "41953");
        giPlayerSetDir(2, 168.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：……菱纱，我看我们还是快找出口吧，这儿的风吹得人好不舒服…… ", "41954");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giIMMBegin();
        giPlayerSetDir(1, 343.0, false);
        giPlayerSetDir(0, 21.0, false);
        giIMMEnd();
        giWait(0.800000011920929);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：嗯，我记得<colour red=255 green=187 blue=0 alpha=255>那条通向碗丘山的捷径就在附近，过了碗丘山便是陈州，</colour><dc0>脚程快些午后一定可以到～</dc0>", "41955");
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giSetObjectVisible("entrance2", true);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 50100; // 0x0000C3B4, 离开王墓
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func3001()
{
    if (var_zhu == 2)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giHideGASkillObject();
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 427.8828, -300.5569, -1126.3864);
        giPlayerSetPos(1, 364.8295, -300.3782, -1077.6274);
        giPlayerSetPos(3, 487.2825, -284.4798, -978.0842);
        giPlayerSetAng(3, 38.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giMonsterSetHide("m07-08-03", false);
        giSetNpcVisible("SN001", true);
        giSetNpcVisible("SN002", true);
        giSetNpcVisible("SN003", true);
        giSetNpcVisible("SN004", true);
        giSetNpcVisible("SN005", true);
        giSetNpcVisible("SN006", true);
        giSetNpcVisible("SN007", true);
        giSetNpcVisible("SN008", true);
        giSetObjectVisible("save1", false);
        giIMMEnd();
        giCameraPrepare("yan003");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, false);
        giArenaReady();
        gi2DSoundPlay("WE104", 1);
        giWait(2.0);
        giCameraRunSingle("003", true);
        giIMMBegin();
        giPlayerSetVisible(3, true);
        giSetNpcVisible("SN010", true);
        giSetNpcVisible("SN011", true);
        giCameraRunSingle("002", true);
        giIMMEnd();
        gi2DSoundPlay("WE104", 1);
        giPlayerDoAction(3, "Z01", 0, false);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：畜生！休要伤人！", "");
        giPlayerRunTo(1, 425.625, -285.8733, -1006.6502, false);
        giPlayerRunTo(0, 492.2445, -295.2713, -1031.5636, true);
        giPlayerEndMove(1);
        giPlayerSetAng(1, 50.0);
        giPlayerEndMove(0);
        giPlayerSetAng(0, 8.0);
        giPlayerDoAction(1, "Z01", 0, false);
        giPlayerDoAction(0, "Z01", 0, false);
        giSetPortrait("104F", false);
        giTalk("韩菱纱：紫英，我们来帮你！", "");
        giFlashOutBlack(1.0, true, true);
        giPlayerOutTeam(2, false);
        giAddCombatMonster(2513, 1);
        giAddCombatMonster(2514, 0);
        giConfigCombatParam(true, 0, 0, 0);
        giStartCombat("M07D");
        giIMMBegin();
        giPlayerSetPos(0, 593.5945, -280.0303, -954.2537);
        giPlayerSetAng(0, 44.0);
        giPlayerSetPos(1, 597.4617, -279.043, -905.3275);
        giPlayerSetAng(1, 58.0);
        giPlayerSetPos(3, 561.7919, -273.1056, -901.0435);
        giPlayerSetAng(3, 66.0);
        giNpcSetPos("SN010", 581.1267, -252.9291, -724.9929);
        giNpcSetAng("SN010", 136.0);
        giNpcSetPos("SN011", 622.6912, -260.2728, -741.7756);
        giNpcSetAng("SN011", 168.0);
        giNpcSetPos("SN005", 679.6037, -276.3899, -824.5851);
        giNpcSetAng("SN005", 336.0);
        giNpcSetPos("SN006", 730.1467, -278.9036, -845.7169);
        giNpcSetAng("SN006", 334.0);
        giNpcSetPos("SN007", 707.0564, -279.6475, -884.9646);
        giNpcSetAng("SN007", 342.0);
        giNpcSetPos("SN008", 676.1564, -276.588, -872.8989);
        giNpcSetAng("SN008", 338.0);
        giSetNpcVisible("SN001", false);
        giSetNpcVisible("SN002", false);
        giSetNpcVisible("SN003", false);
        giSetNpcVisible("SN004", false);
        giSetNpcVisible("SN011", false);
        giSetNpcVisible("SN012", true);
        giSetObjectVisible("SO001", true);
        giPlayerInTeam(2, false);
        giPlayerDoAction(0, "C01", 0, false);
        giPlayerDoAction(1, "C01", 0, false);
        giPlayerDoAction(3, "C01", 0, false);
        giSetNpcVisible("SN021", true);
        giSetNpcVisible("SN020", true);
        giIMMEnd();
        giCameraRunSingle("004", true);
        giFlashInBlack(1.5, true);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：呼～你们，没有人受伤吧？", "");
        giCameraRunSingle("005", true);
        giTalk("猎户：头头头头头…………", "");
        giTalk("青年：头掉下来了！", "");
        giWait(0.5);
        giCameraRunSingle("006", true);
        giWait(0.5);
        giSetPortrait("104D", false);
        giTalk("韩菱纱：呀——！大大大、大姐相公的头——", "");
        giTalk("猎户：身、身体和头都分了家，还不见血！那人一定是妖怪！", "");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(0, 536.3127, -264.0049, -861.6193);
        giPlayerSetAng(0, 12.0);
        giPlayerSetPos(1, 587.7548, -268.2159, -842.6828);
        giPlayerSetAng(1, 30.0);
        giPlayerSetPos(3, 524.2389, -256.8148, -820.4039);
        giPlayerSetAng(3, 40.0);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giWait(0.5);
        giIMMBegin();
        giEffectPlayWithNPC("EFF6", 1, "SN020");
        giEffectPlayWithNPC("EFF6", 1, "SN021");
        giNpcBlendOut("SN020", 2.0, false);
        giNpcBlendOut("SN021", 2.0, false);
        giIMMEnd();
        giWait(1.0);
        giTalk("青年：妖怪会吃人！我们快逃！", "");
        giNpcWalkTo("SN005", 809.4234, -293.0172, -672.8063, false);
        giNpcWalkTo("SN006", 831.8962, -292.0008, -738.7433, false);
        giNpcWalkTo("SN007", 831.8962, -292.0008, -738.7433, false);
        giNpcWalkTo("SN008", 809.4234, -293.0172, -672.8063, false);
        giWait(1.0);
        giCameraRunSingle("008", false);
        giNpcWalkTo("SN010", 585.3642, -260.6376, -783.0906, true);
        giNpcDoAction("SN010", "C09", 1, false);
        giTalk("夙莘：唉，看样子陈州也不能待了……不过这些人真没礼貌，自己打猎时惹了祸，好心救他们还被当妖怪……", "");
        giSetPortrait("104D", false);
        giTalk("韩菱纱：大姐……", "");
        giTalk("夙莘：不怕不怕，小事一桩～", "");
        giNpcWalkTo("SN010", 606.4326, -262.2827, -774.7669, true);
        giNpcSetAng("SN010", 76.0);
        giCameraRunSingle("009", true);
        giNpcDoAction("SN010", "J02", -1, true);
        giWait(0.5);
        giSetObjectVisible("SO001", false);
        giNpcUnHoldAct("SN010");
        giNpcEndAction("SN010", true);
        giWait(0.30000001192092896);
        giNpcSetDir("SN010", 28.0, true);
        giNpcDoAction("SN010", "J01", -1, true);
        giWait(0.5);
        giIMMBegin();
        giSetNpcVisible("SN011", true);
        giSetNpcVisible("SN012", false);
        giIMMEnd();
        giWait(0.5);
        giNpcUnHoldAct("SN010");
        giNpcEndAction("SN010", true);
        giWait(1.0);
        giNpcEndMove("SN008");
        giIMMBegin();
        giNpcSetPos("SN010", 584.8843, -256.2776, -748.2605);
        giNpcSetPos("SN011", 610.1741, -261.7554, -766.6501);
        giNpcSetAng("SN010", 208.0);
        giNpcSetAng("SN011", 208.0);
        giPlayerSetAng(0, 26.0);
        giPlayerSetAng(1, 0.0);
        giSetNpcVisible("SN005", false);
        giSetNpcVisible("SN006", false);
        giSetNpcVisible("SN007", false);
        giSetNpcVisible("SN008", false);
        giCameraRunSingle("010", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：师叔！您这是……", "");
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：太厉害了！太好玩了！头掉了还能接回去，怎么做的？能不能教我？！", "");
        giNpcDoAction("SN010", "C09", 1, false);
        giTalk("夙莘：那可不行～冷毅是我做的机关人，头自然能接回去，换了其他人，不早就一命呜呼了～", "");
        giNpcEndAction("SN010", true);
        giWait(0.30000001192092896);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：机关人？可是，他和寻常人一样，会走路、会做动作，还能和你说话……", "");
        giWait(0.5);
        giSetPortrait("104D", false);
        giTalk("韩菱纱：难道……大姐你通晓传说中“偃师”的技艺？！", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("011", true);
        giWait(0.5);
        giTalk("夙莘：唔，看不出小姑娘年纪轻轻，见识却不浅～", "");
        giWait(0.5);
        giTalk("夙莘：你猜的没错，我曾蒙一位老人传授绝技，能够以各种材料制成机关，无论是七巧暗器，亦或飞禽走兽，任何东西都可以做出。", "");
        giWait(0.5);
        giTalk("夙莘：偶尔……将附着法力的“咒”与机关融为一体，也会诞生像冷毅这样的机关人，但这却已是很难得的秘术了。", "");
        giCameraRunSingle("012", true);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：那……大姐你又说，“他”是你相公？", "");
        giTalk("夙莘：哈哈，谁让世间男子多半长得不堪入目，我做一个长相英俊的，天天看着，心里也舒坦得很～", "");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：……英……英俊……他吗？", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("夙莘：当然！他要是活人，可就是我生平仅见的美男子了。", "");
        giSetPortrait("104E", true);
        giTalk("韩菱纱：…………", "40122; 40211; 40370; 40558; 40583; 40781; 40822; 41077; 41526; 41891; 41958; 41961; 42503; 42859; 43528; 44183; 44769; 44860; 44873; 44920; 45073; 46205; 46216; 46371; 46521; 46566; 46610; 46744; 46763");
        giWait(0.4000000059604645);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：师叔……不知能否即刻启程，随弟子回琼华派？", "");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giNpcDoAction("SN010", "C09", 1, false);
        giTalk("夙莘：你怎么还不死心呀？在陈州街头遇上你时，我就说不想回去了，要不是你请我喝酒……", "");
        giTalk("夙莘：再说你刚才也亲眼看到，这些年来我沉迷于做机关，什么仙术剑术早就荒废了，要不是有冷毅护着，寻常野兽都能伤到我，回去又能怎样？当初闹脾气信誓旦旦跑下山来，如今还要被同门嘲笑吗？", "");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：师叔，自从您十年前下山，掌门一直十分挂念，嘱咐派中弟子若是见到您，定要请您回去！", "");
        giWait(0.5);
        giTalk("夙莘：…………夙瑶师姐……", "");
        giNpcSetDir("SN010", 40.0, true);
        giCameraRunSingle("013", true);
        giTalk("夙莘：哎哎哎哎哎～我都下山这么多年，除了有冷毅陪着，一个人独来独往惯了，谁还要再去理那种婆婆妈妈的事……", "");
        giWait(0.5);
        giTalk("夙莘：师姐……整个门派我最服的就是你了……你这样，叫我怎么办才好……唉～～", "");
        giTalk("夙莘：…………", "");
        giWait(0.5);
        giNpcDoAction("SN010", "J02", -1, true);
        giWait(1.0);
        giFlashOutBlack(1.5, true, true);
        giWait(1.5);
        giIMMBegin();
        giNpcWalkTo("SN010", 560.0756, -256.7407, -778.882, false);
        giPlayerSetAng(1, 334.0);
        giPlayerSetPos(0, 547.8403, -263.7862, -847.9401);
        giPlayerSetAng(0, 10.0);
        giCameraRunSingle("014", true);
        giIMMEnd();
        giFlashInBlack(1.0, true);
        giNpcEndMove("SN010");
        giNpcDoAction("SN010", "J02", -1, true);
        giWait(0.5);
        giSetObjectVisible("SO002", true);
        giWait(0.5);
        giNpcUnHoldAct("SN010");
        giNpcEndAction("SN010", true);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：师叔，这是……？", "");
        giTalk("夙莘：紫英，请你帮我把这个箱子带回琼华派，师姐要是问起我怎么不回去，你就当着她的面打开箱子，她，应该会明白吧……", "");
        giWait(0.6000000238418579);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……是，弟子遵命。", "");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerDoAction(3, "J03", -1, true);
        giWait(0.5);
        giSetObjectVisible("SO002", false);
        giWait(0.5);
        giAddProperty(3244, 1, true);
        giWait(2.0);
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giTalk("夙莘：行了，没事的话，我要走了。", "");
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：等、等等！你不是会做可以动的木头老鼠吗？能不能给我一只？我买酒来跟你换～", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giTalk("夙莘：什么？！你这孩子怎么不早说？老鼠已经被我换酒换完了，和别人谈只能换到一小壶，你是我师侄的师侄，好歹也要给我两壶吧，可惜可惜……亏了亏了……", "");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", true);
        giTalk("云天河：现在说……来不及了吗？", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giTalk("夙莘：当然，别小看小小的机关鼠，做它的材料可不好找……算了算了，这个东西先拿去玩儿，以后有缘再见，我再送你一只好了～", "");
        giWait(0.20000000298023224);
        giAddProperty(3089, 5, true);
        giWait(2.299999952316284);
        giIMMBegin();
        giPlayerSetPos(0, 598.4139, -271.3161, -853.9554);
        giPlayerSetAng(0, 330.0);
        giPlayerSetPos(1, 637.7953, -275.7664, -855.1952);
        giPlayerSetAng(1, 314.0);
        giNpcSetAng("SN010", 68.0);
        giCameraRunSingle("015", true);
        giIMMEnd();
        giWait(0.30000001192092896);
        giTalk("夙莘：冷毅，咱们走了。", "");
        giWait(0.5);
        giNpcWalkTo("SN010", 463.45, -225.1979, -707.4812, false);
        giNpcWalkTo("SN011", 523.6918, -243.9564, -717.3804, false);
        giCameraRunSingle("016", false);
        giWait(1.0);
        giPlayerSetDir(3, 332.0, true);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：师叔！", "");
        giNpcEndMove("SN010");
        giNpcEndMove("SN011");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.30000001192092896);
        giCameraWait();
        giWait(0.30000001192092896);
        giTalk("夙莘：……小紫英，我离开昆仑山时，你才九岁，还有点胖胖的，像个面团儿，想不到一晃眼已经长成一个好男人了……", "");
        giWait(0.5);
        giTalk("夙莘：唉，妖界又快来了吧？你可得保重，千万别一不小心香消玉殒了，哈哈。", "");
        giSetPortrait("105E", true);
        giTalk("慕容紫英：师叔……", "");
        giWait(0.5);
        giTalk("夙莘：我啊，最讨厌离别时不干脆，所以别再说什么了，就让我这样走吧。", "");
        giNpcWalkTo("SN010", 390.3301, -193.5889, -624.9967, false);
        giNpcWalkTo("SN011", 405.901, -196.6524, -627.4835, false);
        giWait(1.7000000476837158);
        giCameraRunSingle("018", true);
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：什么“香消玉殒”，这大姐讲话好乱七八糟……不过，她真的好潇洒，叫人羡慕……", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("017", true);
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：师叔的性情原本并非如此，也不知这十年间究竟发生过什么……", "");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", false);
        giTalk("云天河：她说有缘再见，才给我老鼠，那要是以后都见不到，我的老鼠怎么办呀……", "");
        giPlayerEndAction(0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giSetNpcVisible("SN005", false);
        giSetNpcVisible("SN006", false);
        giSetNpcVisible("SN007", false);
        giSetNpcVisible("SN008", false);
        giSetNpcVisible("SN011", false);
        giSetNpcVisible("SN010", false);
        giPlayerSetVisible(3, false);
        giPlayerSetVisible(1, false);
        giSetObjectVisible("save1", true);
        giIMMEnd();
        var_zhu = 3;
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giPlayerCurrentSetVisible(true);
        giCameraSetMode(5, true);
        giTimeScript(180.0, "func9001");
        giShowSignpost();
        giFlashInBlack(1.0, true);
        giPlayerUnLock();
    }
}

void func7001()
{
    int puzzle_game_result = 0;

    if (giGetVisibleObject("entrance2"))
    {
        gi2DSoundPlay("wa03", 1);
        giShowHint("机关已经开启", 0.5, 0.15);
    }
    else
    {
        giPlayerLock();
        giMonsterStopPursuit();
        giShowTutorial(12);
        giStartPuzzleGame(0);
        puzzle_game_result = giGetPuzzleGameResult();
        if (giGetPuzzleGameResult() > 0)
        {
            giWait(0.30000001192092896);
            gi2DSoundPlay("we199", 1);
            giObjectDoAction("huaRongDoor01_key", "B", -1, true);
            giCameraSetCollide(false);
            giCameraPrepare("viewDoor01");
            giCameraRunSingle("viewDoor01", true);
            giGOMTouch("huaRongDoor01");
            giWait(5.0);
            giSetObjectVisible("entrance2", true);
            giWait(0.800000011920929);
            giIMMBegin();
            giCameraSetMode(5, true);
            giCameraAutoSeek(true);
            giCameraSeekToPlayer();
            giIMMEnd();
        }
        giPlayerUnLock();
    }
}

void func7002()
{
    int puzzle_game_result = 0;

    if (giGetVisibleObject("entrance1"))
    {
        gi2DSoundPlay("wa03", 1);
        giShowHint("机关已经开启", 0.5, 0.15);
    }
    else
    {
        giPlayerLock();
        giMonsterStopPursuit();
        giStartPuzzleGame(1);
        puzzle_game_result = giGetPuzzleGameResult();
        if (giGetPuzzleGameResult() > 0)
        {
            giWait(0.30000001192092896);
            gi2DSoundPlay("we199", 1);
            giObjectDoAction("huaRongDoor02_key", "B", -1, true);
            giCameraSetCollide(false);
            giCameraPrepare("viewDoor02");
            giCameraRunSingle("viewDoor02", true);
            giGOMTouch("huaRongDoor02");
            giWait(5.0);
            giSetObjectVisible("entrance1", true);
            giWait(0.800000011920929);
            giIMMBegin();
            giCameraSetMode(5, true);
            giCameraAutoSeek(true);
            giCameraSeekToPlayer();
            giIMMEnd();
        }
        giPlayerUnLock();
    }
}

void func7003()
{
    int puzzle_game_result = 0;

    if (giGetVisibleObject("entrance5"))
    {
        gi2DSoundPlay("wa03", 1);
        giShowHint("机关已经开启", 0.5, 0.15);
    }
    else
    {
        giPlayerLock();
        giMonsterStopPursuit();
        giStartPuzzleGame(2);
        puzzle_game_result = giGetPuzzleGameResult();
        if (giGetPuzzleGameResult() > 0)
        {
            giWait(0.30000001192092896);
            gi2DSoundPlay("we199", 1);
            giObjectDoAction("huaRongDoor03_key", "B", -1, true);
            giCameraSetCollide(false);
            giCameraPrepare("viewDoor03");
            giCameraRunSingle("viewDoor03", true);
            giGOMTouch("huaRongDoor03");
            giWait(5.0);
            giSetObjectVisible("entrance5", true);
            giWait(0.800000011920929);
            giIMMBegin();
            giCameraSetMode(5, true);
            giCameraAutoSeek(true);
            giCameraSeekToPlayer();
            giIMMEnd();
        }
        giPlayerUnLock();
    }
}

void func7004()
{
    int puzzle_game_result = 0;

    if (var_mo != 0)
    {
        if (var_mo != 2)
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("机关已经开启", 0.5, 0.15);
        }
        else
        {
            giIMMBegin();
            giGOMTouch("dy");
            giGOMTouch("NO006");
            giEventVolumeVisible("wall01", false);
            var_mo = 1;
            giIMMEnd();
        }
    }
    else
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giMonsterStopPursuit();
        giStartPuzzleGame(3);
        puzzle_game_result = giGetPuzzleGameResult();
        if (giGetPuzzleGameResult() <= 0)
        {
            giCameraSetCollide(true);
        }
        else
        {
            var_mo = 1;
            giWait(0.30000001192092896);
            giCameraPrepare("viewNO006");
            giCameraRunSingle("viewNO006_1", true);
            giCameraPrepare("viewNO006_r");
            giCameraRunCircle(false);
            giIMMBegin();
            giGOMTouch("dy");
            giGOMTouch("NO006");
            giEventVolumeVisible("wall01", false);
            giIMMEnd();
            giWait(6.800000190734863);
            giIMMBegin();
            giCameraSetMode(5, true);
            giCameraAutoSeek(true);
            giCameraSeekToPlayer();
            giIMMEnd();
        }
        giPlayerUnLock();
    }
}

void func7005()
{
    giPlayerLock();
    giFlashOutBlack(0.7, true, true);
    giIMMBegin();
    giCameraAutoSeek(false);
    giCameraSetCollide(false);
    giPlayerCurrentSetPos(28.17, 168.44, -7.58);
    giPlayerCurrentSetAng(90.0);
    giCameraPrepare("viewLadder");
    giCameraRunSingle("viewLadder", false);
    giIMMEnd();
    giWait(0.20000000298023224);
    giFlashInBlack(0.7, true);
    gi2DSoundPlay("wc001", -1);
    giGOBMovment("dy", 5.0, 4.2793, 240.4442, -9.9971, false);
    giGOBMovment("NO006", 5.0, 2.0434, 95.9517, -5.8805, false);
    giPlayerCurrentMovment(5.0, 28.17, 59.44, -7.58, false);
    var_mo = 2;
    giWait(5.0);
    gi2DSoundStop();
    func1023();
    giPlayerUnLock();
}

void func7006()
{
    int puzzle_game_result = 0;

    if (giGetVisibleObject("item102"))
    {
        gi2DSoundPlay("wa03", 1);
        giShowHint("机关已经开启", 0.5, 0.15);
    }
    else
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giMonsterStopPursuit();
        giStartPuzzleGame(4);
        puzzle_game_result = giGetPuzzleGameResult();
        if (giGetPuzzleGameResult() > 0)
        {
            giWait(0.30000001192092896);
            giCameraPrepare("viewBigBoom");
            giCameraRunSingle("viewBigBoom_1", true);
            giCameraRunSingle("viewBigBoom_2", false);
            giWait(1.5);
            giIMMBegin();
            gi2DSoundPlay("we040", 1);
            giSetObjectVisible("bigBoom_eff", true);
            giOBJBlendIn("item102", 1.5, false);
            giIMMEnd();
            giWait(1.2000000476837158);
            giOBJBlendOut("bigBoom_eff", 0.8, false);
            giWait(2.5);
            giIMMBegin();
            giCameraSetMode(5, true);
            giCameraAutoSeek(true);
            giCameraSeekToPlayer();
            giIMMEnd();
        }
        giPlayerUnLock();
    }
}

void func7007()
{
    giPlayerLock();
    giIMMBegin();
    giCameraAutoSeek(false);
    giPlayerCurrentSetPos(-1291.3263, 176.5731, 1705.832);
    giPlayerCurrentSetAng(174.0);
    giCameraPrepare("viewLadder_out");
    giCameraRunSingle("viewLadder_out", false);
    giIMMEnd();
    gi2DSoundPlay("wc001", -1);
    giWait(0.5);
    giFlashInBlack(1.5, true);
    giIMMBegin();
    giArenaReady();
    giGOBMovment("ladder", 3.0, -1279.7418, 105.5731, 1749.4895, false);
    giPlayerCurrentMovment(3.0, -1291.3263, 69.5731, 1705.832, false);
    giIMMEnd();
    giWait(2.0);
    giFlashOutBlack(0.8, true, true);
    giWait(0.4000000059604645);
}

void func7008()
{
    gi2DSoundPlay("we199", 1);
}

void func9001()
{
    string local_1 = "";
    int local_3 = 0;
    bool item202_visible = false;
    string local_5 = "";

    local_1 = "item";
    giIMMBegin();
    while (local_3 <= 99)
    {
        local_1 = "item";
        if (local_3 >= 10)
        {
            local_1 = "item" + "20" + "2";
        }
        else
        {
            local_1 = "item" + "20";
        }
        local_5 = "item" + "20" + "2";
        item202_visible = giGetVisibleObject("item" + "20" + "2");
        if (!giGetVisibleObject(local_5))
        {
            local_5 = "item" + "20" + "2";
            giGOBReset("item" + "20" + "2");
            local_5 = "item" + "20" + "2";
            giSetObjectVisible("item" + "20" + "2", true);
        }
    }
    giIMMEnd();
}
