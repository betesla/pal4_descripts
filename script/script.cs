// Structured PAL4 reconstruction for script.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void NewGame()
{
    giFlashOutBlack(0.1, true, true);
    giScriptMusicPause();
    giPlayMovie("1A.bik");
    giPlayMovie("Pal4A.bik");
    giOpenMovieFlag(0);
    global_mvar = 10100; // 0x00002774
    giNewGame();
    giScriptMusicResume();
    giArenaLoad("Q01", "N01", "", true);
}
