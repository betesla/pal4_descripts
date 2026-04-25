// Structured PAL4 reconstruction for Q14.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void Q14_Q14W_init()
{
    if (global_mvar != 140101 /* 第三章 / 8-3-4.心愿 / 前往妖界 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2001();
    }
}

void Q14_Q14B_init()
{
    LL_001(global_mvar);
    if (global_mvar < 150300 /* 继位仪式 */)
    {
        giEventVolumeVisible("ev_Q14_Q14B_20", false);
    }
    if (global_mvar >= 150300 /* 继位仪式 */)
    {
        giSetObjectVisible("MO001", true);
    }
    if (global_mvar < 150100 && global_mvar >= 141400 /* 噩梦纷争 */)
    {
        giSetObjectVisible("title01", false);
    }
    if (global_mvar < 141400 || global_mvar >= 150100 /* 第三章 / 9-2-1.焚心以火 / 护卫幻瞑 */)
    {
        giEventVolumeVisible("ev_Q14_Q14B_21", false);
    }
    giArenaReadyRestore();
}

void Q14_BN06_init()
{
    if (global_mvar == 150100 /* 噩梦纷争 */)
    {
        func2006();
    }
    if (global_mvar > 140701 /* 第三章 / 8-4-2.妖界之主 / 里幻瞑宫 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giArenaReadyRestore();
    }
}

void Q14_LN01_init()
{
    if (global_mvar != 141100)
    {
        if (global_mvar != 150300 /* 继位仪式 */)
        {
            giArenaReadyRestore();
        }
        else
        {
            func2007();
        }
    }
    else
    {
        func2004();
    }
}

void Q14_BN07a_init()
{
    LL_001(global_mvar);
    giArenaReadyRestore();
}

void Q14_BN07b_init()
{
    LL_001(global_mvar);
    giArenaReadyRestore();
}

void Q14_BN07c_init()
{
    LL_001(global_mvar);
    giArenaReadyRestore();
}

void Q14_BN07e_init()
{
    LL_001(global_mvar);
    giArenaReadyRestore();
}

void Q14_BN08c_init()
{
    LL_001(global_mvar);
    giArenaReadyRestore();
}

void Q14_BN08b_init()
{
    LL_001(global_mvar);
    if (global_mvar < 141000 || global_mvar >= 150100)
    {
        giArenaReadyRestore();
    }
    else
    {
        giEventVolumeVisible("wall", false);
        giArenaReadyRestore();
    }
}

void Q14_BN08a_init()
{
    LL_001(global_mvar);
    giArenaReadyRestore();
}

void Q14_BN02_init()
{
    LL_001(global_mvar);
    giArenaReadyRestore();
}

void Q14_BN01_init()
{
    LL_001(global_mvar);
    giArenaReadyRestore();
}

void LL_001(int arg0)
{
    // typed_typeinfo_hints: primary=void; extras=[int]
    // prototype_hint: void LL_001(int)
    if (global_mvar <= 150100 /* 噩梦纷争 */)
    {
        giSetNpcVisible("4003", true);
        giSetNpcVisible("4004", true);
        giSetNpcVisible("4005", true);
        giSetNpcVisible("4022", true);
        giSetNpcVisible("4037", false);
        giSetNpcVisible("4038", false);
        giSetNpcVisible("4039", false);
        giSetNpcVisible("4040", false);
        giSetNpcVisible("4041", false);
        giSetNpcVisible("4042", false);
        giSetNpcVisible("4043", false);
    }
    else
    {
        giSetNpcVisible("4003", false);
        giSetNpcVisible("4004", false);
        giSetNpcVisible("4005", false);
        giSetNpcVisible("4022", false);
        giSetNpcVisible("4037", true);
        giSetNpcVisible("4038", true);
        giSetNpcVisible("4039", true);
        giSetNpcVisible("4040", true);
        giSetNpcVisible("4041", true);
        giSetNpcVisible("4042", true);
        giSetNpcVisible("4043", true);
    }
    if (global_mvar < 150100 && global_mvar >= 141000 /* 噩梦纷争 */)
    {
        giSetNpcVisible("4001", false);
        giSetNpcVisible("4002", false);
        giSetNpcVisible("4003", false);
        giSetNpcVisible("4004", false);
        giSetNpcVisible("4005", false);
        giSetNpcVisible("4006", false);
        giSetNpcVisible("4007", false);
        giSetNpcVisible("4008", false);
        giSetNpcVisible("4009", false);
        giSetNpcVisible("4010", false);
        giSetNpcVisible("4011", false);
        giSetNpcVisible("4012", false);
        giSetNpcVisible("4013", false);
        giSetNpcVisible("4014", false);
        giSetNpcVisible("4015", false);
        giSetNpcVisible("4016", false);
        giSetNpcVisible("4017", false);
        giSetNpcVisible("4018", false);
        giSetNpcVisible("4019", false);
        giSetNpcVisible("4020", false);
        giSetNpcVisible("4021", false);
        giSetNpcVisible("4022", false);
        giSetNpcVisible("4023", false);
        giSetNpcVisible("4024", false);
        giSetNpcVisible("4026", false);
        giSetNpcVisible("4027", false);
        giSetNpcVisible("4028", false);
        giSetNpcVisible("4030", false);
        giSetNpcVisible("4031", false);
        giSetNpcVisible("4032", false);
        giSetNpcVisible("4033", false);
        giSetNpcVisible("4034", false);
        giSetNpcVisible("4035", false);
        giSetNpcVisible("4036", false);
        giSetNpcVisible("4044", false);
        giSetNpcVisible("4045", false);
        giSetNpcVisible("4046", false);
    }
}

