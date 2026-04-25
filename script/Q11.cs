// Structured PAL4 reconstruction for Q11.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void Q11_Q11W_init()
{
    if (global_mvar < 130600 /* 第三章 / 8-2-2.是昔流芳 / 前往转轮镜台 */)
    {
        giIMMBegin();
        giEventVolumeVisible("ev_Q11_Q11W_14", false);
        giSetObjectVisible("entrance2", false);
        giIMMEnd();
        giArenaReadyRestore();
    }
    if (global_mvar != 130500 /* 第三章 / 8-1-3.龙颜怒 / 进入鬼界 / 大荒不周 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2001();
    }
}

void Q11_Q11Z_init()
{
    if (global_mvar < 130700 /* 第三章 / 8-2-3.是昔流芳 / 逃往放逐渊 / 重逢天青 */)
    {
        giIMMBegin();
        giEventVolumeVisible("ev_Q11_Q11Z_4", false);
        giSetObjectVisible("entrance2", false);
        giIMMEnd();
        giArenaReadyRestore();
    }
    if (global_mvar < 130700 /* 第三章 / 8-2-3.是昔流芳 / 逃往放逐渊 / 重逢天青 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetObjectVisible("entrance1", false);
        giArenaReadyRestore();
    }
}

void func1001()
{
    giArenaLoad("Q11", "WN01", "", true);
    giPlayerCurrentSetPos(-0.427254, 0.064308, 161.59172);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("Q11", "Q11W", "", true);
    giPlayerCurrentSetPos(551.08905, 3.563637, 1765.4138);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("Q11", "WN02", "", true);
    giPlayerCurrentSetPos(0.0, 0.685921, 171.76897);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("Q11", "Q11W", "", true);
    giPlayerCurrentSetPos(-82.056786, -3.939598, 98.11096);
    giPlayerCurrentSetAng(267.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("Q11", "WN03", "", true);
    giPlayerCurrentSetPos(-3.614956, 0.074373, 285.47546);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("Q11", "Q11W", "", true);
    giPlayerCurrentSetPos(632.985, -3.939596, -667.6811);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1007()
{
    giArenaLoad("Q11", "WN04", "", true);
    giPlayerCurrentSetPos(0.914266, 0.315567, 260.61005);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1008()
{
    giArenaLoad("Q11", "Q11W", "", true);
    giPlayerCurrentSetPos(661.7681, -3.939613, 865.2905);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1009()
{
    giArenaLoad("Q11", "WN05", "WN05a", true);
    giPlayerCurrentSetPos(0.159629, 0.079573, 196.45384);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1010()
{
    giArenaLoad("Q11", "Q11W", "", true);
    giPlayerCurrentSetPos(-678.29565, -3.9396, 1066.9094);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1011()
{
    giArenaLoad("Q11", "WN05", "WN05b", true);
    giPlayerCurrentSetPos(0.159629, 0.079573, 196.45384);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1012()
{
    giArenaLoad("Q11", "Q11W", "", true);
    giPlayerCurrentSetPos(1682.807, -2.846247, -1488.3425);
    giPlayerCurrentSetAng(0.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1013()
{
    giArenaLoad("Q11", "WN05", "WN05c", true);
    giPlayerCurrentSetPos(0.159629, 0.079573, 196.45384);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1014()
{
    giArenaLoad("Q11", "Q11W", "", true);
    giPlayerCurrentSetPos(1689.3835, -3.939596, -1135.045);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1015()
{
    giArenaLoad("Q11", "Q11Z", "", true);
    giPlayerCurrentSetPos(-1384.7213, 77.91941, -338.4864);
    giPlayerCurrentSetAng(89.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1016()
{
    if (global_mvar < 130700 /* 第三章 / 8-2-3.是昔流芳 / 逃往放逐渊 / 重逢天青 */)
    {
        giArenaLoad("Q11", "Q11W", "", true);
        giPlayerCurrentSetPos(2800.6384, -3.800091, 362.1831);
        giPlayerCurrentSetAng(265.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giPlayerLock();
        giPlayerWalkTo(0, -1322.0437, 55.7461, -330.9708, true);
        giPlayerSetDir(0, 87.0, true);
        giSetPortrait("101A", true);
        giTalk("云天河：不能再回无常殿那边了，<colour red=255 green=187 blue=0 alpha=255>要从南边的出口离开</colour><dc0>。</dc0>", "");
        giPlayerUnLock();
    }
}

void func1017()
{
    if (global_mvar != 130700 /* 第三章 / 8-2-3.是昔流芳 / 逃往放逐渊 / 重逢天青 */)
    {
        giArenaLoad("M16", "1", "", true);
        giPlayerCurrentSetPos(-1560.6384, -0.138428, -1243.6384);
        giPlayerCurrentSetAng(30.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("M16", "1", "", true);
    }
}

void func1018()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(1553.9966, -3.939604, 1642.8724, true);
    giPlayerCurrentSetAng(180.0);
    giSetPortrait("101C", true);
    giTalk("云天河：房门锁住了……", "");
    giPlayerUnLock();
}

void func1019()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(-1058.4524, -3.939604, -1123.4587, true);
    giPlayerCurrentSetAng(357.0);
    giSetPortrait("101C", true);
    giTalk("云天河：牢房锁住了……", "");
    giPlayerUnLock();
}

void func1020()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(-641.3523, -3.939604, -1118.1318, true);
    giPlayerCurrentSetAng(358.0);
    giSetPortrait("101C", true);
    giTalk("云天河：牢房锁住了……", "");
    giPlayerUnLock();
}

void func1021()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(359.76724, -3.944456, -1471.3098, true);
    giPlayerCurrentSetAng(0.0);
    giSetPortrait("101C", true);
    giTalk("云天河：牢房锁住了……", "");
    giPlayerUnLock();
}

