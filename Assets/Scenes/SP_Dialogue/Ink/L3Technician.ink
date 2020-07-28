-> Scene1
=== Scene1 === 
DUMMY TEXT SCENE 1.
+ [Then, continue.] -> intro


-> intro
=== intro ===
Boy: Are you the technician?
Technician: Yes sir. Can I help you?
+ [What do you know about the necklace incident?] -> agg
+ [The maid told me to talk to you about what really happened with the necklace incident.] -> love_maid


=== love_maid ===
Technician: You know, I really love her. The maid I mean.
+ [...] -> Scene2


=== Scene2 ===
DUMMY TEXT SCENE 2.
+ [Then, continue.] -> love_maid2


=== love_maid2 ===
Technician: ...
+ [...] -> soft
+ [Well, why were you accused of stealing the necklace then?] -> why


=== agg ===
Technician: I don't know who told you what. But I won't have a little kid interrogating me.
+ [The maid told me to talk to you.] -> love_maid
=== soft ===
Technician: *sigh* I hate talking about it. But ok. What do you want to know?
+ [I heard you were accused of stealing the necklace along with her.] -> why


=== why ===
Technician: I kinda had to be. I mean if you think about it the maid couldn't have been accused by herself. The maid wouldn't have had enough technical expertise to work with the hotel safes. That's where the VIP had put her necklace before it was stolen.
+ [What about the manager? Wouldn't they know about the safes too?] -> why2
+ [So that's why you were accused along with her.] -> why2


=== why2 ===
Technician: Yeah...I guess. The only other person who would have had experience with the hotel safes is probably the manager.
+ [Did that make you suspicious of the manager then?] -> agg2
+ [The manager was my mother.] -> soft2


=== agg2 ===
Technician: Kinda. But I had more suspicions about some other person.
+ [Who?] -> incident


=== soft2 ===
Technician: Oh, I am sorry. I heard...what happened. But there was something else that happened that day too...
+ [What?] -> incident


=== incident ===
Technician: Well there was one incident that had me questioning things. But it probably wasn't a big deal.
+ [Spit it out.] -> agg3
+ [It's ok. You can tell me.] -> incident2


=== agg3 ===
Technician: What is with you? Why do you want to know these things so bad?
+ [The manager was my mother.] -> agg3_cont


=== agg3_cont ===
Technician: Oh, right. I guess I should just tell you...
+ [...] -> incident2


=== incident2 ===
Technician: That day I had gone to the pool area to fix some lights. And I saw the lifeguard looking around suspiciously. Almost as if he wanted to make sure no one could see him there.
+ [...] -> Scene3


=== Scene3 ===
DUMMY TEXT SCENE 3.
+ [Then, continue.] -> incident3


=== incident3 ===
Technician: It was probably a coincidence. But on the same day that the necklace got stolen? I was meaning to look into it more and talk to him, but by the time I had already gotten accused of stealing the necklace along with the maid.
+ [...] -> ending


=== ending
Technician: I probably shouldn't be so suspicious of him...but you would have to talk to the lifeguard himself to find out what actually happened.
-> END