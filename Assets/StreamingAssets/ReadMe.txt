NON-CODING
-- Explain in your own words, the different between Update, FixedUpdate, and LateUpdate, and when we should use each
	A:Update is the most frequent ,while FixedUpdate is called every 60 frames.LateUpdate is only called after every Update in any Scripts are done.

-- Explain in your own words, what the StreamingAssets folder is used for
	A:Objects in Streaming Folders doesn't get packed .They are not using and not imported .We use them for putting in things like readme,or videos that shouldn't exist in the game.
-- Explain in your own words, one more "special folder," and its use
	A:Editor folder:if scripts that using unity editor namespace exist when build,build will fail. Put it in an Editor Folder so that it automatically operate.
-- Explain in your own words, the Script Execution Order
	A;Same Script , first Awake,then onEnable,then Start...There is no specific order between Scripts