void func2001()
{
    if (global_mvar == 130500 /* 第三章 / 8-1-3.龙颜怒 / 进入鬼界 / 大荒不周 */)
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -2706.9136, -4.2084, -446.2675);
        giPlayerSetAng(0, 84.0);
        giPlayerSetPos(1, -2736.9233, -4.2084, -494.8883);
        giPlayerSetAng(1, 88.0);
        giPlayerSetPos(3, -2703.2388, -4.2084, -533.3636);
        giPlayerSetAng(3, 92.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giCameraSetDistOptEnable(false);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giWait(1.0);
        giCameraRunSingle("002", true);
        giWait(2.0);
        giIMMBegin();
        giCameraSetDistOptEnable(true);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：……这里好阴森……我觉得好不舒服……", "44886");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：悬浮在空中的，应该就是无常殿吧？", "44887");
        giWait(0.5);
        giPlayerSetDir(0, 214.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101A", false);
        giTalk("云天河：快点！我们这就去取<colour red=255 green=187 blue=0 alpha=255>翳影枝</colour><dc0>！</dc0>", "44888");
        giPlayerEndAction(0);
        giPlayerSetDir(1, 36.0, false);
        giPlayerSetDir(3, 4.0, false);
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：哎！等一下，我们连<colour red=255 green=187 blue=0 alpha=255>翳影枝</colour><dc0>长在哪里都不知道，等会儿万一有了线索，你们先别行动，让我去，我手脚轻，才不会惊动周围！</dc0>", "44889");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：好！", "44890");
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetPos(-2706.9136, -4.2084, -446.2675);
        giPlayerCurrentSetAng(50.0);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        global_mvar = 130501; // 0x0001FDC5, 第三章 / 8-2-1.是昔流芳 / 寻找翳影枝
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2002()
{
    if (global_mvar == 130501 /* 第三章 / 8-2-1.是昔流芳 / 寻找翳影枝 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 1384.0654, -3.8001, 812.1548);
        giPlayerSetPos(1, 1434.4014, -3.8001, 786.8359);
        giPlayerSetPos(3, 1360.4742, -3.8001, 772.5702);
        giPlayerSetAng(0, 156.0);
        giPlayerSetAng(1, 180.0);
        giPlayerSetAng(3, 156.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giSetObjectVisible("entrance2", false);
        giSetNpcVisible("4002", false);
        giSetNpcVisible("4011", false);
        giSetNpcVisible("5001", false);
        giSetNpcVisible("4009", false);
        giSetNpcVisible("4006", false);
        giSetNpcVisible("5002", false);
        giSetNpcVisible("4010", false);
        giSetNpcVisible("4003", false);
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giFlashInBlack(1.5, true);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：那边，好像有两个人在守着什么……", "44891");
        giCameraRunSingle("002", true);
        giPlayerDoAction(0, "C01", 1, false);
        giWait(0.8);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：哎？中间黑乎乎的那些，就是翳影枝吧？", "44892");
        giWait(0.5);
        giCameraRunSingle("003", true);
        giWait(0.8);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：我过去瞧瞧！", "44893");
        giWait(0.5);
        giPlayerSetDir(0, 124.0, false);
        giPlayerSetDir(3, 86.0, false);
        giWait(0.8);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：你一切小心！若有万一，就喊我们！", "44894");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giPlayerSetDir(1, 264.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：小紫英～你怎么对我这么没信心，别的做不好，偷东西我可是从没出过差错！", "44895");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：……", "44896");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：好了！我走了，你放宽心，嘻嘻～", "44897");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerWalkTo(1, 1525.662, -3.8001, 623.2441, false);
        giWait(1.6);
        giPlayerSetDir(0, 135.0, false);
        giPlayerSetDir(3, 115.0, false);
        giWait(0.3);
        giCameraRunSingle("004", true);
        giWait(1.5);
        giTalk("鬼卒甲：唉……每天守着这翳影枝，真是无聊死了，这东西在鬼界又不稀奇，谁会想偷拿……", "44898");
        giWait(0.5);
        giNpcSetDir("MN002", 192.0, true);
        giWait(0.5);
        giTalk("鬼卒乙：这翳影枝确实一点都不稀奇，但能让我们鬼卒任意往来六界，对他界生灵来说，应该是求也求不到的宝贝吧！", "44899");
        giWait(0.3);
        giNpcSetDir("MN001", 352.0, true);
        giWait(0.5);
        giTalk("鬼卒乙：别抱怨了～你嫌这差事不好，难道想被调进无常殿当差，那可是累到不行！", "44900");
        giWait(0.5);
        giTalk("鬼卒甲：累的差事我才不干……我只是常常想，我们离转轮镜台那么近，却一次也没溜去看过……", "44901");
        giWait(0.5);
        giTalk("鬼卒乙：哦？原来你也听说过啊，要是站在转轮镜前，诚心想念，就会见到死去亲人的魂魄，可是，你还有亲人在鬼界吗？", "44902");
        giWait(0.5);
        giTalk("鬼卒甲：我哪知道……他们去投胎，也不一定告诉我……", "44903");
        giWait(0.5);
        giTalk("鬼卒乙：好了好了，别多话，专心看着这几根树枝……", "44904");
        giWait(0.7);
        giTalk("鬼卒乙：唉，好睏……", "44905");
        giWait(0.5);
        giNpcSetDir("MN002", 264.0, false);
        giNpcSetDir("MN001", 256.0, false);
        giWait(1.7);
        gi2DSoundPlay("WJ037", 1);
        giWait(0.4);
        giNpcSetAng("MN001", 80.0);
        giNpcDoAction("MN001", "Z01", 0, false);
        giNpcSetAng("MN002", 114.0);
        giNpcDoAction("MN002", "Z01", 0, false);
        giWait(0.6);
        giCameraRunSingle("005", false);
        giTalk("鬼卒甲：什么声音？", "44906");
        giWait(1.8);
        giNpcSetDir("MN002", 180.0, true);
        giWait(0.5);
        giTalk("鬼卒乙：喂，你听错了吧？", "44907");
        giNpcEndAction("MN001", true);
        giWait(0.5);
        giTalk("鬼卒甲：是吗？我活着的时候耳朵是不太灵光，想不到死了也还是不灵……", "44908");
        giWait(0.5);
        giTalk("鬼卒乙：这不就得了……", "44909");
        giWait(0.5);
        giIMMBegin();
        giNpcSetAng("MN001", 270.0);
        giNpcSetAng("MN002", 260.0);
        giPlayerSetPos(1, 1561.5687, -3.8, 671.9814);
        giPlayerSetAng(1, 308.0);
        giPlayerSetAng(0, 138.0);
        giPlayerSetAng(3, 102.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerWalkTo(1, 1422.1261, -3.8001, 777.0053, true);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：看，三根翳影枝到手！", "44910");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giAddProperty(3114, 3, true);
        giWait(2.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：幸好那两个看守鬼卒呆呆的，反应又慢，不过我不敢拿太多，真被发现就惨了。", "44911");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：太棒了！菱纱你果然是大大的盗贼，太厉害了！这下我们可以回去了？", "44912");
        giPlayerEndAction(0);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：先找找线索，看有什么办法回到人界吧。", "44913");
        giPlayerEndAction(3);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：我、我有一个想去的地方……", "44914");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101C", false);
        giTalk("云天河：啊？", "44915");
        giCameraRunSingle("007", false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：刚才……我听那两个鬼卒说，<colour red=255 green=187 blue=0 alpha=255>在无常殿的不远处有个叫转轮镜台的地方，</colour><dc0>要是在那里诚心想念，就能见到死去亲人的魂魄……当然，一定要还没有投胎的……</dc0>", "44916");
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：我……很想见一见伯父……", "44917");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101D", false);
        giTalk("云天河：可以见到死去的亲人？是真的吗？", "44918");
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：那我也想见爹，我有好多话想问他！", "44919");
        giWait(1.0);
        giPlayerSetDir(1, 276.0, false);
        giPlayerSetDir(0, 188.0, false);
        giWait(1.0);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：…………", "44920");
        giWait(0.5);
        giSetPortrait("101E", true);
        giTalk("云天河：…………", "44921");
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(3, 1361.7185, -3.8001, 753.8445);
        giPlayerSetAng(3, 70.0);
        giPlayerSetAng(1, 262.0);
        giPlayerSetAng(0, 205.0);
        giCameraRunSingle("008", true);
        giIMMEnd();
        giWait(0.7);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：你们……别看我，我虽然不想节外生枝，但是你们都想去，我当然也只有奉陪。", "44922");
        giWait(0.5);
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：哈哈，真的吗？", "44923");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：嘻嘻～小紫英，我就知道你最好了。", "44924");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：不过～你都没有想要见的亲人吗？", "44925");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giPlayerDoAction(3, "C09", 1, false);
        giWait(1.0);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……我幼时体弱，家中怕我命不长久，将我送上昆仑山修行，自那以后，再也未有联络，可以说此生亲缘极淡，无所记挂。", "44926");
        giWait(0.5);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：……原来是这样哦。", "44927");
        giWait(0.3);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：（总觉得紫英虽然从来都不提，但心里一定还是很难过的吧……）", "44928");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(0, 134.0, true);
        giWait(0.5);
        giSetPortrait("101B", false);
        giTalk("云天河：我们别等了，走吧！那个台子在哪里？", "44929");
        giWait(0.3);
        giPlayerSetDir(1, 314.0, true);
        giWait(0.5);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：<colour red=255 green=187 blue=0 alpha=255>我也只知道在无常殿附近</colour><dc0>啊，要找找看。</dc0>", "44930");
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetPos(1384.0654, -3.8001, 812.1548);
        giPlayerCurrentSetAng(138.0);
        giSetNpcVisible("4002", true);
        giSetNpcVisible("4011", true);
        giSetNpcVisible("5001", true);
        giSetNpcVisible("4009", true);
        giSetNpcVisible("4006", true);
        giSetNpcVisible("5002", true);
        giSetNpcVisible("4010", true);
        giSetNpcVisible("4003", true);
        giEventVolumeVisible("ev_Q11_Q11W_14", true);
        giSetObjectVisible("entrance2", true);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        global_mvar = 130600; // 0x0001FE28, 第三章 / 8-2-2.是昔流芳 / 前往转轮镜台
        giCameraSetMode(0, true);
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2003()
{
    if (global_mvar == 130600 /* 第三章 / 8-2-2.是昔流芳 / 前往转轮镜台 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -49.2209, 61.4343, -141.5759);
        giPlayerSetPos(1, -12.1483, 60.9357, -130.8005);
        giPlayerSetPos(3, -82.4788, 60.9358, -123.0781);
        giNpcSetPos("MN001", -29.919, 125.6224, -636.0084);
        giNpcSetAng("MN001", 354.0);
        giPlayerSetAng(0, 182.0);
        giPlayerSetAng(1, 184.0);
        giPlayerSetAng(3, 184.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giSetObjectVisible("entrance1", false);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, false);
        giCameraRunSingle("002", false);
        giPlayerWalkTo(0, -49.2209, 123.7229, -266.1423, false);
        giPlayerWalkTo(1, -12.1483, 112.9154, -261.1536, false);
        giPlayerWalkTo(3, -82.4788, 112.9154, -258.7605, true);
        giWait(2.2);
        giPlayerEndMove(0);
        giPlayerEndMove(1);
        giIMMBegin();
        giPlayerSetPos(0, -49.2209, 123.7229, -266.1423);
        giPlayerSetPos(1, -12.1483, 112.9154, -261.1536);
        giPlayerSetPos(3, -82.4788, 112.9154, -258.7605);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(1.0);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：……好大一面镜子，只要在这里喊爹，他就会出现吗？", "44931");
        giPlayerEndAction(0);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：不是喊啦！是在心里诚心想念，灵不灵不晓得，只有试试看了。", "44932");
        giPlayerDoAction(0, "C08", 1, true);
        giWait(0.5);
        giPlayerWalkTo(1, -27.9721, 125.6224, -478.4119, false);
        giPlayerWalkTo(0, -75.9629, 125.6224, -482.3344, false);
        giWait(1.1);
        giCameraRunSingle("004", true);
        giPlayerEndMove(1);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 150.0, false);
        giPlayerSetDir(1, 180.0, true);
        giWait(1.8);
        giCameraRunSingle("005", false);
        giSetPortrait("101J", true);
        giTalk("云天河：（……爹，孩儿、孩儿有好多话想和你说，要是你能听到，就来跟孩儿见上一面吧！）", "44933");
        giWait(2.0);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：（……大伯，我好想你，你能来见一见菱纱吗？……）", "44934");
        giCameraRunSingle("006", true);
        giWait(4.0);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：……好像……什么都没有……", "44935");
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：说不定……他们都已经投胎去了……", "44936");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.5);
        giPlayerWalkTo(3, -82.4788, 125.6224, -415.2103, true);
        giPlayerSetDir(3, 156.0, true);
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……我看那边似乎另有出口，不如我们过去看看。", "44937");
        giWait(1.0);
        giSetPortrait("101G", false);
        giTalk("云天河：……好吧。", "44938");
        giWait(0.5);
        giCameraRunSingle("007", true);
        giWait(1.0);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：（……爹真的投胎去了？还是他气我把墓室弄坏了，所以不想见我？）", "44939");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giScriptMusicPlay("P66", 2, 2.5, 0.0);
        giSetNpcVisible("MN001", true);
        giTalk("？？：野小子？！是你？！", "44940");
        giSetPortrait("101D", false);
        giTalk("云天河：……！！", "44941");
        giWait(0.3);
        giPlayerSetDir(0, 172.0, false);
        giPlayerSetDir(1, 204.0, false);
        giPlayerSetDir(3, 174.0, false);
        giWait(0.5);
        giCameraRunSingle("008", true);
        giWait(0.8);
        giSetPortrait("101B", false);
        giTalk("云天河：爹！！真的是爹？！", "44942");
        giPlayerRunTo(0, -39.5208, 125.6224, -594.9426, false);
        giWait(0.8);
        giPlayerEndMove(0);
        giIMMBegin();
        giPlayerSetAng(0, 169.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giCameraRunSingle("010", false);
        giWait(0.8);
        giSetPortrait("101K", true);
        giTalk("云天河：孩儿、孩儿好想你！！", "44943");
        giWait(0.5);
        giSetPortrait("223C", false);
        giTalk("云天青：你这小子！怎么会在这里？难道你已经……已经——", "44944");
        giWait(0.5);
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：爹，孩儿还没死啦……只不过因为一些事，来了鬼界，还要回阳间的。", "44945");
        giWait(0.5);
        giSetPortrait("223B", false);
        giTalk("云天青：什么？你这小子，玩来玩去竟玩到鬼界来了！这里可不是你说来就来、说走就走的地方！", "44946");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：爹…………", "44947");
        giPlayerEndAction(0);
        giIMMBegin();
        giCameraRunSingle("011", false);
        giPlayerSetAng(0, 178.0);
        giIMMEnd();
        giCameraRunSingle("012", false);
        giSetPortrait("223A", false);
        giTalk("云天青：怎么？才几年不见，野小子都长这么大了，好像烦恼也多了起来，没以前那么天不怕地不怕的神情了～", "44948");
        giWait(0.5);
        giSetPortrait("101G", true);
        giTalk("云天河：爹……", "44949");
        giWait(1.0);
        giNpcDoAction("MN001", "J01", -1, false);
        giSetPortrait("223D", false);
        giTalk("云天青：你啊！到底是来干嘛的？！再不说老子走人了！", "44950");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giWait(0.5);
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：爹你别走！孩儿有好多事想问你！", "44951");
        giWait(0.5);
        giSetPortrait("101E", true);
        giTalk("云天河：你和娘……你们当初为什么要离开琼华派？害得大哥、不，玄霄，害他被冰封在禁地十九年？", "44952");
        giNpcDoAction("MN001", "J01", -1, false);
        giSetPortrait("223B", false);
        giTalk("云天青：……果然，我就知道你这小子出现，一定没好事，这么久以前的陈年旧事，都被扯出来了。", "44953");
        giSetPortrait("101E", true);
        giTalk("云天河：爹，你告诉孩儿吧！", "44954");
        giSetPortrait("223C", false);
        giTalk("云天青：你先告诉我，你怎么会知道这些事的？", "44955");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：……孩儿……那个…………", "44956");
        giWait(0.3);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：哎呀！还是我来说吧。", "44957");
        giWait(0.8);
        giIMMBegin();
        giPlayerSetPos(1, -8.5706, 125.6224, -518.2922);
        giPlayerSetPos(3, -75.2838, 125.6224, -513.3244);
        giPlayerSetPos(0, -41.1212, 125.6224, -562.7755);
        giPlayerSetAng(0, 164.0);
        giPlayerWalkTo(1, -12.1697, 125.6224, -551.9045, false);
        giPlayerWalkTo(3, -78.9526, 125.6224, -555.233, false);
        giCameraRunSingle("013", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerSetDir(1, 188.0, false);
        giPlayerSetDir(3, 148.0, true);
        giWait(0.5);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：都是我不好，我以为前辈是传说中的剑仙，墓室里一定有些长生秘宝，所以闯入前辈的墓中，天河追来阻止我，谁知那墓室却塌了，他很害怕前辈责怪他，又很想知道前辈以前的事，所以就下了山……", "44958");
        giWait(0.5);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：后来发生了许多事情，我们拜入昆仑琼华派，还结识了被关在禁地里的玄霄……", "44959");
        giWait(0.5);
        giSetPortrait("223D", false);
        giTalk("云天青：怎会如此？！你这小子，尽会找麻烦！墓室竟被你搞塌了……还有，我不想你修仙，你偏偏跑去琼华派！真是欠揍！", "44960");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, true);
        giSetPortrait("101E", true);
        giTalk("云天河：爹……你怎么打孩儿都行，但是能不能告诉孩儿，当初你和娘为什么要……", "44961");
        giWait(0.5);
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giWait(0.5);
        giCameraRunSingle("014", false);
        giSetPortrait("223C", false);
        giTalk("云天青：知道这件事，对你未必有好处，但如果你很想知道，爹还是会说，毕竟你也长大了，我不能永远把你当小孩子看。", "44962");
        giWait(0.5);
        giSetPortrait("101E", true);
        giTalk("云天河：……孩儿，想要知道！", "44963");
        giWait(0.5);
        giSetPortrait("223C", false);
        giTalk("云天青：……你可知我为什么一直没有去投胎？", "44964");
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, true);
        giSetPortrait("223C", false);
        giTalk("云天青：因为……我愧对师兄，所以我在阴间等着他。他不来，我不会走，我要亲口对他说声对不起。", "44965");
        giWait(0.5);
        giSetPortrait("101G", true);
        giTalk("云天河：…………", "44966");
        giWait(0.5);
        giSetPortrait("223A", false);
        giTalk("云天青：哈，你那什么痛苦表情？真以为我和你娘是十恶不赦的人了？", "44967");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：我……", "44968");
        giPlayerEndAction(0);
        giSetPortrait("223D", false);
        giTalk("云天青：我告诉你，我们二人，确实是负过师兄的性命……就算后来没有亲眼所见，我也知道他过得生不如死……但是，我和你娘，从未负过他的情谊。", "44969");
        giSetPortrait("101E", true);
        giTalk("云天河：孩儿不懂……", "44970");
        giSetPortrait("223A", false);
        giTalk("云天青：你既然知道师兄之事，是否也知道琼华派修炼双剑之事？", "44971");
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, true);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P34", 2, 2.5, 0.0);
        giCameraRunSingle("015", true);
        giCameraRunSingle("016", false);
        giSetPortrait("223D", false);
        giTalk("云天青：想要飞升成仙，就必须拥有强大的灵力，修炼百年，所得不过尔尔，倒不如网缚妖界，从他们那里夺取灵力……当时，门派中很多人都觉得这是个绝妙之法。", "44972");
        giSetPortrait("223D", false);
        giTalk("云天青：但是妖界又岂会乖乖就范？于是，双方争斗不休，场面十分惨烈……", "44973");
        giSetPortrait("223D", false);
        giTalk("云天青：我如今想来，仍觉心寒……我虽然并不讨厌妖，却也不会喜欢妖，但我忍受不了，自己升仙却要以其他生灵的命作为代价……", "44974");
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……", "44975");
        giWait(0.5);
        giCameraRunSingle("017", true);
        giCameraRunSingle("018", false);
        giSetPortrait("223D", true);
        giTalk("云天青：那段日子，简直像在炼狱一般，许多弟子见妖就杀，连幼儿也不放过……琼华派同样死伤不少，连掌门都被杀死，虽然那以后妖界之主不再露面，但再次出现之时，又有何人能够抵挡？", "44976");
        giSetPortrait("223D", true);
        giTalk("云天青：渐渐地，门派中有了不同意见，一派主张继续打下去，另一派则主张放妖界离去，减少己方伤亡。", "44977");
        giSetPortrait("223D", true);
        giTalk("云天青：我觉得，再打下去，也只是生灵涂炭，不管是人还是妖……眼看当初一同入门的师兄弟，一个接一个地死去，变成冷冰冰的尸骨，就像一场噩梦……", "44978");
        giWait(0.5);
        giSetPortrait("223D", true);
        giTalk("云天青：夙玉和我想的一样，她不愿再使用望舒剑，长老们虽说会考虑她的话，其实却只是拖延时间，想让她与玄霄继续网缚住妖界。", "44979");
        giSetPortrait("223C", true);
        giTalk("云天青：还有一人……本是与我们俩最亲密之人，却又与我们想的完全不同。", "44980");
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：那个人……就是……玄霄？", "44981");
        giWait(0.5);
        giNpcDoAction("MN001", "J01", -1, false);
        giSetPortrait("223C", true);
        giTalk("云天青：不错。师兄他非常清楚自己想要什么，绝不会半途而废。我和夙玉虽想劝他，反被他大骂妇人之仁……", "44982");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giSetPortrait("223C", true);
        giTalk("云天青：被自己私心爱慕的人痛骂，夙玉当时已是伤心欲绝。这个时候又有弟子说我是叛徒，因为他们看到我救了一只年幼的、身受重伤的妖。", "44983");
        giWait(0.5);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……！", "44984");
        giWait(0.5);
        giCameraRunSingle("020", true);
        giWait(0.8);
        giSetPortrait("223C", false);
        giTalk("云天青：我和夙玉已无法可想，妖界就算是强弩之末，也绝对会战个不死不休，唯一能阻止这场大战的，惟有我们带着望舒剑逃下山去，这样琼华派升仙的美梦也就化为了泡影。", "44985");
        giWait(0.5);
        giSetPortrait("223D", false);
        giTalk("云天青：我们趁夜逃出门派……后来的事你多少也知道一些，夙玉没有羲和之力的支撑，渐渐被冰寒侵体，我运功替她抵御寒气，却是杯水车薪……", "44986");
        giSetPortrait("223B", false);
        giTalk("云天青：我不死心，在黄山诸峰之间，寻找传说中的阴阳紫阙——", "44987");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：呀！阴阳紫阕！", "44988");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("223A", false);
        giTalk("云天青：原来姑娘你也知道那件宝物啊，难得！我少年时游历江湖，听说过许多奇珍异宝，阴阳紫阙就是其中之一。", "44989");
        giWait(0.5);
        giSetPortrait("223C", false);
        giTalk("云天青：当时也是再没有其他办法了，我想到用阴阳紫阙“阳”的那一半，抑制夙玉身上的寒气……", "44990");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：爹，那后来呢？你找到了吗？", "44991");
        giWait(0.5);
        giSetPortrait("223C", false);
        giTalk("云天青：……差不多把整个黄山都找遍了，我终于寻得“阳”的那一半，给夙玉服下，她的身体果然好转，我们以为这样就没事了……没多久就成了亲，定居在黄山青鸾峰上……", "44992");
        giNpcDoAction("MN001", "C09", 1, false);
        giWait(0.5);
        giSetPortrait("223C", false);
        giTalk("云天青：可是……后来还是不行，夙玉的身体时好时坏，生下你之后，不久便过世了，但奇怪的是，我们一直担心你会先天体寒，你却十分健康……", "44993");
        giWait(0.5);
        giSetPortrait("223C", false);
        giTalk("云天青：我因为曾替夙玉运功驱寒，也被冰寒之气反噬，过不了几年便这样归位了，唉～", "44994");
        giWait(0.5);
        giNpcDoAction("MN001", "J01", -1, false);
        giSetPortrait("223A", false);
        giTalk("云天青：这就是全部的事了。有些事说严重也很严重，说不严重也很不严重，就看你怎么想了。", "44995");
        giWait(0.5);
        giSetPortrait("101A", true);
        giTalk("云天河：嗯……", "44996");
        giWait(1.0);
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giWait(0.8);
        giCameraRunSingle("021", false);
        giSetPortrait("223A", false);
        giTalk("云天青：天河，你如今身体可有不适？会不会怕冷？", "44997");
        giPlayerDoAction(0, "C09", 1, false);
        giWait(1.0);
        giSetPortrait("101A", true);
        giTalk("云天河：孩儿一切都好，并不会像爹和娘那样……", "44998");
        giWait(0.5);
        giSetPortrait("223A", false);
        giTalk("云天青：这就太好了，就算你小时候看来没什么，我也还是放心不下。", "44999");
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：前辈，您说、您说天河的娘爱慕着玄霄，那她……", "45000");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("022", true);
        giCameraRunSingle("023", false);
        giSetPortrait("223A", true);
        giTalk("云天青：……我知道你想问什么……不过，夙玉她深心里究竟爱着谁、亦或怨着谁，怕是只有她自己才知晓……", "45001");
        giWait(0.5);
        giSetPortrait("223C", true);
        giTalk("云天青：至少，在她刚入师门时，眼里根本没有我，只有玄霄师兄……", "45002");
        giSetPortrait("223B", true);
        giTalk("云天青：那一天在剑舞坪，当我和师兄第一次见到夙玉……她那时的模样，我永远都忘不了，她就好像后山的凤凰花一样美，虽然神色冷冷淡淡，眼里却透着明澈聪慧……", "45003");
        giSetPortrait("223C", true);
        giTalk("云天青：虽然我和夙玉都是不信天命之人，但是如今回想起来，或许从那一刻起，我们三人之间的某些东西，已是不可更改了……", "45004");
        giWait(0.5);
        giSetPortrait("101A", false);
        giTalk("云天河：爹……", "45005");
        giWait(0.5);
        giSetPortrait("223C", true);
        giTalk("云天青：夙玉的性情外柔内刚，兼之以望舒剑修炼，身染阴寒，性情中更是有着相当绝决的一面。当初师兄与她决裂，令她十分伤心，日后嫁我，至死都不再提“玄霄”二字。", "45006");
        giWait(0.5);
        giSetPortrait("223C", true);
        giTalk("云天青：可我知道，夙玉一直没有忘记那个人……她临死前的几天，被冰寒侵体，心魔深种，已经六亲不认，却忽尔清醒了一瞬，只求我一件事，便是把灵光藻玉放在她身边作为陪葬。", "45007");
        giSetPortrait("223C", true);
        giTalk("云天青：我知道，灵光藻玉这世上只有两块，是打开琼华派禁地大门的秘钥，她与师兄于禁地修炼双剑时各持一块，对她来说，有着不凡的意义……", "45008");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 170.0);
        giPlayerSetAng(1, 194.0);
        giPlayerSetAng(3, 154.0);
        giCameraRunSingle("024", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：……那，孩儿把那块玉带出墓室，不是会让娘很伤心？", "45009");
        giNpcDoAction("MN001", "C09", 1, false);
        giWait(0.5);
        giSetPortrait("223A", true);
        giTalk("云天青：无妨，夙玉她已转世去了，再也不会为任何人伤心。", "45010");
        giWait(0.5);
        giSetPortrait("101A", false);
        giTalk("云天河：……为什么？娘不像你一样，等着玄霄呢？", "45011");
        giWait(0.5);
        giSetPortrait("223C", true);
        giTalk("云天青：……夙玉曾告诉我，她这一世活得太累，耗了太多心力，若是死了，一定会很快投胎，让一切重新开始，把这一世的喜怒哀乐通通忘记。她是个说到做到的人，早就已经入了轮回吧……", "45012");
        giWait(0.8);
        giSetPortrait("101G", false);
        giTalk("云天河：……", "45013");
        giWait(0.5);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：云前辈……你刚才所说，曾经救下一个年幼的妖，指的可是柳梦璃？", "45014");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giNpcSetDir("MN001", 328.0, true);
        giWait(0.5);
        giSetPortrait("223B", true);
        giTalk("云天青：不错，你们……竟也认识璃儿？", "45015");
        giWait(0.5);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：她是妖！？但是为何她……", "45016");
        giWait(0.5);
        giNpcDoAction("MN001", "J01", -1, false);
        giSetPortrait("223A", true);
        giTalk("云天青：哈，你这小子，真是无聊得很，一看就知道是琼华派教出来的！什么人啊妖啊，有必要分那么清楚吗？", "45017");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：前辈……", "45018");
        giSetPortrait("223A", true);
        giTalk("云天青：你看看这鬼界，一旦阳寿尽了，都是鬼魂，不分人与妖，说不定你今世是人，来世便要做妖，那你一直坚持的东西岂不可笑？！", "45019");
        giIMMBegin();
        giPlayerSetPos(3, -94.8001, 125.6224, -533.4618);
        giCameraRunSingle("032", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……！今世是人，来世做妖……", "45020");
        giWait(2.0);
        giIMMBegin();
        giPlayerSetPos(3, -78.9526, 125.6224, -555.233);
        giCameraRunSingle("026", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("223A", false);
        giTalk("云天青：小子，你自己慢慢想去吧，最好想得通透点！", "45021");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：…………", "45022");
        giWait(0.5);
        giPlayerSetDir(1, 266.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：（今世是人，来世做妖……）", "45023");
        giSetPortrait("103C", false);
        giTalk("韩菱纱：（紫英……他的心里一定很不好受吧？多年以来在琼华派所知道的观念，居然……居然有一天变的什么都不是了……）", "45024");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.6);
        giIMMBegin();
        giPlayerSetAng(0, 158.0);
        giPlayerSetAng(1, 186.0);
        giPlayerSetAng(3, 142.0);
        giNpcSetAng("MN001", 342.0);
        giCameraRunSingle("027", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("223A", false);
        giTalk("云天青：天河，告诉爹，你又是如何认识璃儿的？", "45025");
        giWait(0.5);
        giSetPortrait("101E", true);
        giTalk("云天河：孩儿是在寿阳认识她的，后来我们一起去了琼华派，可是……妖界来时，她却跳进了那个入口，失踪了……", "45026");
        giWait(0.5);
        giNpcDoAction("MN001", "J01", -1, false);
        giSetPortrait("223A", false);
        giTalk("云天青：……妖比人早慧，或许她已经找回记忆了……", "45027");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giSetPortrait("223B", false);
        giTalk("云天青：不对！！没有双剑网缚，璃儿怎有机会回妖界？！就算望舒剑重回琼华派，剑未苏醒，他们根本用不了啊！", "45028");
        giSetPortrait("101H", true);
        giTalk("云天河：爹？", "45029");
        giWait(0.5);
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("223B", false);
        giTalk("云天青：不可能、这不可能，除非有个人，与夙玉一般……", "45030");
        giWait(0.6);
        giNpcSetDir("MN001", 10.0, true);
        giWait(0.5);
        giSetPortrait("223B", false);
        giTalk("云天青：姑娘，你——！！", "45031");
        giWait(0.6);
        gi2DSoundPlay("WJ056", 1);
        giWait(0.8);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P67", 2, 0.0, 0.0);
        giNpcBlendOut("MN001", 2.3, false);
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：爹！——", "45032");
        giWait(2.7);
        giSetObjectVisible("Jeffect001", true);
        giSetNpcVisible("MN003", true);
        giWait(0.5);
        giTalk("雅：快走！快走！ ", "45033");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetDir(0, 350.0, false);
        giPlayerSetDir(1, 326.0, false);
        giPlayerSetDir(3, 22.0, false);
        giIMMEnd();
        giWait(0.7);
        giSetPortrait("101H", false);
        giTalk("云天河：什么？！", "45034");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(0, -41.3252, 125.6224, -575.0896);
        giCameraRunSingle("028", true);
        giSetNpcVisible("MN003", false);
        giSetNpcVisible("MN002", true);
        giIMMEnd();
        giWait(0.5);
        giTalk("风：无常殿已经把转轮镜台的灵力暂时消去了，他们发现你们了！", "45035");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：那我爹——", "45036");
        giWait(0.5);
        giIMMBegin();
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("MN004", true);
        giIMMEnd();
        giWait(0.5);
        giTalk("颂：走吧，他不会再出现了……", "45037");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：爹……他不会有事吧？", "45038");
        giWait(0.5);
        giCameraRunSingle("029", true);
        giWait(0.5);
        giIMMBegin();
        giSetNpcVisible("MN004", false);
        giSetNpcVisible("MN003", true);
        giIMMEnd();
        giWait(0.5);
        giTalk("雅：有事的是你们！", "45039");
        giWait(0.5);
        giIMMBegin();
        giSetNpcVisible("MN003", false);
        giSetNpcVisible("MN002", true);
        giIMMEnd();
        giWait(0.5);
        giTalk("风：对啊，我们可是一番好心，才来示警的，要是被发现，这个月的俸禄又没了。", "45040");
        giWait(1.0);
        giTalk("？？：风雅颂，你们这三只笨鸟，还不快离开！被发现我可不救你们！", "45041");
        giWait(0.5);
        giCameraRunSingle("028", true);
        giWait(0.3);
        giIMMBegin();
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("MN004", true);
        giIMMEnd();
        giWait(0.5);
        giTalk("颂：闪了、闪了……", "45042");
        giSetObjectVisible("Jeffect001", true);
        giSetNpcVisible("MN004", false);
        giIMMBegin();
        giSetNpcVisible("MN005", true);
        giNpcSetPos("MN005", -42.2624, 125.6224, -428.5779);
        giNpcSetAng("MN005", 180.0);
        giIMMEnd();
        giWait(2.0);
        giCameraRunSingle("030", false);
        giWait(1.0);
        giNpcWalkTo("MN005", -39.6185, 125.6224, -487.3934, true);
        giWait(1.0);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：你是……？", "45043");
        giWait(0.5);
        giNpcDoAction("MN005", "J01", 1, false);
        giSetPortrait("227A", false);
        giTalk("？？：我叫壬癸，是个鬼差。", "45044");
        giNpcEndAction("MN005", true);
        giWait(0.5);
        giNpcDoAction("MN005", "J01", 1, false);
        giSetPortrait("227A", false);
        giTalk("壬癸：你们快走吧，马上就会有大批的鬼卒追过来了，转轮镜台是不许私会鬼魂的。", "45045");
        giNpcEndAction("MN005", true);
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：但是……", "45046");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giNpcDoAction("MN005", "J01", 1, false);
        giSetPortrait("227A", false);
        giTalk("壬癸：别但是了！抓紧时间，<colour red=255 green=187 blue=0 alpha=255>往南面的出口走，就可以去放逐渊了</colour><dc0>，那里是孤魂野鬼聚集之地，鬼卒也不容易搜寻，你们快来！我在那里等你们！</dc0>", "45047");
        giNpcEndAction("MN005", true);
        giWait(0.2);
        giNpcWalkTo("MN005", -42.2624, 125.6224, -428.5779, true);
        giSetNpcVisible("MN005", false);
        giWait(0.7);
        giIMMBegin();
        giPlayerSetPos(0, -55.2387, 125.6224, -584.3898);
        giPlayerSetAng(0, 6.0);
        giPlayerSetAng(3, 36.0);
        giPlayerSetAng(1, 250.0);
        giCameraRunSingle("031", false);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：现在怎么办……？", "45048");
        giWait(0.5);
        giPlayerSetDir(0, 64.0, false);
        giWait(0.1);
        giPlayerSetDir(3, 88.0, true);
        giWait(0.6);
        giSetPortrait("101E", false);
        giTalk("云天河：那个人……不是让我们去南边找他吗？", "45049");
        giWait(0.5);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：可是……我都没有见到大伯……", "45050");
        giWait(0.3);
        giPlayerDoAction(3, "C09", 1, false);
        giWait(0.3);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：不能再等了，我们已经惊动鬼界，再不走就来不及了！", "45051");
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：……走吧……爹好像还有很重要的话想说，最后也没有说，就不见了……", "45052");
        giWait(1.0);
        giPlayerSetDir(1, 175.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：大伯……", "45053");
        giWait(1.0);
        giFlashOutBlack(1.5, true, true);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giSetObjectVisible("entrance1", true);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(-45.0482, -2.17, 126.7789);
        giPlayerCurrentSetAng(4.0);
        giEventVolumeVisible("ev_Q11_Q11Z_4", true);
        giSetObjectVisible("entrance2", true);
        giSetObjectVisible("entrance1", false);
        giAddPlayerFavor(0, 3, -30);
        giAddPlayerFavor(0, 1, -20);
        giIMMEnd();
        global_mvar = 130700; // 0x0001FE8C, 第三章 / 8-2-3.是昔流芳 / 逃往放逐渊 / 重逢天青
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giSetObjectVisible("Jeffect001", false);
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
    }
}

void func4001()
{
    giPlayerLock();
    giNpcPauseBeh("4001");
    giNpcFaceToCurrentPlayer("4001", true);
    giCurrentPlayerFaceToNpc("4001", true);
    giRandTalkRelease();
    giRandTalkPush("甲丑：你们是新鬼？既然无人拘束，应该已经是要跳轮回井了，怎么还跑来无常殿！快滚！小心秦广王发怒，问你们的罪！");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4001");
    giNpcResumeBeh("4001");
    giPlayerUnLock();
}

void func4002()
{
    giPlayerLock();
    giNpcPauseBeh("4002");
    giNpcFaceToCurrentPlayer("4002", true);
    giCurrentPlayerFaceToNpc("4002", true);
    giRandTalkRelease();
    giRandTalkPush("书勤：咦？！迷路的新鬼吗？快逃！快逃！！要是被无常殿的秦广王发现，那就完了……");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4002");
    giNpcResumeBeh("4002");
    giPlayerUnLock();
}

void func4003()
{
    giPlayerLock();
    giNpcPauseBeh("4003");
    giNpcFaceToCurrentPlayer("4003", true);
    giCurrentPlayerFaceToNpc("4003", true);
    giRandTalkRelease();
    giRandTalkPush("夏小永：……我在这里待了好久……可还是不敢靠近无常殿后面的转轮镜台……怎么办……我只是想见一见亲人的魂魄，轮回井离这里太远，听说在转轮镜台上诚心诚意地祈求，亲人也是会出现的……");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4003");
    giNpcResumeBeh("4003");
    giPlayerUnLock();
}

void func4004()
{
    giPlayerLock();
    giNpcPauseBeh("4004");
    giNpcFaceToCurrentPlayer("4004", true);
    giCurrentPlayerFaceToNpc("4004", true);
    giRandTalkRelease();
    giRandTalkPush("蔡婆：整年整年在这打扫，年俸就只有十文纸钱……要是有个亲戚在阳间，什么都不用做，一年得几千两也不算多……唉，老婆子做人时命苦，做了鬼一样命苦……");
    giRandTalkPush("蔡婆：我在阴间待了几百年啦，常常听说有在轮回井口不肯跳的鬼，有的为了等阳世人下来相见，有的不肯忘记上辈子的事，其实何苦啊？死都死了，投胎就投胎吧……");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4004");
    giNpcResumeBeh("4004");
    giPlayerUnLock();
}

void func4005()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4005");
    giNpcFaceToCurrentPlayer("4005", true);
    giCurrentPlayerFaceToNpc("4005", true);
    random_1_4 = giGetRandnum(1, 4);
    if (random_1_4 != 2)
    {
        giTalk("戊未：这人呢，该死的时候不肯死，只能由无常殿的鬼卒去招魂，到了该转生的时候呢，又不想活，没事就在阴间飘来飘去，一个比一个想不开！", "");
    }
    else
    {
        giTalk("戊未：最近轮回井那儿要投胎的～壁山河边从左往右第三棵树下第六棵止血草、死在黄河边的公牛一只、太平村宋氏母鸡小花，陈州秦府姜氏……", "");
        giTalk("戊未：哈哈，这就是转生名册了！趁大人不在，我偷偷看一下，你这种小鬼可不能多嘴啊！", "");
    }
    giNpcResetDir("4005");
    giNpcResumeBeh("4005");
    giPlayerUnLock();
}

void func4006()
{
    giPlayerLock();
    giNpcPauseBeh("4006");
    giNpcFaceToCurrentPlayer("4006", true);
    giCurrentPlayerFaceToNpc("4006", true);
    giRandTalkRelease();
    giRandTalkPush("丁寅：六界之中，仙和妖也就是比人活久一点，死了一样是鬼嘛，可他们总住在奇奇怪怪的地方，要是没有翳影枝，还真勾不到他们的魂！");
    giRandTalkPush("丁寅：鬼卒勾了人的魂魄，先带回这无常殿听候发落，再决定送那些鬼去哪儿，像你这样迷了路的，最好快快离开，不然一不小心进了哪层地狱，可就冤了。");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4006");
    giNpcResumeBeh("4006");
    giPlayerUnLock();
}

void func4007()
{
    giPlayerLock();
    giNpcPauseBeh("4007");
    giNpcFaceToCurrentPlayer("4007", true);
    giCurrentPlayerFaceToNpc("4007", true);
    giRandTalkRelease();
    giRandTalkPush("张鸳渊：人界有人界的生意，鬼界有鬼界的生意，只要有钱，都能做买卖，没听过“有钱能使鬼推磨”吗～");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4007");
    giNpcResumeBeh("4007");
    giPlayerUnLock();
}

void func4008()
{
    if (var_shop004 != 0)
    {
        giTalk("刘宝庆：当年我一心只想炼长生不老药，竟然鬼迷心窍，强逼怀着身孕的妻子投身丹炉……结果药未成，却罪孽累累，如今真是后悔莫及啊！", "");
    }
    else
    {
        giPlayerLock();
        giFlashOutBlack(1.0, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetPos(0, 20.314, -3.8045, -1415.6979);
        giPlayerSetAng(0, 170.0);
        giSetNpcVisible("4016", true);
        giCameraPrepare("NPC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, true);
        giTalk("小怜：相公……相公……", "");
        giNpcWalkTo("4016", 69.3073, -4.9396, -1631.5299, false);
        giCameraRunSingle("002", true);
        giNpcEndMove("4016");
        giNpcFaceToNpc("4008", "4016", true);
        giTalk("刘宝庆：你……你是小怜！！小怜你快救救我！他们要把我送进地狱，让我永世不得超生，你救救我！", "");
        giCameraRunSingle("003", false);
        giCurrentPlayerFaceToNpc("4016", false);
        giTalk("小怜：难为相公还记得小怜，我还以为你心里只有长生不老，早就忘记小怜了……你当年为炼丹药，逼着身怀六甲的我跳入丹炉之时，可曾想过会有今日？", "");
        giTalk("刘宝庆：我知道，都是我的错，都是我的错！小怜！你就念在我们夫妻一场的份上，快想办法救我吧！", "");
        giTalk("小怜：这些都是因果业报……小怜此来，只是为了看你的报应，相公你好自为之吧。", "");
        giWait(0.5);
        giNpcWalkTo("4016", 15.8175, -4.9396, -1661.4138, true);
        giTalk("刘宝庆：小怜！！救救我啊！！！", "");
        giWait(0.5);
        giFlashOutBlack(2.0, true, true);
        giCameraRunSingle("001", true);
        giSetNpcVisible("4016", false);
        var_shop004 = 1;
        giFlushTailYAngle();
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giFlashInBlack(1.0, true);
        giPlayerUnLock();
    }
}

void func4009()
{
    giPlayerLock();
    giNpcPauseBeh("4009");
    giNpcFaceToCurrentPlayer("4009", true);
    giCurrentPlayerFaceToNpc("4009", true);
    giRandTalkRelease();
    giRandTalkPush("庚卯：不久前才从陈州带回来的那个女鬼，在阴间找不到她相公，就急着投胎去了……呵呵，我看过她的生死簿，她和她相公缘分已尽，以后再也遇不着啦。");
    giRandTalkPush("庚卯：再过去便是转轮镜台了，那地方很神秘，就算是鬼卒也不允许靠近，其实，我一直很想溜过去看看呢。");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4009");
    giNpcResumeBeh("4009");
    giPlayerUnLock();
}

void func4010()
{
    giPlayerLock();
    giNpcPauseBeh("4010");
    giNpcFaceToCurrentPlayer("4010", true);
    giCurrentPlayerFaceToNpc("4010", true);
    giRandTalkRelease();
    giRandTalkPush("辛酉：你是新来的？不用害怕，我看你一脸正气，无甚罪孽，这无常殿便是十殿中的第一殿，若是生前善恶相抵之人，过了无常殿便可往第十殿转轮王处听凭投胎的安排。");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4010");
    giNpcResumeBeh("4010");
    giPlayerUnLock();
}

void func4011()
{
    giPlayerLock();
    giNpcPauseBeh("4011");
    giNpcFaceToCurrentPlayer("4011", true);
    giCurrentPlayerFaceToNpc("4011", true);
    giRandTalkRelease();
    giRandTalkPush("幽骑：你们是新鬼？以前怎么没见过？难道是无常殿的大人召你们去？");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4011");
    giNpcResumeBeh("4011");
    giPlayerUnLock();
}

void func4012()
{
    giPlayerLock();
    giNpcPauseBeh("4012");
    giNpcFaceToCurrentPlayer("4012", true);
    giCurrentPlayerFaceToNpc("4012", true);
    giRandTalkRelease();
    giRandTalkPush("白额：那翳影枝可是个好东西，有了它，天底下什么被法力封住的地方都能进去，可惜不能采几枝来卖，可惜啊可惜……");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4012");
    giNpcResumeBeh("4012");
    giPlayerUnLock();
}

void func4013()
{
    giPlayerLock();
    giNpcPauseBeh("4013");
    giNpcFaceToCurrentPlayer("4013", true);
    giCurrentPlayerFaceToNpc("4013", true);
    giRandTalkRelease();
    giRandTalkPush("福昌贵：小兄弟，告诉你！我生前乃是江南首富，家财万贯，大江以南的青楼赌坊，全都是我开的！如果你能放我出去，我就把所有的钱都给你！");
    giRandTalkPush("福昌贵：放我出去！放我出去！我不要下地狱！！你们这群牛头马面，我用银子都能把你们砸死！");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4013");
    giNpcResumeBeh("4013");
    giPlayerUnLock();
}

void func5001()
{
    giPlayerLock();
    giNpcPauseBeh("5001");
    giNpcFaceToCurrentPlayer("5001", true);
    giCurrentPlayerFaceToNpc("5001", true);
    if (maze_var7 != 0)
    {
        if (maze_var7 != 1)
        {
            giStartTradeSystem("shop007", "");
        }
        else
        {
            if (giCheckPackProperty(3258, 1))
            {
                giTalk("王济新：咳咳，对，咳咳，就是这个叶子，咳咳，让我用来试试！", "");
                giDelProperty(3258, 1, true);
                giWait(2.0);
                giTalk("王济新：呼……噎了几百年了，现在终于舒服了！小子你的本事还不错，这几样东西就拿去玩着吧！", "");
                giAddEquipment(3686, true);
                giWait(2.0);
                giAddPrescription(8160, true);
                giWait(2.0);
                giAddPrescription(8158, true);
                giWait(2.0);
                maze_var7 = 2;
            }
            giStartTradeSystem("shop007", "");
        }
    }
    else
    {
        giStartTradeSystem("shop007", "Buiness_Q11_5001");
    }
    giNpcResetDir("5001");
    giNpcResumeBeh("5001");
    giPlayerUnLock();
}

void func5002()
{
    giPlayerLock();
    giNpcPauseBeh("5002");
    giNpcFaceToCurrentPlayer("5002", true);
    giCurrentPlayerFaceToNpc("5002", true);
    giStartTradeSystem("shop017", "");
    giNpcResetDir("5002");
    giNpcResumeBeh("5002");
    giPlayerUnLock();
}

void func5003()
{
    giPlayerLock();
    giNpcPauseBeh("5003");
    giNpcFaceToCurrentPlayer("5003", true);
    giCurrentPlayerFaceToNpc("5003", true);
    giStartTradeSystem("shop028", "");
    giNpcResetDir("5003");
    giNpcResumeBeh("5003");
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

void Buiness_Q11_5001()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("咳咳咳咳，我生前炼丹～咳咳，不慎在吃丹药、咳咳、时噎死，死后、咳咳，说话也不利索，难受得紧～我听说，咳咳，有一种沾染圣水的叶子，咳咳咳咳，叫<colour red=255 green=187 blue=0 alpha=255>“濡润叶”</colour><dc0>的，说不定，咳咳咳咳，可以帮到我……</dc0><br/><dc0>你愿意帮我去找来吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        maze_var7 = 1;
    }
}