void func1001()
{
    giArenaLoad("Q14", "BN01", "", true);
    giPlayerCurrentSetPos(-2.912732, 2.010548, 434.2279);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(695.6951, 498.66687, -1575.653);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("Q14", "BN02", "", true);
    giPlayerCurrentSetPos(-1.559636, 0.123526, 439.3223);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(2309.1562, 1903.782, 34.188084);
    giPlayerCurrentSetAng(265.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("Q14", "BN03", "", true);
    giPlayerCurrentSetPos(0.891185, 0.315815, 285.2305);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(311.06192, 3090.554, 1313.9893);
    giPlayerCurrentSetAng(168.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1007()
{
    giArenaLoad("Q14", "BN04", "", true);
    giPlayerCurrentSetPos(-0.063976, 0.077475, 277.8711);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1008()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(3290.7322, 288.26974, 561.33594);
    giPlayerCurrentSetAng(256.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1009()
{
    giArenaLoad("Q14", "BN05", "", true);
    giPlayerCurrentSetPos(0.557633, 0.315607, 287.7969);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1010()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(442.72464, 1333.657, 1993.0416);
    giPlayerCurrentSetAng(188.0);
    giCameraSetMode(0, true);
    func7001();
    giArenaReady();
}

void func1011()
{
    if (global_mvar != 140700 /* 第三章 / 8-4-1.妖界之主 / 前往幻瞑宫 / 妖界幻瞑 */)
    {
        giArenaLoad("Q14", "BN06", "", true);
        giPlayerCurrentSetPos(-102.43082, -5.322325, 448.45377);
        giPlayerCurrentSetAng(178.0);
        giCameraSetMode(4, true);
        giArenaReady();
    }
    else
    {
        giFlashOutBlack(0.5, true, true);
        giArenaLoad("Q14", "BN06", "", true);
        func2002();
    }
}

void func1012()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(205.90262, -10.400408, 0.087272);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    func7001();
    giArenaReady();
}

void func1013()
{
    giArenaLoad("Q14", "BN07", "BN07a", true);
    giPlayerCurrentSetPos(-1.901463, 0.685106, 287.97253);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1014()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(2174.3118, 1742.9575, 1180.9858);
    giPlayerCurrentSetAng(238.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1015()
{
    giArenaLoad("Q14", "BN07", "BN07b", true);
    giPlayerCurrentSetPos(-1.901463, 0.685106, 287.97253);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1016()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(1531.6698, 1553.7642, 1851.6022);
    giPlayerCurrentSetAng(202.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1017()
{
    giArenaLoad("Q14", "BN07", "BN07c", true);
    giPlayerCurrentSetPos(-1.901463, 0.685106, 287.97253);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1018()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(-1287.4054, 1020.78955, 1093.2875);
    giPlayerCurrentSetAng(122.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1019()
{
    giArenaLoad("Q14", "BN07", "BN07d", true);
    giPlayerCurrentSetPos(-1.901463, 0.685106, 287.97253);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1020()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(2552.3428, 422.44104, -1588.9845);
    giPlayerCurrentSetAng(309.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1021()
{
    giArenaLoad("Q14", "BN07", "BN07e", true);
    giPlayerCurrentSetPos(-1.901463, 0.685106, 287.97253);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1022()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(2852.7617, 152.20424, 1537.3295);
    giPlayerCurrentSetAng(225.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1023()
{
    giArenaLoad("Q14", "BN08", "BN08a", true);
    giPlayerCurrentSetPos(-1.944156, 0.160021, 314.08557);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1024()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(1916.6395, 3253.1816, 311.3929);
    giPlayerCurrentSetAng(256.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1025()
{
    giArenaLoad("Q14", "BN08", "BN08b", true);
    giPlayerCurrentSetPos(-1.944156, 0.160021, 314.08557);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1026()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(-595.1271, 2565.5771, -1007.69);
    giPlayerCurrentSetAng(41.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1027()
{
    giArenaLoad("Q14", "BN08", "BN08c", true);
    giPlayerCurrentSetPos(-1.944156, 0.160021, 314.08557);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1028()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(1246.7115, 2226.979, -1621.328);
    giPlayerCurrentSetAng(336.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1029()
{
    giArenaLoad("Q14", "BN08", "BN08d", true);
    giPlayerCurrentSetPos(-1.944156, 0.160021, 314.08557);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1030()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(-949.3861, 644.2802, -1802.5532);
    giPlayerCurrentSetAng(37.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1031()
{
    giPlayerCurrentSetPos(-590.0, 60.0, -491.0);
    giPlayerCurrentSetAng(0.0);
}

void func1032()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(597.3971, 513.41675, -2461.2693, true);
    giPlayerCurrentSetAng(350.0);
    giSetPortrait("101A", true);
    giTalk("云天河：还是不要进去为好。", "");
    giPlayerUnLock();
}

void func1035()
{
    giArenaLoad("Q14", "Q14B", "", true);
    giPlayerCurrentSetPos(1160.3861, 3345.2803, -1176.5532);
    giPlayerCurrentSetAng(67.0);
    giCameraSetMode(0, true);
    func7001();
    giArenaReady();
}

void func1036()
{
    if (global_mvar < 141400 || global_mvar >= 150100 /* 第三章 / 9-2-1.焚心以火 / 护卫幻瞑 */)
    {
        giArenaLoad("Q14", "Q14W", "", true);
        giPlayerCurrentSetPos(1519.3861, 13.280212, -239.55322);
        giPlayerCurrentSetAng(85.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else if (global_mvar != 141400 /* 第三章 / 9-2-1.焚心以火 / 护卫幻瞑 */)
    {
        giArenaLoad("M18", "1", "", true);
        giPlayerCurrentSetPos(1430.5, 15.0, -248.45);
        giPlayerCurrentSetAng(120.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("M18", "1", "", true);
    }
}

void func1037()
{
    if (global_mvar != 141101 /* 幻瞑危机 */)
    {
        giArenaLoad("Q14", "Q14B", "", true);
        giPlayerCurrentSetPos(103.9375, 1.5895, -290.2201);
        giPlayerCurrentSetAng(324.0);
        giCameraSetMode(0, true);
        func7001();
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q14", "BN06", "", true);
        func2005();
    }
}

void func1038()
{
    giArenaLoad("Q14", "Q14L", "", true);
    giPlayerCurrentSetPos(199.1949, -3.4369, -310.4861);
    giPlayerCurrentSetAng(346.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1039()
{
    if (global_mvar != 150300 /* 继位仪式 */)
    {
        giArenaLoad("Q14", "LN01", "", true);
        giPlayerCurrentSetPos(-106.2423, -5.2223, 410.9973);
        giPlayerCurrentSetAng(176.0);
        giCameraSetMode(4, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q14", "LN01", "", true);
        func2007();
    }
}

void func1040()
{
    giArenaLoad("Q14", "Q14L", "", true);
    giPlayerCurrentSetPos(166.5128, -10.6957, -19.7966);
    giPlayerCurrentSetAng(262.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1041()
{
    giPlayerLock();
    giPlayerWalkTo(0, -204.5194, -19.5944, -35.3724, true);
    giPlayerSetDir(0, 90.0, true);
    giCameraAutoSeek(true);
    giCameraSetMode(0, true);
    giSetPortrait("101A", true);
    giTalk("云天河：那边不知道是哪里，现在还有其他重要的事要做。", "");
    giPlayerUnLock();
}

void func2001()
{
    if (global_mvar == 140101 /* 第三章 / 8-3-4.心愿 / 前往妖界 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P42", 2, 0.0, 0.0);
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 707.7809, 1.1657, 867.8119);
        giPlayerSetAng(0, 227.0);
        giPlayerSetPos(1, 724.6287, 1.1657, 834.9962);
        giPlayerSetAng(1, 217.0);
        giPlayerSetPos(2, 898.1188, 1.1657, 567.8783);
        giPlayerSetAng(2, 349.0);
        giPlayerSetPos(3, 777.4398, 1.1657, 890.6762);
        giPlayerSetAng(3, 242.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("4001", false);
        giSetNpcVisible("4022", false);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInWhite(2.5, false);
        giArenaReady();
        giCameraRunSingle("003", false);
        giWait(2.5);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：……妖界，看起来和人间果然差好多……", "45405");
        giCameraWait();
        giPlayerSetDir(0, 191.0, false);
        giPlayerSetDir(1, 206.0, true);
        giPlayerSetDir(3, 214.0, false);
        giWait(1.0);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：那个发光的球是啥？", "45406");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(1.0);
        giIMMBegin();
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giCameraRunSingle("004", false);
        giIMMEnd();
        giWait(0.5);
        giNpcWalkTo("MN001", 633.6993, 1.1657, 753.671, false);
        giNpcWalkTo("MN002", 689.8693, 1.1657, 740.7349, false);
        giCameraRunSingle("006", true);
        giNpcEndMove("MN001");
        giNpcEndMove("MN002");
        giTalk("瞳幽：……！！你们！是怎么穿过结界的？！", "45407");
        giPlayerSetPos(0, 686.761, 1.1657, 865.7856);
        giPlayerSetAng(0, 211.0);
        giPlayerSetPos(1, 735.6586, 1.1657, 859.0565);
        giPlayerSetAng(1, 231.0);
        giPlayerSetPos(3, 772.3665, 1.1657, 827.4631);
        giPlayerSetAng(3, 240.0);
        giCameraRunSingle("008", true);
        giWait(0.30000001192092896);
        giTalk("瞳寂：蓝衣白衫！他们是琼华派的人！！", "45408");
        giIMMBegin();
        giNpcDoAction("MN001", "Z01", 0, false);
        giNpcDoAction("MN002", "Z01", 0, false);
        giIMMEnd();
        giCameraRunSingle("007", true);
        giWait(0.30000001192092896);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：哎？！等等，我们不是——", "45409");
        giTalk("瞳幽：不管你们如何穿过结界！琼华派的就要受死！", "45410");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：等等！你们听我把话说完呀！", "45411");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giNpcDoAction("MN001", "X01", 1, false);
        giNpcDoAction("MN002", "X01", 1, false);
        giIMMEnd();
        giWait(0.4000000059604645);
        giPlayerDoAction(3, "Z01", 0, false);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：小心！！ ", "45412");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(3);
        giSetFullHP();
        giSetFullMP();
        giAddCombatMonster(2594, 1);
        giAddCombatMonster(2595, 0);
        giConfigCombatBgm("P39");
        giConfigCombatCamera("CA6");
        giConfigCombatGroundCamera("CA13");
        giConfigCombatParam(true, 0, 0, 0);
        giStartCombat("M18");
        giScriptMusicPlay("P42", 2, 0.0, 0.0);
        giNpcDoAction("MN001", "J02", 0, false);
        giNpcDoAction("MN002", "J01", 0, false);
        giFlashInBlack(2.5, true);
        giTalk("瞳幽：杀、杀了我们也没用！你们人休想攻下幻瞑界……", "45413");
        giNpcDoAction("MN001", "J01", 0, false);
        giWait(0.5);
        giPlayerWalkTo(3, 696.1757, 1.1657, 805.9182, false);
        giCameraRunSingle("009", false);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：死到临头，还逞口舌之利。", "45414");
        giPlayerEndMove(3);
        giPlayerDoAction(3, "Z01", 0, false);
        giWait(2.0);
        giCameraRunSingle("007", true);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：慢着！紫英，他们说不定是梦璃的族人，怎么可以痛下杀手呢？！", "45415");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerEndAction(3);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：族人……", "45416");
        giSetNpcVisible("MN003", true);
        giPlayerSetDir(0, 179.0, false);
        giPlayerSetDir(1, 182.0, false);
        giPlayerSetDir(3, 163.0, true);
        giWait(0.5);
        giTalk("？？：婵幽大人说的没错，果然有人毫发无伤地穿过结界。", "45417");
        gi2DSoundPlay("WJ081", 3);
        giWait(0.5);
        giNpcWalkTo("MN003", 686.1245, 1.1657, 685.2066, false);
        giCameraRunSingle("011", true);
        giIMMBegin();
        giPlayerSetPos(0, 669.8382, 1.1657, 799.0613);
        giPlayerSetAng(0, 189.0);
        giPlayerSetPos(1, 718.4188, 1.1657, 810.0427);
        giPlayerSetAng(1, 212.0);
        giPlayerSetPos(3, 739.6446, 1.1657, 774.8854);
        giPlayerSetAng(3, 214.0);
        giIMMEnd();
        giCameraRunSingle("010", false);
        giSetPortrait("B18B", true);
        giTalk("？？：你们，闯入我幻瞑界，便该做好有来无回的准备！！", "45418");
        giNpcEndMove("MN003");
        giCameraWait();
        giNpcDoAction("MN003", "Z01", 0, false);
        giWait(2.0);
        giCameraRunSingle("013", true);
        giWait(0.30000001192092896);
        giSetPortrait("101H", false);
        giTalk("云天河：这个人……好强的杀气……", "45419");
        giWait(0.30000001192092896);
        giPlayerDoAction(0, "Z01", 0, false);
        giPlayerDoAction(3, "Z01", 0, false);
        giSetPortrait("101H", false);
        giTalk("云天河：菱纱，你先退后！", "45420");
        giSetPortrait("103I", false);
        giTalk("韩菱纱：可是，为什么要打？！我们不是敌人啊！", "45421");
        giSetPortrait("B18B", true);
        giTalk("？？：拖延时间，莫非是在等其他援手？", "45422");
        giSetPortrait("B18B", true);
        giTalk("？？：休想如愿！", "45423");
        giFlashOutBlack(1.5, true, true);
        giNpcEndAction("MN003", true);
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN002", false);
        giSetFullHP();
        giSetFullMP();
        giAddCombatMonster(2596, 1);
        giConfigCombatBgm("P41");
        giConfigCombatCamera("CA7");
        giConfigCombatGroundCamera("CA12");
        giConfigCombatParam(true, 0, 0, 0);
        giStartCombat("M18");
        giScriptMusicPlay("P42", 2, 0.0, 0.0);
        giCameraRunSingle("015", true);
        giPlayerDoAction(0, "C01", 0, false);
        giPlayerDoAction(3, "C01", 0, false);
        giFlashInBlack(2.0, true);
        giSetPortrait("101H", true);
        giTalk("云天河：这个人……不好对付……", "45424");
        giPlayerSetVisible(2, true);
        giSetPortrait("B18B", false);
        giTalk("？？：哼，顽抗下去，不过是垂死挣扎！", "45425");
        giNpcDoAction("MN003", "J01", -1, false);
        giWait(3.200000047683716);
        giSetObjectVisible("Jeffect001", true);
        giWait(2.0);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：归邪将军，请住手！", "45426");
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P25", 2, 0.0, 0.0);
        giPlayerWalkTo(2, 771.6628, 1.1657, 689.0882, false);
        giCameraRunSingle("016", true);
        giSetObjectVisible("Jeffect001", false);
        giPlayerEndMove(2);
        giPlayerSetAng(2, 304.0);
        giIMMBegin();
        giPlayerSetPos(0, 691.5609, 1.1657, 795.0497);
        giPlayerSetAng(0, 137.0);
        giPlayerSetPos(1, 741.4402, 1.1657, 784.8782);
        giPlayerSetAng(1, 156.0);
        giPlayerSetPos(3, 754.981, 1.1657, 813.9772);
        giPlayerSetAng(3, 157.0);
        giNpcSetPos("MN003", 671.1665, 1.1657, 726.1868);
        giNpcSetAng("MN003", 106.0);
        giIMMEnd();
        giWait(1.5);
        giCameraRunSingle("017", true);
        giSetPortrait("101D", true);
        giTalk("云天河：梦璃？！", "45427");
        giWait(0.30000001192092896);
        giSetPortrait("B18A", true);
        giTalk("归邪：少主？！您怎么来了？", "45428");
        giWait(0.5);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：我听说有人穿过了结界，所以来看看……", "45429");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：将军，他们是我的朋友，请不要伤害他们！", "45430");
        giPlayerEndAction(2);
        giSetPortrait("B18A", true);
        giTalk("归邪：……", "45431");
        giCameraRunSingle("018", false);
        giPlayerWalkTo(0, 733.7615, 1.1657, 749.7904, true);
        giWait(0.20000000298023224);
        giSetPortrait("101K", true);
        giTalk("云天河：梦璃，你、你没事吧？", "45432");
        giPlayerSetDir(2, 339.0, true);
        giWait(0.30000001192092896);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：云公子，我……", "45433");
        giPlayerWalkTo(1, 751.5698, 1.1657, 767.7599, true);
        giPlayerSetDir(1, 162.0, true);
        giWait(0.20000000298023224);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：好梦璃，你怎么能一声不吭就跑了？你知道我有多担心吗？", "45434");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：对不起，我当日也是情非得已，我不知道要如何向你们解释……", "45435");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……你，是属于此界的妖？", "45436");
        giPlayerSetDir(2, 356.0, true);
        giWait(0.6000000238418579);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：嗯……不错，我乃是幻瞑界族长的女儿。", "45437");
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……！", "45438");
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giCameraRunSingle("019", true);
        giIMMEnd();
        giWait(0.6000000238418579);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：十九年前在妖界和琼华派大战之时，我尚且年幼，差点死于琼华派弟子之手，幸好云叔救了我，把我送去人间……", "45439");
        giWait(0.5);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：不知是否妖界临近的缘故，这段原本很模糊的记忆，在那天突然变得清晰起来……大战在即，我不可能抛下自己的族人，所以一定要回来。", "45440");
        giIMMBegin();
        giPlayerSetPos(0, 727.5841, 1.1657, 803.6383);
        giPlayerSetAng(0, 173.0);
        giPlayerSetPos(1, 747.6915, 1.1657, 765.1816);
        giPlayerSetAng(1, 180.0);
        giPlayerSetPos(3, 786.4763, 1.1657, 809.3137);
        giPlayerSetAng(3, 186.0);
        giNpcSetPos("MN003", 690.7319, 1.1657, 735.1868);
        giNpcSetAng("MN003", 116.0);
        giPlayerSetVisible(0, true);
        giIMMEnd();
        giCameraRunSingle("022", true);
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：以妖类而言，你修为不算精深，为何连二位长老都无法觉察你的身份？", "45441");
        giSetPortrait("106A", true);
        giWait(0.699999988079071);
        giPlayerDoAction(2, "C09", 1, true);
        giWait(0.699999988079071);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：……幻瞑界入口的结界并未被强行突破，你们……究竟是如何进来的？", "45442");
        giWait(0.5);
        giCameraRunSingle("020", true);
        giWait(0.5);
        giSetPortrait("B18A", true);
        giTalk("归邪：少主，属下不敬，只不过即便是少主的朋友，毕竟是“人”，进入幻瞑界中，并不妥当！", "45443");
        giWait(0.30000001192092896);
        giPlayerSetDir(2, 302.0, true);
        giWait(0.699999988079071);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：我知道，所以我要让他们去幻瞑宫拜见我娘，如何行止，由娘来定夺。若是娘怪罪下来，一切罪责由我承担。", "45444");
        giSetPortrait("B18A", true);
        giTalk("归邪：……是。", "45445");
        giIMMBegin();
        giPlayerSetAng(0, 156.0);
        giPlayerSetAng(1, 157.0);
        giPlayerSetAng(3, 175.0);
        giIMMEnd();
        giPlayerEndAction(2);
        giPlayerSetDir(2, 339.0, false);
        giCameraRunSingle("023", true);
        giWait(0.5);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：你们来此一事，我要先去禀报我娘，也就是幻瞑界之主……", "45446");
        giSetPortrait("106A", false);
        giTalk("柳梦璃：我们等一下就在<colour red=255 green=187 blue=0 alpha=255>旋梦底层的幻瞑宫</colour><dc0>相见吧。</dc0>", "45447");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：可是……", "45448");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：不必担心，没有妖会伤害你们的。", "45449");
        giSetPortrait("106A", false);
        giTalk("柳梦璃：若想进入<colour red=255 green=187 blue=0 alpha=255>旋梦</colour><dc0>，走近那个</dc0><colour red=255 green=187 blue=0 alpha=255>巨大光球旁的法阵</colour><dc0>便是。</dc0>", "45450");
        giWait(0.30000001192092896);
        giScriptMusicStop(1, 2.5);
        giPlayerDoAction(2, "J07", 1, true);
        giWait(1.0);
        giPlayerWalkTo(2, 747.4485, 1.1657, 592.399, false);
        giWait(1.0);
        giNpcWalkTo("MN003", 747.4485, 1.1657, 592.399, false);
        gi2DSoundPlay("WJ081", 2);
        giWait(3.0);
        giCameraRunSingle("024", true);
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：那个……真的是梦璃吗？", "45451");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：当然是！一眼就能认出来吧……", "45452");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：哎，我说的不是那种啦，总觉得……她虽然看起来没有变，可是偏偏离我们好远……", "45453");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101A", false);
        giTalk("云天河：也对。她怎么了？对我们好冷淡…… ", "45454");
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：一切的事情，恐怕只有她能告诉我们，不妨等下见面再说。", "45455");
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giSetNpcVisible("MN003", false);
        giSetNpcVisible("4001", true);
        giSetNpcVisible("4022", true);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 140700; // 0x0002259C, 第三章 / 8-4-1.妖界之主 / 前往幻瞑宫 / 妖界幻瞑
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2002()
{
    if (global_mvar == 140700 /* 第三章 / 8-4-1.妖界之主 / 前往幻瞑宫 / 妖界幻瞑 */)
    {
        giPlayerLock();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(2, -55.4292, 87.3755, -690.2241);
        giPlayerSetAng(2, 329.0);
        giPlayerSetVisible(2, true);
        giCameraPrepare("MC001");
        giArenaReady();
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, false);
        giCameraRunSingle("002", false);
        giWait(4.0);
        giCameraRunSingle("003", true);
        giIMMBegin();
        giPlayerSetPos(0, -107.8067, 91.5678, -486.0261);
        giPlayerSetAng(0, 227.0);
        giPlayerSetPos(1, -67.3817, 79.1797, -456.7796);
        giPlayerSetAng(1, 217.0);
        giPlayerSetPos(3, -149.9634, 77.5128, -455.6033);
        giPlayerSetAng(3, 242.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giIMMEnd();
        giCameraRunSingle("004", false);
        giPlayerWalkTo(0, -104.1328, 87.3752, -593.1254, false);
        giWait(0.20000000298023224);
        giPlayerWalkTo(1, -76.9316, 87.3752, -579.2609, false);
        giWait(0.20000000298023224);
        giPlayerWalkTo(3, -143.7584, 87.3752, -573.1325, false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 167.0, true);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 196.0, true);
        giPlayerEndMove(3);
        giPlayerSetDir(3, 159.0, true);
        giCameraWait();
        giWait(1.0);
        giCameraRunSingle("008", true);
        giWait(0.6000000238418579);
        giSetPortrait("229B", false);
        giTalk("婵幽：璃儿，你说的朋友……便是这几人？", "45456");
        giPlayerSetDir(2, 208.0, true);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：……正是。", "45457");
        giWait(0.5);
        giCameraRunSingle("006", true);
        giPlayerSetDir(2, 333.0, true);
        giWait(0.5);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：这位便是我娘，也是幻瞑界的主人。", "45458");
        giWait(1.0);
        giSetPortrait("229B", true);
        giTalk("婵幽：哼，岂有此理！", "45459");
        giCameraRunSingle("005", true);
        giPlayerSetDir(2, 208.0, true);
        giWait(0.30000001192092896);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：……娘？", "45460");
        giWait(0.5);
        giSetPortrait("229B", true);
        giTalk("婵幽：璃儿，你愿意回到我族，我十分高兴，但想不到你竟把“人”都带进了幻瞑宫！", "45461");
        giWait(0.30000001192092896);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：娘！他们、他们是我的朋友，不是敌人……", "45462");
        giWait(0.5);
        giSetPortrait("229B", true);
        giTalk("婵幽：不是敌人？莫非我看错了，那个穿蓝衣、背剑匣的，不是昆仑琼华派的人？！", "45463");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……！", "45464");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……他……他与其他人不一样的。", "45465");
        giPlayerEndAction(2);
        giSetPortrait("229B", true);
        giTalk("婵幽：璃儿，我确实很感激当年救了你的那个人，他将你送给可靠之人抚养，更赠你宝物帝女翡翠，以掩盖身上妖气……没有他，我们母女又何来日后重逢！", "45466");
        giSetPortrait("229B", true);
        giTalk("婵幽：但是，人终究是人！你要与人为伍，也要先想清楚，他们是不是真的接纳你！还是将你当作异类来看！", "45467");
        giCameraRunSingle("009", true);
        giWait(0.30000001192092896);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：不是的！", "45468");
        giPlayerSetDir(2, 333.0, true);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：我们真的是把梦璃当作好朋友，才不在乎她的身份！", "45469");
        giSetPortrait("229B", false);
        giTalk("婵幽：哦？那你们倒是说来听听，区区三个人，便敢胆大包天闯入此地，到底是为了什么？莫非仗着梦璃是幻瞑界少主，就以为能得到她的庇护？", "45470");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101J", true);
        giTalk("云天河：我们不知道梦璃是什么少主，来这里也只不过因为她忽然离开，我们担心她遇到危险，现在看她没事，也就放心了。", "45471");
        giPlayerEndAction(0);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：云公子……", "45472");
        giWait(0.5);
        giCameraRunSingle("007", false);
        giWait(0.699999988079071);
        giSetPortrait("229B", true);
        giTalk("婵幽：……你们如何穿过入口结界的？", "45473");
        giWait(0.5);
        giSetPortrait("229B", true);
        giTalk("婵幽：自从十九年前，被那些可憎之人攻到幻瞑宫前，我便立下决心，妖界若能不亡，我定要在入口布下强大结界，让擅闯之人不得好死！但你们几个……竟能毫发无伤地穿过？", "45474");
        giCameraRunSingle("015", true);
        giWait(0.4000000059604645);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101J", true);
        giTalk("云天河：我们去了鬼界……", "45475");
        giPlayerEndAction(0);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：鬼界！……", "45476");
        giSetPortrait("101J", true);
        giTalk("云天河：取了一种叫翳影枝的东西，听说只要有了它，天底下大多数地方都能随便来去。", "45477");
        giCameraRunSingle("010", true);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：…………", "45478");
        giWait(0.5);
        giNpcDoAction("MN001", "C08", 1, false);
        giSetPortrait("229B", true);
        giTalk("婵幽：哦，那可真不简单。", "45479");
        giWait(0.5);
        giSetPortrait("229B", true);
        giTalk("婵幽：既然诸位为我女儿煞费苦心，只是担心她的安危，那眼见她平安无事，就请回吧。", "45480");
        giCameraRunSingle("014", true);
        giPlayerSetDir(2, 234.0, true);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：娘！", "45481");
        giSetPortrait("229B", true);
        giTalk("婵幽：如何？你舍不得吗？是舍不得他们全部？还是舍不得其中哪一个呢？", "45482");
        giNpcSetDir("MN002", 87.0, true);
        giSetPortrait("230A", true);
        giTalk("奚仲：……？！", "45483");
        giWait(0.5);
        giCameraRunSingle("006", true);
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：娘……女儿想带他们去里幻瞑宫，让他们知晓当年之事……", "45484");
        giPlayerEndAction(2);
        giSetPortrait("229B", true);
        giTalk("婵幽：放肆！里幻瞑宫为妖界重地，连本族也很少入内，你，要带三个外人前去？", "45485");
        giSetPortrait("106G", false);
        giTalk("柳梦璃：娘，我求求您，云公子的爹就是当年救了我的云叔啊！", "45486");
        giWait(0.5);
        giCameraRunSingle("013", true);
        giWait(0.5);
        giSetPortrait("229A", false);
        giTalk("婵幽：哦？他竟是那人的孩子？", "45487");
        giCameraRunSingle("011", false);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：嗯……幻瞑昆仑之战，云公子一定也是满腹疑惑，我只想让他看看当年之事……", "45488");
        giPlayerEndAction(2);
        giSetPortrait("101D", true);
        giTalk("云天河：是爹……以前的事？！", "45489");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(0.699999988079071);
        giSetPortrait("229A", true);
        giTalk("婵幽：……我族向来恩怨分明……", "45490");
        giWait(0.5);
        giNpcDoAction("MN001", "C08", 1, false);
        giSetPortrait("229A", true);
        giTalk("婵幽：好吧，璃儿，看在他爹对我们母女有恩的份上，我便依你一次，但这几人若有不轨之心，我定不饶恕！", "45491");
        giWait(0.30000001192092896);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：谢谢娘！", "45492");
        giPlayerEndAction(2);
        giCameraRunSingle("013", true);
        giWait(0.699999988079071);
        giSetPortrait("229A", false);
        giTalk("婵幽：……若想好要进<colour red=255 green=187 blue=0 alpha=255>里幻瞑宫</colour><dc0>了，便来</dc0><colour red=255 green=187 blue=0 alpha=255>告诉我</colour><dc0>，我送你们前去。</dc0>", "45493");
        giIMMBegin();
        giNpcSetAng("MN002", 136.0);
        giCameraRunSingle("016", false);
        giIMMEnd();
        giWait(0.5);
        giNpcDoAction("MN002", "J01", -1, false);
        giSetPortrait("230A", true);
        giTalk("奚仲：大人……您的身体，怕是不宜再施展法术……", "45494");
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", true);
        giSetPortrait("229A", false);
        giTalk("婵幽：无妨，我自有分寸。", "45495");
        giSetPortrait("230A", true);
        giTalk("奚仲：是……", "45496");
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(2, -568.5211, -5.3223, -395.762);
        giPlayerSetAng(2, 67.0);
        giPlayerSetPos(0, -494.2785, -3.0341, -399.2937);
        giPlayerSetAng(0, 278.0);
        giPlayerSetPos(1, -502.393, -3.0342, -372.937);
        giPlayerSetAng(1, 263.0);
        giPlayerSetAng(2, 73.0);
        giPlayerSetPos(3, -518.9978, -3.0342, -333.5308);
        giPlayerSetAng(3, 215.0);
        giIMMEnd();
        giCameraRunSingle("021", true);
        giWait(0.6000000238418579);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：梦璃，你要带我们去哪里？", "45497");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("020", false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：是一个可以重现梦境的地方，我想，你们看过之后便会明白，幻瞑昆仑之战的那些渊源。 ", "45498");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……与琼华派相关？ ", "45499");
        giPlayerSetDir(2, 28.0, true);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：紫英……我知道，你对妖的厌恶、十几年来根深蒂固的想法，并非一朝一夕可以改变……", "45500");
        giSetPortrait("106A", true);
        giTalk("柳梦璃：去了<colour red=255 green=187 blue=0 alpha=255>里幻暝宫</colour><dc0>，我会告诉你们一些当年往事……或许，你会明白，人自然有人的想法，但我们也有我们的无奈……</dc0>", "45501");
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……", "45502");
        giWait(0.5);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：我们并不是像许多人以为的那样凶残，一定要吃人伤人……", "45503");
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：但妖与人相争，人力多半微小不可及，只能任由宰割，这却是不争的事实……", "45504");
        giWait(1.0);
        giCameraRunSingle("022", true);
        giCameraRunSingle("023", false);
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：人力虽然微渺，可是人的相争之心，却比任何东西都要可怕。", "45505");
        giPlayerEndAction(2);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：相争之心……", "45506");
        giWait(0.5);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：不管怎么样，<colour red=255 green=187 blue=0 alpha=255>我们先和梦璃去里幻瞑宫吧，</colour><dc0>梦璃一定有她的道理的，绝不会随随便便这样讲。</dc0>", "45507");
        giWait(0.30000001192092896);
        giPlayerSetDir(2, 73.0, true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：对啊，要是妖真的不好，那我们一见梦璃的娘，早就打起来了……可是她娘也没怎么啊，她还谢谢我爹救了梦璃呢。", "45508");
        giPlayerEndAction(0);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……我明白了。", "45509");
        giPlayerSetDir(2, 28.0, true);
        giWait(0.30000001192092896);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：梦璃，请你把当年往事原原本本地告诉我，我要弄清楚，还有什么是我不知道的隐情，又有什么，是我一直以来都没有想过的……", "45510");
        giPlayerEndAction(3);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：嗯……谢谢你，紫英，你愿意这么说，我已经很开心、很开心了……", "45511");
        giWait(0.5);
        giPlayerInTeam(2, true);
        giWait(2.0);
        giAddPlayerEquip(2, 3554);
        giAddPlayerEquip(2, 3617);
        giAddPlayerEquip(2, 3582);
        giAddPlayerEquip(2, 3647);
        giSetPlayerLevel(2, 53);
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(2);
        giCameraRunSingle("021", true);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerSetVisible(2, false);
        giPlayerCurrentSetPos(-109.7072, -5.1106, -197.2896);
        giPlayerCurrentSetAng(180.0);
        giNpcSetAng("MN002", 38.0);
        giCameraSetMode(4, true);
        giCameraSeekToPlayer();
        global_mvar = 140701; // 0x0002259D, 第三章 / 8-4-2.妖界之主 / 里幻瞑宫
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2003()
{
    if (global_mvar == 140701 /* 第三章 / 8-4-2.妖界之主 / 里幻瞑宫 */)
    {
        giFlashOutBlack(0.5, true, true);
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetPos(0, -121.4655, 87.3753, -662.4949);
        giPlayerSetAng(0, 166.0);
        giPlayerSetPos(1, -109.3154, 87.3753, -639.5174);
        giPlayerSetAng(1, 177.0);
        giPlayerSetPos(2, -70.9942, 87.3753, -672.086);
        giPlayerSetAng(2, 208.0);
        giPlayerSetPos(3, -161.187, 87.3753, -647.4467);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giPlayerSetAng(3, 141.0);
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giSetPortrait("229A", false);
        giTalk("婵幽：……都准备好了？", "45512");
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, true);
        giWait(0.5);
        giCameraRunSingle("002", true);
        giSetPortrait("229A", false);
        giTalk("婵幽：梦影雾花，尽是虚空，因心想念动，方万物有生，随之～虚～实～乃～成！", "45513");
        giNpcDoAction("MN001", "J01", -1, false);
        giWait(0.5);
        giEffectAttachToNpc("MN001", "H_TL01_1", false);
        giWait(2.0);
        giCameraRunSingle("001", true);
        giEffectDetachFromNpc("MN001");
        giIMMBegin();
        giEffectPlayWithPlayer("H_097", 1, 0);
        giEffectPlayWithPlayer("H_097", 1, 2);
        giEffectPlayWithPlayer("H_097", 1, 3);
        giEffectPlayWithPlayer("H_097", 1, 1);
        giPlayerBlendOut(0, 1.5, false);
        giPlayerBlendOut(1, 1.5, false);
        giPlayerBlendOut(2, 1.5, false);
        giPlayerBlendOut(3, 1.5, false);
        giIMMEnd();
        giWait(1.5);
        giFlashOutWhite(2.0, true, true);
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giArenaLoad("Q14", "LN01", "", true);
        giPlayerSetPos(0, 210.4009, -5.1105, -295.9774);
        giPlayerSetAng(0, 139.0);
        giPlayerSetPos(1, 157.1487, -5.1105, -286.6539);
        giPlayerSetAng(1, 151.0);
        giPlayerSetPos(2, 289.154, -5.1105, -376.4535);
        giPlayerSetAng(2, 156.0);
        giPlayerSetPos(3, 184.079, -5.1105, -236.6765);
        giPlayerSetAng(3, 149.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giEnableShadow(false);
        giPlayerLock();
        giScriptMusicPlay("P25", 2, 0.0, 2.5);
        giCameraPrepare("MC001");
        giArenaReady();
        giCameraRunSingle("002", true);
        giFlashInWhite(2.5, true);
        giCameraRunSingle("003", false);
        giWait(4.0);
        giCameraRunSingle("008", true);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：啊！那些是什么？好漂亮……", "45514");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.0);
        giCameraRunSingle("006", true);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：那是……许多人的梦。", "45515");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：梦？", "45516");
        giCameraRunSingle("007", false);
        giWait(1.5);
        giPlayerSetDir(2, 311.0, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：幻瞑界乃是“梦貘”一族，我们能够往来于梦中，以吞吃人的梦境为食。", "45517");
        giCameraWait();
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：这样讲的话，梦璃你也是……？", "45518");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giCameraRunSingle("009", false);
        giWait(0.5);
        giPlayerDoAction(2, "C08", 1, true);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：不过，貘并不会伤害到人，也不会轻易窥视别人的梦境，若遭吞噬的是恶梦，反而于人有益。", "45519");
        giWait(0.5);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：……但是，妖毕竟是妖，竟然要靠食人之梦而活……", "45520");
        giIMMBegin();
        giPlayerSetPos(0, 162.7016, -5.1105, -362.6086);
        giPlayerSetAng(0, 86.0);
        giPlayerSetPos(1, 150.2469, -5.1105, -402.7898);
        giPlayerSetAng(1, 71.0);
        giPlayerSetPos(3, 125.7499, -5.1105, -342.9093);
        giPlayerSetAng(3, 89.0);
        giIMMEnd();
        giCameraRunSingle("010", true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：那也没差吧，人不也要吃猪吃熊？", "45521");
        giPlayerEndAction(0);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：……", "45522");
        giPlayerSetAng(2, 271.0);
        giCameraRunSingle("011", true);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：对不起，在妖界之中，你们一定感到很不自在吧？", "45523");
        giSetPortrait("106A", false);
        giTalk("柳梦璃：不单人会排除异己，妖也会排除异己……我娘，她很讨厌人……", "45524");
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：这没什么，是人先来攻打妖界的吧？你娘要是喜欢人，那才古怪呢。", "45525");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("012", false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：你们……", "45526");
        giSetPortrait("103A", true);
        giTalk("韩菱纱：……？", "45527");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……亲眼看见你们出现在幻瞑界时，我几乎不敢相信自己的眼睛……为什么、为什么要冒这样大的危险闯进来？万一出了什么事，我永远都不会原谅自己的！", "45528");
        giPlayerEndAction(2);
        giSetPortrait("101E", true);
        giTalk("云天河：梦璃，你生气了？", "45529");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：你突然跑进妖界，我很担心你，如果不闯进来看看，万一你出了什么事，我才永远都不会原谅自己。", "45530");
        giPlayerEndAction(0);
        giSetPortrait("101E", true);
        giTalk("云天河：没想到你是什么少主，其实也不用担心什么的……", "45531");
        giCameraRunSingle("015", true);
        giCameraRunSingle("016", false);
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：不是的，云公子……你……你们能来，梦璃真的好开心……", "45532");
        giPlayerEndAction(2);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：只是……你们为了能进幻瞑界，四方奔走，甚至还去了鬼界……每个人都瘦了，脸上都是风尘仆仆的……梦璃又好心痛……", "45533");
        giSetPortrait("106F", false);
        giTalk("柳梦璃：而且……娘很讨厌人，我不能与你们太过亲近，若是她心中不悦，我不知道……能不能保护你们……", "45534");
        giWait(1.0);
        giCameraRunSingle("010", true);
        giCameraRunSingle("019", false);
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：好梦璃，你别难过，其实就像你娘说的，只要看到你平安，我们就放心了。", "45535");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.30000001192092896);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：只不过，我们还想问问你……", "45536");
        giSetPortrait("106F", true);
        giTalk("柳梦璃：什么……？", "45537");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：现在琼华派和幻瞑界还没有短兵相接，我和天河、紫英，都不愿意见到双方杀个你死我活……", "45538");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：要是有办法让幻瞑界脱离双剑的束缚，是不是就可以免去这场大战呢？", "45539");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.0);
        giCameraRunSingle("013", true);
        giCameraRunSingle("014", false);
        giWait(0.5);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：…………", "45540");
        giWait(0.5);
        giPlayerDoAction(2, "C08", 1, false);
        giWait(0.5);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：你说的没有错，但是……只怕是不可能了。", "45541");
        giPlayerEndAction(2);
        giSetPortrait("101C", true);
        giTalk("云天河：为什么？", "45542");
        giSetPortrait("106A", false);
        giTalk("柳梦璃：因为……我族在十九年前的大战中遭受巨创，现在只能勉强守住幻瞑界入口，想要脱离双剑的束缚……谈何容易……", "45543");
        giPlayerDoAction(2, "C09", 1, false);
        giWait(0.5);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：琼华派也绝不会就此罢手，没有得到他们真正想要的东西……是不会罢手的……", "45544");
        giPlayerEndAction(2);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：真正想要的东西？双剑网缚此地，不是为了直接引取灵力？", "45545");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：……不错，可你们只知其一，不知其二。", "45546");
        giSetPortrait("106A", false);
        giTalk("柳梦璃：幻瞑界被缚住之后，琼华派的确能够通过双剑引取灵力，但那只是幻瞑界灵力的一小部分，我族真正的力量来源乃是此地遍布的紫晶石。", "45547");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：啊！你是说，琼华派的人想抢这些有灵力的石头？", "45548");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.0);
        giCameraRunSingle("017", true);
        giCameraRunSingle("018", false);
        giPlayerDoAction(2, "C08", 1, false);
        giWait(0.5);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：我族虽食梦为生，但在千年以前，也只是灵力十分寻常的妖。自从偶然发现了这处奇地，其间灵力充盈，尤其是这些紫晶石，令族人的修为突飞猛进。", "45549");
        giPlayerEndAction(2);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：而族长通过紫晶石的力量，才能令整个幻瞑界隐去，避过许多无谓的灾祸。", "45550");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：如此说来，是双剑之力令此地现形？", "45551");
        giSetPortrait("106A", false);
        giTalk("柳梦璃：对……一切都是从琼华派发现了幻瞑界开始……他们虽不知紫晶石的存在，却也明白这里蕴涵着强大的灵气……", "45552");
        giSetPortrait("106A", false);
        giTalk("柳梦璃：十九年前，幻瞑界的入口并无结界，琼华派攻入之后，终于发现了紫晶石的秘密，也夺去了不少……如今，他们又怎会罢手？", "45553");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：…………", "45554");
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(0, 210.4009, -5.1105, -295.9774);
        giPlayerSetAng(0, 139.0);
        giPlayerSetPos(1, 157.1487, -5.1105, -286.6539);
        giPlayerSetAng(1, 151.0);
        giPlayerSetPos(3, 184.079, -5.1105, -236.6765);
        giPlayerSetAng(3, 149.0);
        giPlayerSetAng(2, 156.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：看过这些梦境以后，当年之事，你们会更加清楚……", "45555");
        giSetPortrait("106B", false);
        giTalk("柳梦璃：来吧，我带你们进到几个梦里，把自己当成旁观者，心念放松即可。", "45556");
        giCameraRunSingle("020", false);
        giPlayerWalkTo(2, 311.215, -5.3223, -398.4356, false);
        giPlayerWalkTo(0, 300.7154, -5.1105, -362.3526, false);
        giPlayerWalkTo(1, 255.6492, -5.1105, -356.2985, false);
        giPlayerWalkTo(3, 267.9926, -5.1105, -311.2471, false);
        giPlayerEndMove(0);
        giPlayerEndMove(1);
        giPlayerEndMove(3);
        giPlayerSetDir(2, 317.0, true);
        giWait(0.5);
        giEffectAttachToPlayer(2, "H_TL01_1", false);
        giPlayerDoAction(2, "J12", 1, true);
        giFlashOutWhite(2.0, true, true);
        giEffectDetachFromPlayer(2);
        global_mvar = 140800; // 0x00022600
        giEnableShadow(true);
        giArenaLoad("Q06", "Q06Q", "", true);
    }
}

void func2004()
{
    if (global_mvar == 141100)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetPos(0, 221.5872, -5.1106, -393.8501);
        giPlayerSetAng(0, 88.0);
        giPlayerSetPos(1, 190.2106, -5.1106, -438.8828);
        giPlayerSetAng(1, 72.0);
        giPlayerSetPos(2, 292.5883, -3.0341, -390.1659);
        giPlayerSetAng(2, 280.0);
        giPlayerSetPos(3, 171.6541, -5.1106, -375.0109);
        giPlayerSetAng(3, 98.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giIMMEnd();
        giArenaReady();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giPlayerDoAction(0, "J04", -1, false);
        giWait(0.800000011920929);
        giEnableShadow(false);
        giFlashInWhite(1.5, true);
        giSetPortrait("101G", true);
        giTalk("云天河：……大哥…………", "45684");
        giWait(1.5);
        giCameraRunSingle("002", true);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：这，便是玄霄的梦，是他十九年来反复回忆起的往事……", "45685");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：天啊，琼华派和妖界的大战，引发了这么多惨事……要是这一回再打起来，我真不敢想像……", "45686");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：…………", "45687");
        giCameraRunSingle("003", true);
        giWait(0.5);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：其实……妖界已经很衰弱了，六位幻瞑护将，如今只剩两位，其余的早已战死……", "45688");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：但我听大哥说妖界……说你娘很厉害，十九年前一战，连太清真人也打不过她。", "45689");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：其实娘已经……", "45690");
        giPlayerDoAction(1, "Z11", 0, false);
        giWait(0.5);
        giSetPortrait("103L", true);
        giTalk("韩菱纱：啊——！", "45691");
        giCameraRunSingle("004", true);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：菱纱！", "45692");
        giIMMBegin();
        giPlayerSetPos(2, 263.5545, -3.7734, -449.1134);
        giPlayerSetAng(2, 270.0);
        giPlayerSetPos(0, 227.7815, -5.1106, -373.8939);
        giPlayerSetAng(0, 214.0);
        giPlayerSetPos(3, 151.0124, -5.1106, -385.1306);
        giPlayerSetAng(3, 135.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giCameraRunSingle("006", false);
        giSetPortrait("103L", false);
        giTalk("韩菱纱：……又、又是那种感觉，好像全身的力气都被抽走了一样……好冷……", "45693");
        giSetPortrait("106G", true);
        giTalk("柳梦璃：还好吗？要不要我用香——", "45694");
        giSetPortrait("103L", false);
        giTalk("韩菱纱：……没关系……总是这样，歇息一下就没事了……", "45695");
        giSetPortrait("101H", false);
        giTalk("云天河：很冷……？", "45696");
        giPlayerDoAction(0, "C07", -1, true);
        giWait(0.4000000059604645);
        giIMMBegin();
        giSetObjectVisible("Jeffect008", true);
        giSetObjectVisible("Jeffect007", true);
        giIMMEnd();
        giWait(2.0);
        giIMMBegin();
        giSetObjectVisible("Jeffect008", false);
        giSetObjectVisible("Jeffect007", false);
        giIMMEnd();
        giSetPortrait("101H", false);
        giTalk("云天河：菱纱，这样呢？……这样会不会好一点？", "45697");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……嗯…………", "45698");
        giWait(0.5);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(1, 37.0, true);
        giWait(0.699999988079071);
        giPlayerSetDir(3, 100.0, true);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：……！", "45699");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：天河……你怎么……？", "45700");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：这是什么法术？有种暖暖的感觉，和“红魄”有点像……我、我一下子好多了……", "45701");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101A", false);
        giTalk("云天河：我也不知道……只要一想，身体自然就有气息涌出，有时暖暖的，有时冷冷的……不过，只要你没事就好——", "45702");
        giPlayerEndAction(0);
        giCameraRunSingle("008", false);
        giWait(0.30000001192092896);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：天河，在不周山时这两道阴阳之气令你相当难受，现在还是如此？", "45703");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：有时有点难受，有时又很舒服，不过我发现只要全身放松就好了，这两道气息都会随便乱跑，跑着跑着就不见了。", "45704");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：玄霄的凝冰诀真的很厉害，现在野人手上又有了神兵利器，看来快变成一代奇侠了～", "45705");
        giPlayerEndAction(1);
        giSetPortrait("101K", true);
        giTalk("云天河：奇侠是啥？我只觉得现在去打猎的话，一定会有很大的收获～ ", "45706");
        giWait(0.30000001192092896);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：喂～你别太过份了，拿着后羿射日弓去猎野猪，小心遭天谴！ ", "45707");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：我却觉得不单是凝冰诀一个原因，天河能拿取常人无法触碰的炙炎石与三寒器，似乎——", "45708");
        giScriptMusicPlay("P15", 2, 0.0, 2.5);
        giPlayerSetAng(2, 346.0);
        giCameraRunSingle("009", false);
        giGOMTouch("Jeffect001");
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giSetPortrait("101D", true);
        giTalk("云天河：……？！", "45709");
        giSetPortrait("106G", false);
        giTalk("柳梦璃：……糟了！！入口的结界被打破了！", "45710");
        giPlayerSetDir(0, 148.0, false);
        giPlayerSetDir(1, 81.0, false);
        giSetPortrait("101D", true);
        giTalk("云天河：怎么会？！你娘不是说……那个结界很厉害？！", "45711");
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：……娘……她十九年前虽然打败了太清真人，但是为求险胜，斗法时强行催动妖力，元气大伤，之后一直都很虚弱，如今也只是在强撑罢了……", "45712");
        giPlayerEndAction(2);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：幻瞑界又被双剑网住，灵力也正在不断流失，我们心里都很清楚，结界被破，恐怕只是早晚的事情，惟有殊死一战……", "45713");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：难道……琼华派已经攻了进来？！", "45714");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(2, 296.0, true);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：但愿不是……<colour red=255 green=187 blue=0 alpha=255>我们快些出去看看！</colour>", "45715");
        giSetPortrait("101H", true);
        giTalk("云天河：好！！", "45716");
        giPlayerInTeam(2, true);
        giFlashOutBlack(1.0, true, true);
        global_mvar = 141101; // 0x0002272D, 幻瞑危机
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerSetVisible(2, false);
        giCameraSetMode(4, true);
        giCameraSeekToPlayer();
        giPlayerSetAng(0, 0.0);
        giEnableShadow(true);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2005()
{
    if (global_mvar == 141101 /* 幻瞑危机 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P27", 2, 2.5, 0.0);
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -60.0432, 87.37546, -575.3356);
        giPlayerSetAng(0, 236.0);
        giPlayerSetPos(1, -104.0974, 87.37546, -523.1407);
        giPlayerSetAng(1, 232.0);
        giPlayerSetPos(2, -150.1931, -5.1105, -219.5098);
        giPlayerSetPos(3, -55.6944, 87.3754, -529.0105);
        giPlayerSetAng(3, 240.0);
        giSetNpcVisible("MN002", true);
        giSetNpcVisible("MN003", true);
        giNpcSetPos("MN002", -131.8659, 87.3752, -589.5601);
        giNpcSetAng("MN002", 102.0);
        giCameraPrepare("MC003");
        giCameraRunSingle("002", true);
        giFlashInBlack(2.0, true);
        giArenaReady();
        giNpcBlendIn("MN004", 2.5, true);
        giSetObjectVisible("Jeffect001", true);
        giWait(0.5);
        giSetPortrait("230A", true);
        giTalk("奚仲：你……！", "45717");
        giNpcSetDir("MN002", 182.0, true);
        giWait(0.3);
        giSetPortrait("230A", true);
        giTalk("奚仲：婵幽大人！你快走！去里幻瞑宫！", "45718");
        giSetPortrait("229B", false);
        giTalk("婵幽：……无妨。", "45719");
        giSetPortrait("229B", false);
        giTalk("婵幽：他再如何神通，让灵体之像出现在幻瞑宫，也已是极限，不能再伤及你我分毫！", "45720");
        giWait(0.8);
        giSetPortrait("216H", false);
        giTalk("玄霄：你，便是妖界之主？", "45721");
        giWait(0.30000001192092896);
        giIMMBegin();
        giNpcSetPos("MN002", -199.0619, 87.3752, -618.3039);
        giNpcSetAng("MN002", 92.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giCameraRunSingle("005", false);
        giWait(0.30000001192092896);
        giSetPortrait("229B", true);
        giTalk("婵幽：婵幽不必理会登堂入室、屠戮我族的无耻之人！", "45722");
        giWait(0.5);
        giSetPortrait("229C", true);
        giTalk("婵幽：……！", "45723");
        giWait(0.30000001192092896);
        giSetPortrait("216H", false);
        giTalk("玄霄：妄动气息，便是寻死！", "45724");
        giWait(0.699999988079071);
        giSetPortrait("216H", false);
        giTalk("玄霄：以你自身为凭的结界遭破，灵力反噬，你必已身受巨创。", "45725");
        giWait(0.5);
        giSetPortrait("229C", true);
        giTalk("婵幽：…………", "45726");
        giWait(1.0);
        giCameraRunSingle("007", true);
        giCameraRunSingle("008", false);
        giWait(0.6000000238418579);
        giSetPortrait("216H", false);
        giTalk("玄霄：妖界之主，我曾渴望与你一战！", "45727");
        giWait(0.30000001192092896);
        giSetPortrait("229C", true);
        giTalk("婵幽：……！", "45728");
        giWait(0.5);
        giSetPortrait("216H", false);
        giTalk("玄霄：当年在我看来遥不可追的太清，都被你轻取性命！妖界之主是何等的强大风光！", "45729");
        giWait(0.699999988079071);
        giSetPortrait("216G", false);
        giTalk("玄霄：如今一见，却令人失望，你不过是个废人罢了。", "45730");
        giWait(0.5);
        giSetPortrait("216G", false);
        giTalk("玄霄：原来当年是两败俱伤之局，你这个妖界之主装假逞强倒是有模有样，把琼华派上下全部蒙骗！", "45731");
        giWait(1.0);
        giCameraRunSingle("010", true);
        giCameraRunSingle("011", false);
        giWait(0.8);
        giSetPortrait("229C", false);
        giTalk("婵幽：……万灵盛衰，乃是常理，无恒强、无恒弱。", "45732");
        giWait(0.5);
        giSetPortrait("229C", false);
        giTalk("婵幽：你今日体内烈阳与冰寒之气纵横交织，相距甚远都可感到凶煞之气，人非人、怪非怪，在我看来，异日必遭天谴！", "45733");
        giWait(0.5);
        giSetPortrait("216H", true);
        giTalk("玄霄：…………", "45734");
        giWait(0.8);
        giCameraRunSingle("009", true);
        giSetPortrait("216H", false);
        giTalk("玄霄：我此一生，已无回头之路！", "45735");
        giWait(0.5);
        giNpcDoAction("MN004", "J01", 1, false);
        giSetPortrait("216H", false);
        giTalk("玄霄：……竟被一个无能的掌门冰封，如今琼华已非昔日琼华，枉我一心为门派雪耻！妖界也衰弱到不堪一击！", "45736");
        giNpcEndAction("MN004", true);
        giSetPortrait("216H", false);
        giTalk("玄霄：妖界之主，我厌烦了这一切，劝你不必躲藏，出来受死！让我快快结束这场空虚……", "45737");
        giWait(0.5);
        giNpcBlendOut("MN004", 2.5, true);
        giSetObjectVisible("Jeffect001", false);
        giScriptMusicStop(0, 2.5);
        giWait(1.0);
        giCameraRunSingle("003", true);
        giCameraRunSingle("004", false);
        giWait(2.0);
        giSetPortrait("229C", false);
        giTalk("婵幽：…………", "45738");
        giWait(2.3);
        giPlayerSetVisible(2, true);
        giPlayerRunTo(2, -132.1285, 87.3755, -612.0448, true);
        giPlayerSetAng(2, 209.0);
        giPlayerDoAction(2, "J03", -1, false);
        giSetPortrait("106G", true);
        giTalk("柳梦璃：娘！您怎么样？有没有受伤？！", "45739");
        giWait(0.5);
        giSetPortrait("229C", false);
        giTalk("婵幽：……我没事……结界遭破，灵力反噬而已……", "45740");
        giSetPortrait("229C", false);
        giTalk("婵幽：但是……有人攻进来了……", "45741");
        giWait(0.5);
        giSetPortrait("229C", false);
        giTalk("婵幽：我派了归邪去守入口，但我很担心……他会孤注一掷……", "45742");
        giSetPortrait("106G", true);
        giTalk("柳梦璃：娘……", "45743");
        giWait(0.5);
        giSetPortrait("229C", false);
        giTalk("婵幽：旋梦外围的法阵已经发动……能撑一时便是一时吧……到万不得已之时，我族宁可与人同归于尽，也不能让他们侵占此地……", "45744");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giIMMBegin();
        giPlayerSetAng(2, 235.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giCameraRunSingle("012", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：娘，我也<colour red=255 green=187 blue=0 alpha=255>去外面</colour><dc0>！我去阻止那些人！</dc0>", "45745");
        giSetPortrait("101J", false);
        giTalk("云天河：梦璃，我跟你一起去！", "45746");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：我也是！", "45747");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……", "45748");
        giWait(0.5);
        giIMMBegin();
        giNpcSetPos("MN002", -188.0856, 87.3752, -597.4006);
        giNpcSetAng("MN002", 76.0);
        giPlayerSetPos(2, -120.0676, 87.3753, -592.7793);
        giPlayerSetAng(2, 235.0);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giCameraRunSingle("021", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("229C", true);
        giTalk("婵幽：璃儿，你去吧……", "45749");
        giWait(0.5);
        giSetPortrait("229C", true);
        giTalk("婵幽：……可以的话，我不愿你去涉险，可是你身为幻瞑界少主，这种时候，即便是死了，也要挺身保护自己的子民……", "45750");
        giSetPortrait("106G", false);
        giTalk("柳梦璃：娘！您别说了，我都明白的！", "45751");
        giWait(0.5);
        giCameraRunSingle("022", false);
        giSetPortrait("230A", true);
        giTalk("奚仲：少主，请让奚仲陪您一起去！", "45752");
        giWait(0.5);
        giPlayerSetDir(2, 265.0, true);
        giWait(0.3);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：不！你留下照顾娘，万一……", "45753");
        giPlayerDoAction(2, "C09", 1, false);
        giWait(0.3);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：总之，让我先去。", "45754");
        giPlayerEndAction(2);
        giWait(0.5);
        giNpcDoAction("MN002", "J01", -1, false);
        giSetPortrait("230A", true);
        giTalk("奚仲：……是。", "45755");
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", true);
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("002", true);
        global_mvar = 141400; // 0x00022858, 第三章 / 9-2-1.焚心以火 / 护卫幻瞑
        giArenaLoad("Q14", "Q14B", "", true);
        giPlayerCurrentSetPos(1154.1124, 3345.875, -1172.1664);
        giPlayerCurrentSetAng(244.0);
        giCameraSetMode(0, true);
        func7001();
        giArenaReady();
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2006()
{
    if (global_mvar == 150100 /* 噩梦纷争 */)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 307.145, -5.3223, -455.4478);
        giPlayerSetAng(0, 111.0);
        giPlayerSetPos(1, 10.8757, 87.37546, -670.5703);
        giPlayerSetAng(1, 111.0);
        giPlayerSetPos(2, 54.9079, 87.3754, -692.3123);
        giPlayerSetAng(2, 300.0);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(0, true);
        giPlayerOutTeam(2, false);
        giPlayerOutTeam(3, false);
        giIMMEnd();
        giCameraPrepare("MC004");
        giArenaReady();
        giCameraRunSingle("001", true);
        giWait(0.800000011920929);
        giPlayerDoAction(1, "J19", -1, true);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：唔……", "45960");
        giWait(1.0);
        giCameraRunSingle("002", false);
        giFlashInBlack(2.0, true);
        giWait(0.5);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：菱纱！你终于醒了！", "45961");
        giWait(1.0);
        giCameraRunSingle("004", true);
        giWait(0.5);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：……身上的骨头，有点像是散了架……", "45962");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：天河呢？还有紫英？", "45963");
        giWait(0.699999988079071);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：……大家都还在幻瞑界，紫英去处理怀朔的后事了，他说要把尸体烧了，骨灰带回怀朔的故乡……", "45964");
        giWait(0.699999988079071);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：至于云公子……", "45965");
        giWait(0.5);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……菱纱你体内的冰寒之气很重，他运功替你驱寒，见你有起色之后，就一直站在那边，沉默不语了……", "45966");
        giWait(0.5);
        giCameraRunSingle("003", true);
        giWait(0.5);
        giCameraRunSingle("008", false);
        giWait(0.5);
        giPlayerSetPos(2, 112.3041, 87.3751, -621.0122);
        giPlayerSetPos(1, 73.9509, 87.3751, -582.9161);
        giPlayerSetAng(2, 33.0);
        giPlayerSetAng(1, 46.0);
        giCameraWait();
        giWait(1.5);
        giCameraRunSingle("009", true);
        giWait(0.5);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：他怎么了……？", "45967");
        giWait(0.5);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：你昏了过去……所以不知道，不久前，发生了好多事……", "45968");
        giFlashOutBlack(1.5, true, true);
        giWait(2.0);
        giPlayerSetAng(2, 313.0);
        giPlayerSetAng(1, 128.0);
        giCameraRunSingle("006", true);
        giCameraRunSingle("007", false);
        giFlashInBlack(1.5, true);
        giPlayerDoAction(1, "J04", 1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……原来，是这样吗？", "45969");
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：我想，玄霄的转变对云公子打击实在很大……", "45970");
        giPlayerEndAction(2);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：而且，他更不能释怀望舒剑的事情……他觉得，是他害了你……", "45971");
        giWait(0.5);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：傻瓜……", "45972");
        giPlayerEndAction(1);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：菱纱，你的身体……", "45973");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：别担心我，我还没有告诉你吧，我们韩家人注定都是短命的，所以对生死之事，已经看的开了，虽然，临到自己头上还是有点难过，但是真的没什么……", "45974");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：…………", "45975");
        giSetPortrait("103A", true);
        giTalk("韩菱纱：我去看看天河吧，想办法让他打起精神来！", "45976");
        giWait(0.5);
        giPlayerDoAction(2, "C08", 1, true);
        giWait(0.5);
        giPlayerWalkTo(1, -112.7561, 87.3751, -520.4607, false);
        giWait(2.0);
        giScriptMusicPlay("P49", 2, 0.0, 0.0);
        giCameraRunSingle("010", true);
        giPlayerEndMove(1);
        giPlayerSetPos(1, 162.993, -5.1105, -384.7292);
        giPlayerWalkTo(1, 250.2486, -5.0567, -424.2286, true);
        giPlayerSetDir(1, 118.0, true);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：天～河～", "45977");
        giSetPortrait("101D", true);
        giTalk("云天河：……", "45978");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：天河！", "45979");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101E", true);
        giTalk("云天河：……", "45980");
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：云天河！！", "45981");
        giSetPortrait("101G", true);
        giTalk("云天河：…………", "45982");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerWalkTo(1, 285.3498, -5.3224, -435.6592, true);
        giPlayerSetAng(1, 116.0);
        giWait(0.30000001192092896);
        giPlayerDoAction(1, "J20", 1, false);
        giWait(0.2);
        gi2DSoundPlay("WJ012", 1);
        giPlayerDoAction(0, "J21", -1, false);
        giWait(0.2);
        giSetPortrait("101H", true);
        giTalk("云天河：好痛啊！", "45983");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(0, 295.0, true);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：怕痛就应该早点回答我！", "45984");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：干嘛？一脸哀怨，我长得有这么不堪入目吗？！", "45985");
        giWait(0.5);
        giSetPortrait("101E", true);
        giTalk("云天河：…………", "45986");
        giSetPortrait("103F", false);
        giTalk("韩菱纱：喂，你再不说话，我真要生气了！", "45987");
        giIMMBegin();
        giPlayerSetPos(1, 250.2486, -5.0567, -424.2286);
        giPlayerSetAng(1, 127.0);
        giCameraRunSingle("011", true);
        giIMMEnd();
        giWait(0.30000001192092896);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：说、说什么？", "45988");
        giPlayerEndAction(0);
        giCameraRunSingle("012", false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：笨，看了就有气……", "45989");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：我在其他人面前好歹也是人见人爱，可是遇上你这野人，总是一肚子火……不知道的人还以为我很爱生气呢，真是……", "45990");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：哦……我、我是笨了点……常常闯祸……", "45991");
        giPlayerEndAction(0);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：……望舒剑的事，梦璃都跟我说了，又不是你的错，你一副苦瓜脸干什么！", "45992");
        giSetPortrait("101G", false);
        giTalk("云天河：…………可是、是我害了你……", "45993");
        giWait(0.6000000238418579);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：你说什么呀？那最初的原因还不是我自己？我不进去你爹的墓，就什么事都没了。", "45994");
        giSetPortrait("101H", false);
        giTalk("云天河：话是这么说没错，但是……", "45995");
        giPlayerDoAction(0, "J15", 0, false);
        giSetPortrait("101H", false);
        giTalk("云天河：唉！我真没用！还说要保护你，让你活得长长久久，结果什么都做不到！我……", "45996");
        giPlayerEndAction(0);
        giWait(1.0);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giCameraRunSingle("015", true);
        giIMMEnd();
        giCameraRunSingle("016", false);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：你啊，平时不想事情，一想事情脑子就打结……", "45997");
        giWait(0.5);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：告诉你吧，天河，人根本改变不了所谓的命。", "45998");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101E", false);
        giTalk("云天河：……！", "45999");
        giWait(0.5);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：你听过吗？人的命运总是按既定的方向在前进，即使你改变了过程，也改不了结果。", "46000");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：你或许会想，要是你没有遇见我，没有去昆仑山就好了，但是，我们可能会以另外的方式相遇吧？", "46001");
        giSetPortrait("103M", true);
        giTalk("韩菱纱：要是你觉得，你不帮玄霄就好了，但或许我会很想帮他，我们还是会去找三寒器。", "46002");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101G", false);
        giTalk("云天河：…………", "46003");
        giWait(1.0);
        giIMMBegin();
        giPlayerSetVisible(0, true);
        giCameraRunSingle("018", true);
        giIMMEnd();
        giCameraRunSingle("017", false);
        giWait(0.5);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：人的命运就是这个样子，什么我命由我不由天，我曾经也很相信呢，所以我不信邪，一直在找可以令人长生的法子，我觉得自己总有一天能胜过这个所谓的天命……", "46004");
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：直到在鬼界遇见伯父，我才明白……原来人可以做的努力是那样微小，人不能胜天，这是很平常的啊……", "46005");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：不是的……我觉得不是这样的……", "46006");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：好啦！不管是哪样的，反正我也没指望真能说服你这颗木鱼脑袋。", "46007");
        giPlayerEndAction(1);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：但是至少……你不要这样好不好？", "46008");
        giWait(0.5);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：你啊，怎么说也是我最好的朋友，我可不想看见好朋友整天一副要死不活的样子，看得我都好累……", "46009");
        giWait(0.30000001192092896);
        giSetPortrait("101G", true);
        giTalk("云天河：…………", "46010");
        giWait(0.30000001192092896);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：哎呀！人家难得下定决心讲这么恶心的话，你居然一点反应都没有，真不给面子……", "46011");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(1, 277.9153, -5.3224, -441.321);
        giPlayerSetPos(2, 52.7471, 87.375, -564.7172);
        giPlayerSetAng(2, 36.0);
        giPlayerSetAng(1, 110.0);
        giCameraRunSingle("019", true);
        giIMMEnd();
        giPlayerWalkTo(0, 287.8553, -3.2197, -444.6389, true);
        giPlayerSetAng(0, 289.0);
        giPlayerDoAction(0, "J10", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：啊！……", "46012");
        giWait(0.5);
        giSetPortrait("101G", false);
        giTalk("云天河：菱纱……", "46013");
        giSetPortrait("103A", true);
        giTalk("韩菱纱：……", "46014");
        giPlayerDoAction(1, "J10", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：你都这么大了，还撒娇啊……", "46015");
        giWait(0.5);
        giSetPortrait("101G", false);
        giTalk("云天河：…………", "46016");
        giWait(0.30000001192092896);
        giCameraRunSingle("020", false);
        giWait(0.5);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：天河……你可还记得？我说过，想找个像青鸾峰那样的地方隐居，过不理世事的日子。", "46017");
        giSetPortrait("101E", false);
        giTalk("云天河：……嗯。", "46018");
        giSetPortrait("103B", true);
        giTalk("韩菱纱：不如……等琼华派的事了了之后，我再去看过族人，我们就回青鸾峰吧，要是你想的话，也叫上梦璃、紫英……", "46019");
        giSetPortrait("103B", true);
        giTalk("韩菱纱：我希望……不管自己还能活多久，半年、几个月、几十天都没有关系……只要大家开开心心地活着，不要想伤心的事。", "46020");
        giWait(0.699999988079071);
        giSetPortrait("101A", false);
        giTalk("云天河：……我不会让你死的，我要去找玄霄，把望舒剑抢回来，不能让他做成剑柱！", "46021");
        giWait(0.5);
        giSetPortrait("101B", false);
        giTalk("云天河：等到那个时候，我们再一起回青鸾峰，我多盖几间屋子，让梦璃和紫英住。", "46022");
        giWait(0.5);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：傻瓜，我都说了，你不用太勉强……", "46023");
        giWait(3.0);
        giCameraRunSingle("023", true);
        giCameraRunSingle("021", false);
        giWait(2.0);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……", "46024");
        giWait(1.0);
        giNpcSetPos("MN002", 77.3307, 87.3755, -722.0998);
        giNpcSetAng("MN002", 26.0);
        giSetNpcVisible("MN002", true);
        giNpcWalkTo("MN002", 59.941, 87.3755, -649.269, false);
        giCameraRunSingle("022", false);
        giWait(2.5);
        giNpcEndMove("MN002");
        giWait(0.5);
        giNpcDoAction("MN002", "J01", -1, false);
        giSetPortrait("230A", true);
        giTalk("奚仲：少主，仪式已经准备得差不多了，婵幽大人请您即刻去里幻瞑宫。", "46025");
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", true);
        giPlayerSetDir(2, 190.0, true);
        giWait(0.5);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：我知道了。", "46026");
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetPos(1, -107.3274, 87.3755, -650.4742);
        giPlayerSetPos(0, -69.0487, 87.3755, -672.7938);
        giIMMEnd();
        giWait(1.2000000476837158);
        giFlashInBlack(2.0, false);
        giPlayerWalkTo(1, -22.6038, 87.3753, -599.9172, false);
        giWait(0.6000000238418579);
        giPlayerWalkTo(0, -1.1068, 87.3754, -619.8698, false);
        giPlayerEndMove(1);
        giPlayerSetAng(1, 61.0);
        giPlayerEndMove(0);
        giPlayerSetAng(0, 41.0);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：是不是有事情？", "46027");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(2, 234.0, true);
        giWait(0.5);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：我……", "46028");
        giWait(0.30000001192092896);
        giNpcFaceToPlayer("MN002", 0, true);
        giWait(0.5);
        giSetPortrait("230A", false);
        giTalk("奚仲：婵幽大人的身体越来越虚弱了，她希望少主能够尽快继承幻瞑界主人之位。", "46029");
        giPlayerSetDir(0, 109.0, false);
        giPlayerSetDir(1, 117.0, true);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：啊？", "46030");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.30000001192092896);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：你们……跟我一起来吧，我也派人去喊紫英了。", "46031");
        giPlayerSetDir(1, 61.0, false);
        giPlayerSetDir(0, 41.0, false);
        giNpcSetDir("MN002", 356.0, true);
        giWait(0.699999988079071);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：我希望，那个时刻来临时，我的朋友都能在身边……", "46032");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：做了妖界的主人，你跟以前会有不一样吗？", "46033");
        giPlayerEndAction(0);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：我还是我，不一样的是其他事情吧…… ", "46034");
        giPlayerEndAction(2);
        giSetPortrait("101A", true);
        giTalk("云天河：……？", "46035");
        giWait(0.6000000238418579);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：先去<colour red=255 green=187 blue=0 alpha=255>里幻瞑宫</colour><dc0>吧，</dc0><colour red=255 green=187 blue=0 alpha=255>幻瞑宫外通往那里的法阵</colour><dc0>已经打开，有话去那边再说也无妨。</dc0>", "46036");
        giFlashOutBlack(1.5, true, true);
        global_mvar = 150300; // 0x00024B1C, 继位仪式
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerSetVisible(2, false);
        giSetNpcVisible("MN002", false);
        giPlayerSetAng(0, 270.0);
        giCameraSetMode(4, true);
        giCameraSeekToPlayer();
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2007()
{
    if (global_mvar == 150300 /* 继位仪式 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P01-3", 2, 0.0, 0.0);
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -119.8494, -5.1106, -104.0741);
        giPlayerSetAng(0, 165.0);
        giPlayerSetPos(1, -82.3606, -5.1106, -102.1917);
        giPlayerSetAng(1, 192.0);
        giPlayerSetPos(2, -157.7486, -5.1106, -211.6978);
        giPlayerSetAng(2, 146.0);
        giPlayerSetPos(3, -160.6867, -5.1105, -87.3761);
        giPlayerSetAng(3, 162.0);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giCameraPrepare("MC003");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giPlayerSetEmotion(2, "106_yy");
        giCameraRunSingle("002", true);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：娘，我来了……", "46037");
        giPlayerEndAction(2);
        giIMMBegin();
        giNpcSetAng("MN001", 325.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(0.30000001192092896);
        giSetPortrait("229C", false);
        giTalk("婵幽：世事难料，璃儿你刚回来不久，却已经要担起这样的重任。", "46038");
        giWait(0.699999988079071);
        giIMMBegin();
        giNpcSetAng("MN001", 360.0);
        giPlayerSetAng(2, 20.0);
        giCameraRunSingle("004", true);
        giIMMEnd();
        giWait(0.6000000238418579);
        giSetPortrait("229C", false);
        giTalk("婵幽：……我要谢谢你们几个，在琼华派攻进来时，对我族施以援手。", "46039");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：这也没什么啦，呵呵。", "46040");
        giPlayerEndAction(0);
        giSetPortrait("229C", false);
        giTalk("婵幽：谢你们绝非矫情，但我还是不赞成人与妖交朋友，本想立刻将你们送回人间，但璃儿她希望你们待到仪式之后……", "46041");
        giSetPortrait("229C", false);
        giTalk("婵幽：所以若有什么话，便趁此机会说完吧。", "46042");
        giSetPortrait("101A", true);
        giTalk("云天河：说完？为什么？", "46043");
        giWait(0.5);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……", "46044");
        giWait(0.6000000238418579);
        giSetPortrait("229C", false);
        giTalk("婵幽：璃儿她即将继承幻瞑界主人之位，而你们，则会被送回人间，恐怕日后再无会面之期。", "46045");
        giPlayerDoAction(1, "J02", 1, false);
        giPlayerDoAction(0, "J02", -1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：什么？！", "46046");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.30000001192092896);
        giCameraRunSingle("005", false);
        giPlayerSetDir(0, 185.0, false);
        giPlayerSetDir(1, 220.0, false);
        giPlayerSetDir(3, 179.0, false);
        giWait(0.800000011920929);
        giSetPortrait("101H", true);
        giTalk("云天河：梦璃你……你要走？！你要……离开……", "46047");
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：娘刚才都已经说了……", "46048");
        giPlayerEndAction(2);
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：为什么一定要走？妖界都已经变成这样，难道不可以让大家一起去人间生活？", "46049");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：幻瞑界便是我族故乡，我族宁可灭亡，也不会离开这里的……", "46050");
        giWait(0.5);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：可是、可是这样我会很想你，又见不到你……", "46051");
        giWait(1.0);
        giCameraRunSingle("009", true);
        giCameraRunSingle("010", false);
        giWait(0.5);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：我也会想你……菱纱，你千万不要放弃，一定还有替你延命的办法！", "46052");
        giWait(0.5);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：我走以后，你要好好照顾自己，还有……照顾好云公子……", "46053");
        giWait(1.0);
        giIMMBegin();
        giSetNpcVisible("MN002", false);
        giPlayerSetAng(0, 200.0);
        giCameraRunSingle("011", true);
        giIMMEnd();
        giCameraRunSingle("012", false);
        giWait(0.30000001192092896);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：梦璃……你一直都对我很好……我不想你离开……", "46054");
        giPlayerEndAction(0);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：我……希望你们过得幸福。", "46055");
        giSetPortrait("103D", false);
        giTalk("韩菱纱：……！", "46056");
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：梦璃，我们、我们并不是你想的那样啊！你知道，我不能——", "46057");
        giPlayerEndAction(1);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：菱纱，什么都别说，我明白你在担心什么……但是，我还是请你不要放弃……", "46058");
        giPlayerEndAction(2);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：……", "46059");
        giWait(1.0);
        giIMMBegin();
        giCameraRunSingle("015", true);
        giPlayerSetAng(2, 15.0);
        giIMMEnd();
        giPlayerSetPos(1, -108.9511, -5.1106, -101.2317);
        giPlayerSetAng(1, 202.0);
        giPlayerSetPos(3, -168.2724, -5.1106, -115.6308);
        giPlayerSetAng(3, 171.0);
        giCameraRunSingle("016", false);
        giWait(1.0);
        giPlayerDoAction(2, "C07", -1, true);
        giSetObjectVisible("MO002", true);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：云公子，拜托你把这个离香草的香囊带回寿阳，交给爹和娘……告诉他们，女儿不孝，不能长伴他们左右，亦不能为他们养老，请裴大哥替我……替我略尽孝道，梦璃感激不尽……", "46060");
        giPlayerWalkTo(0, -142.5786, -5.1106, -162.4207, true);
        giPlayerSetAng(0, 204.0);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：……我……我一定带到。", "46061");
        giPlayerEndAction(0);
        giPlayerDoAction(0, "C07", -1, true);
        giWait(0.5);
        giSetObjectVisible("MO002", false);
        giWait(0.5);
        giAddProperty(3247, 1, true);
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, true);
        giSetObjectVisible("MO003", true);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：还有这个……云叔送给我的帝女翡翠，如今我已经用不上了，留给你做个纪念吧。", "46062");
        giSetPortrait("101E", true);
        giTalk("云天河：嗯……", "46063");
        giPlayerDoAction(0, "C07", -1, true);
        giWait(0.5);
        giSetObjectVisible("MO003", false);
        giWait(0.5);
        giAddProperty(3107, 1, true);
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(1.0);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……你的弓，已经换了新的吗？", "46064");
        giWait(0.5);
        giSetPortrait("101E", true);
        giTalk("云天河：这……是菱纱带我去一个地方取的。不过，你送的，我也一直留在身边！以后也不会丢掉的！", "46065");
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giWait(0.5);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……不必如此，若是旧了、不能用了，就扔了它吧……", "46066");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giWait(0.5);
        giCameraRunSingle("011", true);
        giWait(0.6000000238418579);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：……", "46067");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：我、我不会扔！你送的东西，除非我死！不然我一定保管得好好的！", "46068");
        giPlayerEndAction(0);
        giCameraRunSingle("012", false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：梦璃……", "46069");
        giPlayerSetDir(2, 352.0, true);
        giWait(0.699999988079071);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：紫英，谢谢你。", "46070");
        giPlayerEndAction(2);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：无须多言……我知道，你不喜欢妖，可是到最后，你还是愿意帮助我族，我很感激……", "46071");
        giSetPortrait("106F", true);
        giTalk("柳梦璃：我……我不太会说话，但是紫英你、永远都是我的挚友。", "46072");
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……我也一样。", "46073");
        giPlayerEndAction(3);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：保重！", "46074");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giNpcSetAng("MN001", 333.0);
        giWait(0.5);
        giSetPortrait("229C", true);
        giTalk("婵幽：璃儿，你如此伤怀，又怎能安心继位？", "46075");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(2, 143.0);
        giPlayerSetAng(0, 159.0);
        giCameraRunSingle("017", true);
        giSetNpcVisible("MN002", true);
        giIMMEnd();
        giWait(0.699999988079071);
        giSetPortrait("229C", false);
        giTalk("婵幽：不如我将你们彼此间的记忆通通消去，日后再无想念，自然也就不会伤心——", "46076");
        giIMMBegin();
        giPlayerSetPos(0, -107.1199, -5.1106, -162.5271);
        giPlayerSetAng(0, 171.0);
        giPlayerSetPos(1, -71.1326, -5.1106, -113.0493);
        giPlayerSetAng(1, 200.0);
        giPlayerSetPos(2, -153.0194, -5.1106, -215.5134);
        giPlayerSetAng(2, 134.0);
        giPlayerSetPos(3, -146.1094, -5.1105, -105.7533);
        giPlayerSetAng(3, 167.0);
        giIMMEnd();
        giCameraRunSingle("018", true);
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：不要！我不愿意忘了梦璃！", "46077");
        giPlayerEndAction(0);
        giPlayerSetDir(2, 38.0, true);
        giNpcSetDir("MN001", 9.0, true);
        giWait(0.699999988079071);
        giSetPortrait("229C", false);
        giTalk("婵幽：……你们人有种说法，叫作“因爱故生忧，因爱故生怖”，既然种种烦恼，都是由想或念而起，将烦恼的根源消去，岂不是一了百了？", "46078");
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：以后我想到梦璃，也许会很伤心，因为她又不在我身边……但是我也会想到，大家还在一起时，很多开心的事……", "46079");
        giPlayerEndAction(0);
        giSetPortrait("101G", true);
        giTalk("云天河：要是把这些都忘了，虽然不会难过，可是脑子里有一块地方都是空的，还有什么意思？", "46080");
        giWait(0.5);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：云公子……", "46081");
        giPlayerEndAction(2);
        giSetPortrait("229C", false);
        giTalk("婵幽：……年轻人，你倒比我想的更有良心，只可惜……", "46082");
        giWait(0.6000000238418579);
        giIMMBegin();
        giNpcSetAng("MN001", 55.0);
        giCameraRunSingle("019", true);
        giIMMEnd();
        giPlayerSetPos(0, -110.5543, -5.1106, -141.5638);
        giPlayerSetAng(0, 181.0);
        giWait(0.6000000238418579);
        giSetPortrait("229C", true);
        giTalk("婵幽：奚仲，你去月神殿将“梦见樽”取来。", "46083");
        giNpcSetDir("MN002", 245.0, true);
        giWait(0.5);
        giNpcDoAction("MN002", "J01", -1, false);
        giSetPortrait("230A", false);
        giTalk("奚仲：是！", "46084");
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", true);
        giWait(0.5);
        giNpcDoAction("MN002", "J02", 1, false);
        giWait(0.800000011920929);
        giEffectPlayWithNPC("H_497_X01", 1, "MN002");
        giNpcBlendOut("MN002", 2.0, true);
        giPlayerSetAng(2, 126.0);
        giCameraRunSingle("021", true);
        giSetPortrait("106G", true);
        giTalk("柳梦璃：娘……？", "46085");
        giWait(0.30000001192092896);
        giNpcSetDir("MN001", 327.0, true);
        giWait(0.5);
        giSetPortrait("229C", false);
        giTalk("婵幽：你放心，我并不会将你们的记忆消去，但你须答应我，继位之后一切以幻瞑界为重，绝不可溺于感伤，耗费心神！", "46086");
        giCameraRunSingle("022", false);
        giWait(1.0);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：是……璃儿…………答……应……娘……", "46087");
        giWait(1.0);
        giCameraWait();
        giWait(1.0);
        giEffectPlayWithNPC("H_497_X01", 1, "MN002");
        giNpcBlendIn("MN002", 2.0, true);
        giWait(0.5);
        giSetPortrait("230A", false);
        giTalk("奚仲：婵幽大人，梦见樽已经取来。", "46088");
        giWait(0.5);
        giIMMBegin();
        giNpcSetAng("MN001", 355.0);
        giNpcSetAng("MN002", 305.0);
        giSetObjectVisible("MO001", true);
        giSetObjectVisible("Jeffect009", true);
        giCameraRunSingle("023", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("106D", true);
        giTalk("柳梦璃：娘，这是……？", "46089");
        giSetPortrait("229C", false);
        giTalk("婵幽：……你且看好！", "46090");
        giWait(0.6000000238418579);
        giSetPortrait("229C", false);
        giTalk("婵幽：万灵悉来，神光映幽！引诸方想愿，入梦见之樽——无中而出、虚空即有！！", "46091");
        giCameraRunSingle("024", false);
        giNpcDoAction("MN001", "J02", 1, false);
        giEffectAttachToNpc("MN001", "H_TL01_1", true);
        giEffectAttachToNpc("MN001", "H_TL01_1", false);
        giWait(2.4000000953674316);
        gi2DSoundPlay("WE227", 1);
        giEffectPlayWithNPC("HW_TL02_1", 1, "MN001");
        giWait(7.0);
        giEffectDetachFromNpc("MN001");
        giIMMBegin();
        giSetObjectVisible("Jeffect009", false);
        giSetObjectVisible("Jeffect010", true);
        giSetObjectVisible("Jeffect003", true);
        giSetObjectVisible("Jeffect004", true);
        giSetObjectVisible("Jeffect005", true);
        giSetObjectVisible("Jeffect006", true);
        giIMMEnd();
        giWait(2.5);
        giEffectPlayWithNPC("H_132", 1, "MN003");
        giNpcBlendIn("MN003", 2.0, true);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P31", 2, 0.0, 0.0);
        giIMMBegin();
        giSetObjectVisible("Jeffect009", true);
        giSetObjectVisible("Jeffect010", false);
        giSetObjectVisible("Jeffect003", false);
        giSetObjectVisible("Jeffect004", false);
        giSetObjectVisible("Jeffect005", false);
        giSetObjectVisible("Jeffect006", false);
        giPlayerSetAng(2, 61.0);
        giCameraRunSingle("027", true);
        giIMMEnd();
        giPlayerSetEmotion(2, "106_zc");
        giWait(0.5);
        giCameraRunSingle("026", true);
        giWait(0.5);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：怎么会……有两个梦璃？！", "46092");
        giCameraRunSingle("025", true);
        giSetPortrait("229C", true);
        giTalk("婵幽：梦见樽乃是藏有神秘之力的法器，能够令人幻梦成真。", "46093");
        giPlayerSetDir(2, 151.0, true);
        giSetPortrait("229C", true);
        giTalk("婵幽：既然你们不愿璃儿离去，而她对你们亦是依依不舍，我便将此份思念之情，注入梦见樽，诞出另外一个璃儿……", "46094");
        giSetPortrait("229C", true);
        giTalk("婵幽：她虽只是傀儡，口不能言，亦无心智，有形而又无形，但却能如常人一般行动，往后便让她伴在你们身侧，犹如璃儿常在……", "46095");
        giPlayerSetDir(2, 40.0, false);
        giSetPortrait("229C", true);
        giTalk("婵幽：她不过是一场幻梦，当你们渐渐淡忘璃儿，梦就醒了，她也会消散无踪。", "46096");
        giNpcEndAction("MN001", true);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：不会！我们不会忘记梦璃的，因为这一切根本就不是梦，又哪来的梦醒……", "46097");
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetAng(2, 151.0);
        giCameraRunSingle("028", true);
        giIMMEnd();
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……娘，谢谢您！", "46098");
        giWait(0.5);
        giNpcSetDir("MN001", 310.0, true);
        giWait(0.5);
        giSetPortrait("229C", true);
        giTalk("婵幽：你不必谢我，记得你答应过我什么，言出必行，才是我的好女儿。", "46099");
        giWait(0.5);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：璃儿不敢或忘，定会时刻铭记在心。", "46100");
        giPlayerEndAction(2);
        giSetPortrait("229C", true);
        giTalk("婵幽：好了，随我过来祭坛，我要正式传位于你！", "46101");
        giWait(0.5);
        giPlayerDoAction(2, "C08", 1, true);
        giWait(0.5);
        giNpcWalkTo("MN001", -122.7278, 71.6055, -439.9642, false);
        giWait(0.5);
        giNpcWalkTo("MN002", -122.7278, 71.6055, -439.9642, false);
        giWait(1.5);
        giIMMBegin();
        giPlayerSetAng(2, 29.0);
        giPlayerSetAng(0, 191.0);
        giPlayerSetAng(1, 223.0);
        giPlayerSetAng(3, 170.0);
        giCameraRunSingle("029", true);
        giIMMEnd();
        giWait(0.5);
        giCameraRunSingle("030", false);
        giWait(0.5);
        giNpcEndMove("MN001");
        giNpcEndMove("MN002");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：梦璃……", "46102");
        giWait(0.5);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：…………", "46103");
        giCameraWait();
        giPlayerDoAction(2, "J07", 1, true);
        giWait(0.699999988079071);
        giSetObjectVisible("Jeffect009", false);
        giSetObjectVisible("MO001", false);
        giPlayerWalkTo(2, -109.5263, 10.7363, -300.7101, true);
        giPlayerSetVisible(2, false);
        giIMMBegin();
        giNpcSetPos("MN001", -134.4958, 87.3755, -593.8482);
        giNpcSetAng("MN001", 159.0);
        giNpcSetPos("MN002", -56.4034, 87.3755, -611.388);
        giNpcSetAng("MN002", 253.0);
        giPlayerSetAng(1, 234.0);
        giPlayerSetAng(0, 50.0);
        giNpcSetPos("MN003", -66.5203, -5.1105, -204.0054);
        giPlayerSetVisible(3, false);
        giIMMEnd();
        giCameraRunSingle("031", true);
        giWait(0.5);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：……天河，你这傻瓜……为什么不说几句挽留梦璃的话呢？", "46104");
        giPlayerEndAction(1);
        giSetPortrait("101G", true);
        giTalk("云天河：说了……她就不会走吗？", "46105");
        giWait(0.699999988079071);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：你……你太不懂女孩子的心了，梦璃她太可怜了……", "46106");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：我知道……她不会留下的，看她的眼睛就明白了，就算再舍不得，她也会选择和自己的族人在一起，同生共死。", "46107");
        giPlayerEndAction(0);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：……", "46108");
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(2, -124.7977, 87.3755, -652.1652);
        giPlayerSetAng(2, 343.0);
        giPlayerSetVisible(2, true);
        giCameraRunSingle("035", true);
        giIMMEnd();
        giWait(0.6000000238418579);
        giSetPortrait("229C", false);
        giTalk("婵幽：璃儿……现在，我将梦境之力传予你，我族始祖将于幻梦源头向你诉说亘古之谜，你知悉所有，须得护佑所有。", "46109");
        giWait(0.5);
        giSetPortrait("229C", false);
        giTalk("婵幽：自那一刻起，你便是幻瞑界之主，与我族共存共亡，生死相依，离异之心将引祸端，背弃之举必遭天罚。", "46110");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……", "46111");
        giWait(0.5);
        giIMMBegin();
        giNpcSetAng("MN001", 100.0);
        giPlayerSetAng(2, 49.0);
        giCameraRunSingle("036", true);
        giIMMEnd();
        giWait(0.699999988079071);
        giNpcDoAction("MN002", "J03", -1, false);
        giSetPortrait("230A", false);
        giTalk("奚仲：梦璃大人，如今您已是幻瞑界主人，奚仲在此发誓，会永远以自己的生命辅佐您、保护您，绝无背叛。", "46112");
        giWait(0.6000000238418579);
        giPlayerDoAction(2, "C08", 1, true);
        giWait(0.5);
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", true);
        giWait(0.30000001192092896);
        giSetPortrait("229C", true);
        giTalk("婵幽：奚仲，璃儿以后就交给你了，你们两人应该能体会我的安排。", "46113");
        giNpcSetDir("MN002", 293.0, true);
        giWait(0.6000000238418579);
        giNpcDoAction("MN002", "J01", 1, false);
        giSetPortrait("230A", false);
        giTalk("奚仲：是！奚仲知道。", "46114");
        giNpcEndAction("MN002", true);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(2, 345.0);
        giNpcSetAng("MN001", 160.0);
        giCameraRunSingle("037", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106G", true);
        giTalk("柳梦璃：娘！璃儿……璃儿……不能……", "46115");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giWait(0.30000001192092896);
        giSetPortrait("229C", false);
        giTalk("婵幽：璃儿，时候不早，你该命奚仲将你的朋友送回人间了。", "46116");
        giWait(0.5);
        giSetPortrait("229C", false);
        giTalk("婵幽：我灵力已耗去太多，须得沉眠一段时日，勿要相扰……", "46117");
        giWait(1.0);
        giNpcBlendOut("MN001", 3.0, true);
        giWait(0.5);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：娘……您保重。", "46118");
        giPlayerEndAction(2);
        giWait(0.800000011920929);
        giIMMBegin();
        giPlayerSetAng(2, 298.0);
        giPlayerSetPos(0, -238.0027, 87.3752, -625.04065);
        giPlayerSetAng(0, 90.0);
        giPlayerSetPos(1, -216.0188, 87.3752, -597.2074);
        giPlayerSetAng(1, 107.0);
        giPlayerSetPos(3, -220.7866, 87.3752, -563.0812);
        giPlayerSetAng(3, 127.0);
        giPlayerSetVisible(3, true);
        giCameraRunSingle("038", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……", "46119");
        giCameraRunSingle("039", false);
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, true);
        giWait(0.5);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：奚仲。", "46120");
        giNpcDoAction("MN002", "J01", -1, false);
        giSetPortrait("230A", false);
        giTalk("奚仲：属下在。", "46121");
        giSetPortrait("106A", true);
        giTalk("柳梦璃：我以妖界主人的名义，命你将云天河等人带往尊神坛，送返人间！", "46122");
        giSetPortrait("230A", false);
        giTalk("奚仲：是！", "46123");
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", true);
        giIMMBegin();
        giPlayerSetAng(0, 78.0);
        giPlayerSetAng(1, 94.0);
        giPlayerSetAng(3, 120.0);
        giCameraRunSingle("041", true);
        giIMMEnd();
        giNpcWalkTo("MN002", -140.7457, 87.3753, -580.4133, false);
        giWait(1.5);
        giNpcEndMove("MN002");
        giNpcSetDir("MN002", 262.0, true);
        giSetPortrait("230A", false);
        giTalk("奚仲：诸位请随我来。", "46124");
        giWait(1.0);
        giNpcWalkTo("MN002", -122.7278, 71.6055, -439.9642, false);
        giWait(1.5);
        giNpcEndMove("MN002");
        giSetNpcVisible("MN002", false);
        giIMMBegin();
        giPlayerSetAng(0, 90.0);
        giPlayerSetAng(1, 107.0);
        giPlayerSetAng(3, 127.0);
        giCameraRunSingle("042", false);
        giIMMEnd();
        giWait(1.0);
        giPlayerWalkTo(3, -179.4947, 87.3751, -615.3813, true);
        giPlayerSetDir(3, 110.0, true);
        giWait(0.5);
        giPlayerDoAction(3, "J07", 1, true);
        giWait(0.5);
        giPlayerDoAction(2, "J07", 1, true);
        giWait(0.5);
        giPlayerWalkTo(3, -122.7278, 71.6055, -439.9642, false);
        giWait(1.5);
        giCameraRunSingle("043", false);
        giPlayerWalkTo(1, -179.4947, 87.3751, -615.3813, true);
        giPlayerSetDir(1, 108.0, true);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：梦璃……再见了……", "46125");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.6000000238418579);
        giPlayerRunTo(1, -122.7278, 71.6055, -439.9642, true);
        giPlayerSetVisible(3, false);
        giPlayerSetVisible(1, false);
        giPlayerWalkTo(0, -185.4537, 87.3752, -615.1029, true);
        giPlayerSetDir(0, 102.0, true);
        giWait(0.5);
        giSetPortrait("101A", true);
        giTalk("云天河：梦璃，我……", "46126");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：我……", "46127");
        giPlayerEndAction(0);
        giWait(0.699999988079071);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：我走了。", "46128");
        giPlayerEndAction(0);
        giWait(1.5);
        giPlayerSetEmotion(2, "106_yy");
        giIMMBegin();
        giPlayerSetAng(0, 6.0);
        giPlayerSetAng(2, 312.0);
        giCameraRunSingle("044", false);
        giIMMEnd();
        giWait(0.699999988079071);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P69", 2, 0.0, 2.5);
        giWait(0.4000000059604645);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……云公子！", "46129");
        giWait(0.5);
        giPlayerSetDir(0, 121.0, true);
        giWait(0.5);
        giSetPortrait("101E", true);
        giTalk("云天河：梦璃……", "46130");
        giWait(1.0);
        giCameraRunSingle("045", false);
        giWait(1.7000000476837158);
        giSetPortrait("106I", false);
        giTalk("柳梦璃：我……云公子，我想要谢谢你……", "46131");
        giWait(2.0);
        giIMMBegin();
        giCameraRunSingle("046", true);
        giPlayerSetVisible(0, false);
        giIMMEnd();
        giCameraRunSingle("047", false);
        giWait(0.5);
        giSetPortrait("106I", true);
        giTalk("柳梦璃：谢谢你……给我留下那么多开心的回忆……我们一起御剑而飞，一起跋山涉水，一起在即墨看那些美丽的花灯……这些事情，我永远、永远不会忘记……", "46132");
        giWait(1.0);
        giSetPortrait("106I", true);
        giTalk("柳梦璃：遇上了你，我才明白……什么叫在意一个人、忧心一个人，还有……喜欢一个人…………", "46133");
        giWait(0.6000000238418579);
        giSetPortrait("106I", true);
        giTalk("柳梦璃：所以……往后请云公子一定要好好保重自己，千万不要让璃儿担心……", "46134");
        giWait(1.0);
        giIMMBegin();
        giPlayerSetVisible(0, true);
        giCameraRunSingle("048", true);
        giIMMEnd();
        giCameraRunSingle("049", false);
        giWait(0.6000000238418579);
        giSetPortrait("101G", true);
        giTalk("云天河：……", "46135");
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：……我会的……去一趟月牙村，再找玄霄夺回望舒剑之后，我就回到青鸾峰，再也不理山下这些打打杀杀的事……", "46136");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("050", false);
        giPlayerSetVisible(2, false);
        giIMMEnd();
        giCameraRunSingle("051", false);
        giWait(0.5);
        giSetPortrait("101G", true);
        giTalk("云天河：我一定……每天都会想起你，不会忘记你，不会让另外一个“梦璃”消失，就好像你还陪在我们身边一样……", "46137");
        giWait(1.0);
        giIMMBegin();
        giPlayerSetVisible(2, true);
        giPlayerSetAng(2, 298.0);
        giCameraRunSingle("052", true);
        giIMMEnd();
        giCameraRunSingle("053", false);
        giWait(0.6000000238418579);
        giPlayerSetEmotion(2, "106_kq");
        giSetPortrait("106F", true);
        giTalk("柳梦璃：…………菱纱……有的时候，我宁可自己是她，就算……就算…………", "46138");
        giWait(0.699999988079071);
        giSetPortrait("106I", true);
        giTalk("柳梦璃：至少，我是真的陪在云公子的身边……", "46139");
        giWait(1.0);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：不，你就是你，不用是其他人。", "46140");
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("106I", true);
        giTalk("柳梦璃：云公子，我……可以喊你一声“天河”吗？", "46141");
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：当然……", "46142");
        giPlayerEndAction(0);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(2, 312.0);
        giCameraRunSingle("056", true);
        giIMMEnd();
        giCameraRunSingle("057", false);
        giWait(0.5);
        giSetPortrait("106I", false);
        giTalk("柳梦璃：天河……今生有缘无份，若有来生……若有来生，我们再……", "46143");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：来生？就是下辈子？那要有多远？", "46144");
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106I", false);
        giTalk("柳梦璃：多远璃儿都不怕，就算人和妖的寿命差许多，你比我先入轮回……", "46145");
        giPlayerEndAction(2);
        giSetPortrait("106I", false);
        giTalk("柳梦璃：璃儿会努力的……一定会去找你的转世，到那个时候，我们再像从前一样，跋山涉水、游历天下……", "46146");
        giWait(0.5);
        giSetPortrait("106I", false);
        giTalk("柳梦璃：天河……好吗？", "46147");
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：我不要，根本不用等到那个时候！", "46148");
        giPlayerEndAction(0);
        giSetPortrait("101H", true);
        giTalk("云天河：梦璃，我知道的，每隔十九年，你们会再来人间！", "46149");
        giWait(0.30000001192092896);
        giSetPortrait("106I", false);
        giTalk("柳梦璃：……！", "46150");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：我跟你约好，十九年！十九年以后，我们再在昆仑山上相见！", "46151");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giCameraRunSingle("054", false);
        giPlayerSetEmotion(2, "106_bk");
        giSetPortrait("106I", false);
        giTalk("柳梦璃：…………", "46152");
        giWait(0.6000000238418579);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106I", false);
        giTalk("柳梦璃：天河，你知道这是不可能的……", "46153");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：你一定要来！", "46154");
        giWait(0.6000000238418579);
        giSetPortrait("106I", false);
        giTalk("柳梦璃：天河……", "46155");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：不管多久……我都会等……", "46156");
        giWait(1.0);
        giPlayerSetDir(2, 161.0, true);
        giWait(1.5);
        giCameraRunSingle("058", false);
        giWait(2.0);
        giSetPortrait("106I", false);
        giTalk("柳梦璃：……谁言别后终无悔，寒月清宵绮梦回……深知身在情长在，前尘不共彩云飞……", "46157");
        giWait(4.0);
        giSetPortrait("101H", true);
        giTalk("云天河：梦璃……", "46158");
        giFlashOutBlack(2.5, true, true);
        giPlayerSetEmotion(2, "106_zc");
        giCameraRunSingle("001", true);
        giPlayerInTeam(2, false);
        giPlayerInTeam(3, false);
        giWait(0.5);
        giCameraWait();
        global_mvar = 160100; // 0x00027164
        giArenaLoad("Q07", "Q07", "", true);
    }
}

void func2008()
{
    int select_dialog_last_select = 0;

    if (global_mvar == 140701 /* 第三章 / 8-4-2.妖界之主 / 里幻瞑宫 */)
    {
        giPlayerLock();
        giSelectDialogAddItem("1.是");
        giSelectDialogAddItem("2.否");
        giSelectDialogSetDefaultSelect(1);
        giShowSelectDialog("准备好要<colour red=221 green=27 blue=0 alpha=255>去里幻瞑宫</colour><dc0>了吗？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            giPlayerUnLock();
        }
        else
        {
            func2003();
        }
    }
}

void func2009()
{
    giPlayerLock();
    giNpcFaceToCurrentPlayer("MN002", true);
    giCurrentPlayerFaceToNpc("MN002", true);
    giSetPortrait("230A", true);
    giTalk("奚仲：即使你们是少主的朋友，在幻瞑界也请一切自重。", "");
    giNpcResetDir("MN002");
    giPlayerUnLock();
}

void func2010()
{
    if (global_mvar < 150100 && global_mvar >= 141400 /* 噩梦纷争 */)
    {
        giPlayerLock();
        giPlayerWalkTo(0, 137.1361, -11.8485, 6.5015, true);
        giPlayerSetDir(0, 252.0, true);
        giSetPortrait("101H", true);
        giTalk("云天河：琼华派的人已经冲了进来，<colour red=255 green=187 blue=0 alpha=255>现在要赶快赶去旋梦外围</colour><dc0>。</dc0>", "");
        giPlayerUnLock();
    }
}

void func4001()
{
    giPlayerLock();
    giNpcPauseBeh("4001");
    giTalk("觉糜：幻瞑界不应该有人进来！就算你们认识少主也一样！", "");
    giNpcResumeBeh("4001");
    giPlayerUnLock();
}

void func4002()
{
    giPlayerLock();
    giNpcPauseBeh("4002");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("梦筱筱：呜呜呜！怎么会这样！大家都被人杀死了……呜……");
        giRandTalkPush("梦筱筱：都是你们……是你们带那些人来杀大家的吧？娘说的对，绝对不能相信人……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("梦筱筱：你们……认识少主？……可是娘告诉我说，不管怎样，都不能相信人，不然下场一定会很惨……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4002");
    giPlayerUnLock();
}

void func4003()
{
    giPlayerLock();
    giNpcPauseBeh("4003");
    giRandTalkRelease();
    giRandTalkPush("子陌：在这战堂中修炼，修为就会提升很快，这一次我们绝不会败！");
    giRandTalkPush("子陌：我喜欢幻瞑界，喜欢住在幻瞑界的大家，任何人要破坏这里，我一定会拼死守护！");
    giRandTalk();
    giRandTalkRelease();
    giNpcResumeBeh("4003");
    giPlayerUnLock();
}

void func4004()
{
    giPlayerLock();
    giNpcPauseBeh("4004");
    giRandTalkRelease();
    giRandTalkPush("梦北柯：原本我并不憎恨人，十九年一次接近人间，倒也可以看看人间草木，但是如果人想挑起争端，我们也不可能示弱！");
    giRandTalkPush("梦北柯：你是少主的朋友？那又如何？人真的可信吗？");
    giRandTalk();
    giRandTalkRelease();
    giNpcResumeBeh("4004");
    giPlayerUnLock();
}

void func4005()
{
    giPlayerLock();
    giNpcPauseBeh("4005");
    giRandTalkRelease();
    giRandTalkPush("幼幻：听说有许多其他的妖住在人间，人和他们也是整天杀来杀去，为什么人都那么坏？");
    giRandTalkPush("幼幻：我虽然还很小，法力也不高，但是如果有人要打幻瞑界，我也要一起战斗！");
    giRandTalk();
    giRandTalkRelease();
    giNpcResumeBeh("4005");
    giPlayerUnLock();
}

void func4006()
{
    giPlayerLock();
    giNpcPauseBeh("4006");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("琢韵：那些人只是想成仙，就要杀我们吗？……成仙可以自己修炼啊，为什么一定要来害我们呢？");
        giRandTalkPush("琢韵：呜呜呜～归邪将军……他死了……虽然他以前一直说我笨，但其实对我很好很好的……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("琢韵：归邪将军说我有点笨，修炼起来会比其他貘辛苦，但是只要能守护幻瞑界，再辛苦的修炼我也不怕！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4006");
    giPlayerUnLock();
}

void func4007()
{
    giPlayerLock();
    giNpcPauseBeh("4007");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("幻天影：你们人真是狠心，为了成仙，连自己的朋友都可以杀……还有什么事是不能做的……");
        giRandTalkPush("幻天影：归邪和奚仲两位将军是十九年前那场大战后，仅剩的幻瞑护将了，如今连归邪将军也被杀害了，以后再和人开战，我们还有胜算吗？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("幻天影：人总是把“不能滥杀无辜”挂在嘴边？那为什么就要来杀我们呢？幻瞑界哪里犯到人间了？！");
        giRandTalkPush("幻天影：梦璃少主说她是被人养大的，这怎么可能？！人居然也有善待妖的？！我不相信，所以就算你是少主的朋友，我也不欢迎你！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4007");
    giPlayerUnLock();
}

void func4008()
{
    giPlayerLock();
    giNpcPauseBeh("4008");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("明迷：婵幽大人她……是不是已经快不行了呢？如今归邪将军也死了，我们能依靠的只有少主了……");
        giRandTalkPush("明迷：求仙到底是什么？那些人为了成仙，竟然连同伴也杀！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("明迷：十九年前元气大伤，也许这一次我们根本就没有力量对抗琼华派了，但是只要有一口气在，我们也要保护幻瞑界！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4008");
    giPlayerUnLock();
}

void func4009()
{
    giPlayerLock();
    gi2DSoundPlay("WB027", 1);
    giPlayerUnLock();
}

void func4010()
{
    giPlayerLock();
    giNpcPauseBeh("4010");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("束幻：我家幼幻……刚才一点都……咳咳，一点都不怕，很勇敢地迎敌，虽然……咳咳，还是敌、敌不过……但也总算……为保护……咳咳、大家出了力，没有白死啊……");
        giRandTalkPush("束幻：……儿子死了很多年，咳咳，现在连孙儿、孙儿也死在人的手里……这到底是为什么啊？……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("束幻：咳咳、咳咳咳……十九年啦……又是一场浩劫啊，不知道……咳咳……我幻瞑界能不能……咳咳……躲过这一次……");
        giRandTalkPush("束幻：我、咳咳……叫我家幼幻……待在这里安分一点，他偏要跑到、咳咳……外头，说什么，跟人……去拼命……就凭他、他那点能耐，那是去……咳咳，去送死啊！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4010");
    giPlayerUnLock();
}

void func4011()
{
    giPlayerLock();
    giNpcPauseBeh("4011");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("灵梦：子陌和幼幻都是我最好的朋友，可现在、现在他们都不在了……等我长大了，一定要杀了那些人，给他们报仇！");
        giRandTalkPush("灵梦：梦璃姐姐一定会成为幻瞑界的主人吧？我知道，婵幽大人的身体越来越不好了，已经不能再像以前一样带着我们对抗人了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("灵梦：我听说，人间是个很大很大的地方，有各种各样我们幻瞑界没有的东西，可是人都很可怕……我们去不了人间玩……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4011");
    giPlayerUnLock();
}

void func4012()
{
    giPlayerLock();
    giNpcPauseBeh("4012");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("幽蒙：婵幽大人会让梦璃少主继承她的位子吧？毕竟这些年来，她勉强支撑，灵力耗费得已经差不多了……也许不久之后，她就会离开我们……");
        giRandTalkPush("幽蒙：梦璃少主还年轻得很，就要肩负起整个幻瞑界了……幸好奚仲大人还能在她身边帮她……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("幽蒙：唉，人总说我们妖是怪物，在我看来，人才是怪物，为了得到他们想要的，什么事都做得出来……");
        giRandTalkPush("幽蒙：你是梦璃少主的朋友吧？……唉，这世上能和妖好好共处的人实在是不多……也算难得了……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4012");
    giPlayerUnLock();
}

void func4013()
{
    giPlayerLock();
    giNpcPauseBeh("4013");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("清乐：下一个十九年，梦璃少主真的能重振幻瞑界吗？……是不是过了十九年，又要和人拼个不死不休……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("清乐：琼华派迟早会攻破结界的，我宁可跟他们同归于尽，也好过坐以待毙！");
        giRandTalkPush("清乐：人常常做一些稀奇古怪的东西，我就看过他们的梦，也学会做一些人间的东西，我知道，并不是所有人都像琼华派那样可恨的……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4013");
    giPlayerUnLock();
}

void func4014()
{
    giPlayerLock();
    giNpcPauseBeh("4014");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("昔琳：真没想到……你们这些人竟然反过来帮貘，我一开始还不是很相信你们，现在看来，你们的确是少主的朋友啊……");
        giRandTalkPush("昔琳：能活着看到少主继位，我就已经满足了……不知什么时候，幻瞑界才能恢复往日的繁华……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("昔琳：十九年前那场大战，那些人不仅杀了好多貘，还耗损了我们不少灵力，能活下来的，也都变得体弱多病，不能再战了……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4014");
    giPlayerUnLock();
}

void func4015()
{
    giPlayerLock();
    giNpcPauseBeh("4015");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("意菲菲：……谢谢你帮了我们……但是……幻瞑界和人还是有仇，我永远都不会饶过那些人……我也忘不了死了的子陌他们……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("意菲菲：……我不和人说话的！就算是少主的朋友也一样……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4015");
    giPlayerUnLock();
}

void func4016()
{
    giPlayerLock();
    giNpcPauseBeh("4016");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("澈磨：幻瞑界就算毁灭了，也不是被那些卑劣的人打败的，我们都宁可像归邪将军那样战死……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("澈磨：我年纪大了，都快死了……可我放不下自己的孩子，那些人都是很残忍的，连这么小的孩子他们也不会放过，十九年前就是这样……");
        giRandTalkPush("澈磨：传说在人间有个叫蜀山的地方，那里有真正的妖界，不会受到人的扰乱和攻打，为什么、为什么幻瞑界却是这样惨……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4016");
    giPlayerUnLock();
}

void func4017()
{
    giPlayerLock();
    gi2DSoundPlay("WB027", 1);
    giPlayerUnLock();
}

void func4018()
{
    giPlayerLock();
    giNpcPauseBeh("4018");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("惑影：我、我不知道以后该怎么办，再过十九年，又要和人开战了，我一定要好好修炼，让自己变得很强很强，强到可以保护大家！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("惑影：束幻爷爷身上有道很深的伤口，听说是以前被人打伤的，一直都好不了，一定是用了什么厉害的法术吧……就像婵幽大人，她的伤也是很久很久没好了……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4018");
    giPlayerUnLock();
}

void func4019()
{
    giPlayerLock();
    giNpcPauseBeh("4019");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("思尘落：梦璃姐姐也很厉害，有她在，我不怕那些人，就算以后要再和他们拼命，我也不怕……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("思尘落：幻瞑界曾经有六个很厉害的将军，可是十九年前人来打我们，有四个将军为了保护大家就战死了……现在只剩下归邪大人和奚仲大人……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4019");
    giPlayerUnLock();
}

void func4020()
{
    giPlayerLock();
    giNpcPauseBeh("4020");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("雾惑：那些人要靠吸取幻瞑界的灵力来修仙，自己不努力，却梦想一步登天，你们人从来都这样贪心不足的！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("雾惑：你们人啊，口是心非、表里不一，白天兄弟相称，梦里刀剑相向，我看多了人的梦，对这种事情最了解了。");
        giRandTalkPush("雾惑：总有孩子想出去看看外面的世界，对他们来说，也许不想天天闷在这个地方，但是人妖不两立，他们去了人间只是送死啊……不是人人都像少主这样好运的。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4020");
    giPlayerUnLock();
}

void func4021()
{
    giPlayerLock();
    giNpcPauseBeh("4021");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("觉珑纱：我喜欢归邪将军……不想他死……可娘说他不可能再活过来了……为什么啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("觉珑纱：人是个怪东西，路边的乞丐梦见一块烧肉就笑得合不拢嘴，住大宅子的富豪梦见自己埋在财宝里，却还想要更多，这都是为什么呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4021");
    giPlayerUnLock();
}

void func4022()
{
    giPlayerLock();
    giNpcPauseBeh("4022");
    giRandTalkRelease();
    giRandTalkPush("凝莫彻：少主被人养育了十九年，到如今才突然回来，说不定她对人的感情反而更深，不然又怎会让你们进来幻瞑界……");
    giRandTalkPush("凝莫彻：我不知道少主是怎么想的，可婵幽大人一定会让她成为新的幻瞑之主，你们还是快点离开吧，妖和人注定不能相交的。");
    giRandTalk();
    giRandTalkRelease();
    giNpcResumeBeh("4022");
    giPlayerUnLock();
}

void func4023()
{
    giPlayerLock();
    giNpcPauseBeh("4023");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("风黎：婵幽大人支撑幻瞑界这么久，也是该歇息歇息了……以后就靠少主和奚仲大人了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("风黎：幻瞑界中，以婵幽大人的灵力最强，只是十九年前她被人重伤，不宜再催动灵力，如今的少主又还不够强，这一次确是凶多吉少啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4023");
    giPlayerUnLock();
}

void func4024()
{
    giPlayerLock();
    giNpcPauseBeh("4024");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("晓雾：那些人太残忍了！！扉衣身上中了好几剑，是被他们活活砍死的！我、我以后要一直修炼，一定要变强，替扉衣、还有其他的貘报仇！！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("晓雾：明知敌不过，扉衣他们却还是要坚持死守……我、我真的不喜欢打打杀杀的事情，为什么不能想别的办法解决呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4024");
    giPlayerUnLock();
}

void func4026()
{
    giPlayerLock();
    giNpcPauseBeh("4026");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("莫云光：真正的仙人我也见过，那是逍遥自在、无欲无求的境界，那些昆仑琼华派的人满面狰狞，哪里有半点仙风道骨的样子！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("莫云光：貘能吃人的梦，知道人心里在想些什么，可是人却只活在自己的世界中，他们根本不愿意了解其他的东西，只要被他们归为异类，就会格杀勿论！");
        giRandTalkPush("莫云光：幻瞑界如天轨运移，每十九年最接近人间一次，这原本也是自然之理，如今却变成了整个幻瞑界最大的浩劫……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4026");
    giPlayerUnLock();
}

void func4027()
{
    giPlayerLock();
    giNpcPauseBeh("4027");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("寂同岚：任何一族都会有兴衰，如今幻瞑界虽是处境艰难，但只要不遭灭族，我们必有再兴起的一日。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("寂同岚：梦貘一族世世代代居于幻瞑界，与别的妖界并无往来，貘的法力虽然来自于幻境，会吞食别人的梦，但我们不会害人，也不会轻易去窥探那些梦。");
        giRandTalkPush("寂同岚：幻瞑界原本悠游于天地之间，从不参与六界纷争，若不是人来犯我，又怎会有今日的局面？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4027");
    giPlayerUnLock();
}

void func4028()
{
    giPlayerLock();
    giNpcPauseBeh("4028");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("游非：梦璃少主继承了婵幽大人的血脉，又有奚仲将军从旁辅佐，日后一定会成为出色的幻瞑之主吧。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("游非：婵幽大人从前经常与诸位将军在幻瞑宫内共商大事，可是如今她的身体一日比一日差，几乎从不踏出幻瞑宫，只有少主从人间回来的事，让她很是高兴，精神好了一些。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4028");
    giPlayerUnLock();
}

void func4036()
{
    giPlayerLock();
    giNpcPauseBeh("4036");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giRandTalkRelease();
        giRandTalkPush("烟漠漠：这些弟弟妹妹们的爹娘都被琼华派的人杀死了，不过我会照顾他们，让他们快快长大，以后大家一起保护幻瞑界，保护梦璃大人！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("烟漠漠：娘的身体一直不好，听族里的前辈们说，是很久以前被仙人打伤的，就像婵幽大人的伤一样……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4036");
    giPlayerUnLock();
}

void func4044()
{
    giPlayerLock();
    giNpcPauseBeh("4044");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giTalk("思宁：修仙的事情，我不太懂，但至少知道“修成正果”需行善积德，琼华派人如此滥杀无辜，怎么可能修成仙身？！", "");
    }
    else
    {
        giTalk("思宁：月神带来宁静的夜晚，夜晚带来美丽的梦幻，我们幻瞑一族以梦为食，以月华为灵，从来都是与世无争，却怎会招惹了琼华派那样的凶恶之人？", "");
    }
    giNpcResumeBeh("4044");
    giPlayerUnLock();
}

void func4045()
{
    giPlayerLock();
    giNpcPauseBeh("4045");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giTalk("空月：可笑那些琼华弟子，杀我们的时候就说“妖即是恶”，可他们杀自己人的时候，不也一样毫不手软？哼！", "");
    }
    else
    {
        giTalk("空月：五界生灵寂灭为鬼，人与妖、仙与兽，全都是一样的，人们为什么总是以为妖是害人的，仙才是救人的呢？", "");
    }
    giNpcResumeBeh("4045");
    giPlayerUnLock();
}

void func4046()
{
    giPlayerLock();
    giNpcPauseBeh("4046");
    if (global_mvar >= 150100 /* 噩梦纷争 */)
    {
        giTalk("承清影：修仙的人最爱说“拯救苍生”……其实根本就是胡说！难道妖就不属“苍生”，可以随意屠戮吗？", "");
    }
    else
    {
        giTalk("承清影：人们总是说“仙人”是没有感情和欲望的“人”，可是我知道，“仙人”在梦里也还是一样会哭会笑，和普通“人”没什么不一样。", "");
    }
    giNpcResumeBeh("4046");
    giPlayerUnLock();
}

void func5001()
{
    bool has_property_3256 = false;
    bool has_property_3257 = false;

    giPlayerLock();
    giNpcPauseBeh("4018");
    giCurrentPlayerFaceToNpc("4018", true);
    if (maze_var9 != 0)
    {
        if (maze_var9 != 1)
        {
            giStartTradeSystem("shop009", "");
        }
        else
        {
            has_property_3256 = giCheckPackProperty(3256, 5);
            has_property_3257 = giCheckPackProperty(3257, 5);
            if (giCheckPackProperty(3256, 5) && has_property_3257)
            {
                giTalk("枕影：谢谢，谢谢你！这回束幻爷爷可有救了！这些黄色的星星是我的宝贝，送给你，谢谢你对我们这么好！", "");
                giDelProperty(3256, 5, true);
                giWait(2.0);
                giDelProperty(3257, 5, true);
                giWait(2.0);
                giAddProperty(3168, 4, true);
                giWait(2.0);
                maze_var9 = 2;
            }
            giStartTradeSystem("shop009", "");
        }
    }
    else
    {
        giStartTradeSystem("shop009", "Buiness_Q14_5001");
    }
    giNpcResumeBeh("4018");
    giPlayerUnLock();
}

void func5002()
{
    giPlayerLock();
    giNpcPauseBeh("4013");
    giCurrentPlayerFaceToNpc("4013", true);
    giStartTradeSystem("shop019", "");
    giNpcResumeBeh("4013");
    giPlayerUnLock();
}

void func5003()
{
    giPlayerLock();
    giNpcPauseBeh("4008");
    giCurrentPlayerFaceToNpc("4008", true);
    if (maze_var10 != 0)
    {
        if (maze_var10 != 1)
        {
            giStartTradeSystem("shop030", "");
        }
        else
        {
            if (giCheckPackProperty(3219, 1))
            {
                giTalk("溪玉幻：是炼火珠？不错、不错，没想到还有人会帮我们貘……", "");
                giTalk("溪玉幻：这几种新的注灵方法是我自创的，现在告诉你，算是报答你对我们这么好。", "");
                maze_var10 = 2;
                giDelProperty(3219, 1, true);
                giWait(2.0);
                giAddPrescription(8161, true);
                giWait(2.0);
                giAddPrescription(8162, true);
                giWait(2.0);
                giAddPrescription(8163, true);
                giWait(2.0);
            }
            giStartTradeSystem("shop030", "");
        }
    }
    else
    {
        giStartTradeSystem("shop030", "Buiness_Q14_5003");
    }
    giNpcResumeBeh("4008");
    giPlayerUnLock();
}

void func5004()
{
    giPlayerLock();
    giFlashOutBlack(3.0, true, true);
    giPlayerTakeARest();
    giWait(2.0);
    giFlashInBlack(3.0, true);
    giPlayerUnLock();
}

void Buiness_Q14_5001()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("束幻爷爷身上的旧伤又复发了，可是我这里的药有点不太够，你能帮我找一些<colour red=255 green=187 blue=0 alpha=255>紫陌清风</colour><dc0>和</dc0><colour red=255 green=187 blue=0 alpha=255>无衣神水</colour><dc0>吗？量也不能少了，</dc0><colour red=255 green=187 blue=0 alpha=255>至少得各五瓶</colour><dc0>。治好了束幻爷爷，我会报答你的！</dc0><br/><dc0>你愿意帮我去找一些吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        maze_var9 = 1;
    }
}

void Buiness_Q14_5003()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("我冷焰寮中铸炼兵刃的火焰乃是以紫晶石的灵力幻化，虽含极强的灵力，但却始终不够热，若能取得传说中的<colour red=255 green=187 blue=0 alpha=255>炼火珠</colour><dc0>，对我铸造兵刃必然大有助益。</dc0><br/><dc0>你愿意帮我去找来吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        maze_var10 = 1;
    }
}

void func7001()
{
    float current_player_pos_y = 0.0;

    current_player_pos_y = giPlayerCurrentGetPosY();
    if (giPlayerCurrentGetPosY() < 2616.0)
    {
        if (current_player_pos_y < 730.0)
        {
            func7502();
        }
        else
        {
            func7501();
        }
    }
    else
    {
        func7500();
    }
}

void func7500()
{
    giSetMinimapLevel(0);
}

void func7501()
{
    giSetMinimapLevel(1);
}

void func7502()
{
    giSetMinimapLevel(2);
}
