This program serves one primary purpose: to help identify bad ROMs on arcade motherboards.

Let's say you have a Donkey Kong game with corrupt video.  The first step is to try to identify the suspected bad ROM on the board.  Let's say that for our purposes, it's 5H.  Well, my D3 pin looks rough and might be broken.

So we would read in a known good dump of 5H in the "Open ROM" box.  Then we would choose a new name for that ROM to Save As.  By using the checkboxes in this app, we can specify which bits to hold "HI".  If we substitute the good ROM with the bad ROM image we just generated, we should be able to recreate what the board is doing.

Future plans include changing the checkboxes in the application to support tri-state, that is: stuck LO, normal, and stuck HI.
