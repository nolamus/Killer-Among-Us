-> Scene1
=== Scene1 === 
DUMMY TEXT SCENE 1.
+ [Then, continue.] -> intro


=== intro ===
Boy: Are you the maid?
Maid: Yes! Do you need something?
+ [What do you know about the necklace incident? Did you steal the necklace?] -> agg
+ [The bellhop told me to talk to you about the necklace incident.] -> soft


=== agg ===
Maid: Look, I don't know who told you what. But I never stole that necklace. But I guess I should explain what happened.
+ [...] -> story
=== soft ===
Maid: I hate talking about it. But ok. What do you want to know?
+ [So...did you steal the necklace?] -> begin_story
+ [I heard you were accused of stealing the necklace.] -> begin_story


=== begin_story ===
Maid: I guess I should explain what really happened.
+ [...] -> story


=== story ===
Maid: Yes, I may have been the one that was said to have stolen the necklace. But your mom was the one that really did it. She just blamed it on me.
+ [...] -> Scene2


=== Scene2 ===
DUMMY TEXT SCENE 2.
+ [Then, continue.] -> story1


=== story1 ===
Maid: I did go into the VIP room that day. But it was only to clean the room. Your mom took that as an opportunity to blame it on me.
+ [...] -> story2


=== story2 ===
Maid: And I wasn't the only one who was caught up in this mess. The technician was blamed along with me as a co conspirator.
+ [...] -> Scene3


=== Scene3 ===
DUMMY TEXT SCENE 3.
+ [Then, continue.] -> ending


=== ending
Maid: Maybe you should go and talk to the technician yourself. After all, he was blamed for stealing the necklace along with me.
-> END
