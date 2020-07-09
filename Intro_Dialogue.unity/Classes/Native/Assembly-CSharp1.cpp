#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>
#include <stdint.h>

#include "codegen/il2cpp-codegen.h"
#include "il2cpp-object-internals.h"


// System.Char[]
struct CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2;
// System.String
struct String_t;
// System.Void
struct Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017;
// UnityEngine.GameObject
struct GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429;
// je_MainMenu
struct je_MainMenu_t7E7AAC27A88A263CB4A8CB94F4C74217947756B5;
// je_PauseMenu
struct je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B;

IL2CPP_EXTERN_C RuntimeClass* je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral522950E3314ACDF6B6C5E60CED64003A2BBD22BC;
IL2CPP_EXTERN_C String_t* _stringLiteral90082D1552FEE7C48979F7BE2CDC6FCF9874AD38;
IL2CPP_EXTERN_C String_t* _stringLiteralC4003C1DAA0E5A07EAB3D1A0A983D70DAA7DF4BA;
IL2CPP_EXTERN_C String_t* _stringLiteralFBBE26930DFC50992D7EC4AED8D40081F9F283EA;
IL2CPP_EXTERN_C const uint32_t je_MainMenu_DiplayMainMenu_m6E6B07C1B6AD68684A5D99B6FCF8B1562C676DD8_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t je_MainMenu_DisplayLevelSelect_mA3BFEDA938D564ED1C8E20AEDDB5BADDC4B1126B_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t je_MainMenu_DisplaySettings_mD11BA28E6F0F29EA29A1042314875643EA0707A0_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t je_MainMenu_StartGame_mE90199586E1F534ABC4DB757803E27B6CF66EC22_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t je_PauseMenu_MainMenu_m01FA222AF325787508628DC56832C1C159308D0C_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t je_PauseMenu_PauseGame_mF868A258A5DBEA87097C176F988B0C67F72FD99D_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t je_PauseMenu_ResumeGame_mF5CD313928B9CEE46AB2DDB9C442EDA2AA8B3392_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t je_PauseMenu_Settings_m616BC89226440408E9C412D344EDA6296C1457EC_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t je_PauseMenu_Update_m63FB8AC07994D253EB7383D8B473B06FC3C5992E_MetadataUsageId;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object

struct Il2CppArrayBounds;

// System.Array


// System.String
struct  String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::m_stringLength
	int32_t ___m_stringLength_0;
	// System.Char System.String::m_firstChar
	Il2CppChar ___m_firstChar_1;

public:
	inline static int32_t get_offset_of_m_stringLength_0() { return static_cast<int32_t>(offsetof(String_t, ___m_stringLength_0)); }
	inline int32_t get_m_stringLength_0() const { return ___m_stringLength_0; }
	inline int32_t* get_address_of_m_stringLength_0() { return &___m_stringLength_0; }
	inline void set_m_stringLength_0(int32_t value)
	{
		___m_stringLength_0 = value;
	}

	inline static int32_t get_offset_of_m_firstChar_1() { return static_cast<int32_t>(offsetof(String_t, ___m_firstChar_1)); }
	inline Il2CppChar get_m_firstChar_1() const { return ___m_firstChar_1; }
	inline Il2CppChar* get_address_of_m_firstChar_1() { return &___m_firstChar_1; }
	inline void set_m_firstChar_1(Il2CppChar value)
	{
		___m_firstChar_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_5;

public:
	inline static int32_t get_offset_of_Empty_5() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_5)); }
	inline String_t* get_Empty_5() const { return ___Empty_5; }
	inline String_t** get_address_of_Empty_5() { return &___Empty_5; }
	inline void set_Empty_5(String_t* value)
	{
		___Empty_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Empty_5), (void*)value);
	}
};


// System.ValueType
struct  ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_com
{
};

// System.Boolean
struct  Boolean_tB53F6830F670160873277339AA58F15CAED4399C 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Boolean_tB53F6830F670160873277339AA58F15CAED4399C, ___m_value_0)); }
	inline bool get_m_value_0() const { return ___m_value_0; }
	inline bool* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(bool value)
	{
		___m_value_0 = value;
	}
};

struct Boolean_tB53F6830F670160873277339AA58F15CAED4399C_StaticFields
{
public:
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;

public:
	inline static int32_t get_offset_of_TrueString_5() { return static_cast<int32_t>(offsetof(Boolean_tB53F6830F670160873277339AA58F15CAED4399C_StaticFields, ___TrueString_5)); }
	inline String_t* get_TrueString_5() const { return ___TrueString_5; }
	inline String_t** get_address_of_TrueString_5() { return &___TrueString_5; }
	inline void set_TrueString_5(String_t* value)
	{
		___TrueString_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TrueString_5), (void*)value);
	}

	inline static int32_t get_offset_of_FalseString_6() { return static_cast<int32_t>(offsetof(Boolean_tB53F6830F670160873277339AA58F15CAED4399C_StaticFields, ___FalseString_6)); }
	inline String_t* get_FalseString_6() const { return ___FalseString_6; }
	inline String_t** get_address_of_FalseString_6() { return &___FalseString_6; }
	inline void set_FalseString_6(String_t* value)
	{
		___FalseString_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FalseString_6), (void*)value);
	}
};


// System.Enum
struct  Enum_t2AF27C02B8653AE29442467390005ABC74D8F521  : public ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF
{
public:

public:
};

struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumSeperatorCharArray_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_marshaled_com
{
};

// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};


// System.Single
struct  Single_tDDDA9169C4E4E308AC6D7A824F9B28DC82204AE1 
{
public:
	// System.Single System.Single::m_value
	float ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Single_tDDDA9169C4E4E308AC6D7A824F9B28DC82204AE1, ___m_value_0)); }
	inline float get_m_value_0() const { return ___m_value_0; }
	inline float* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(float value)
	{
		___m_value_0 = value;
	}
};


// System.Void
struct  Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017__padding[1];
	};

public:
};


// UnityEngine.SceneManagement.Scene
struct  Scene_t942E023788C2BC9FBB7EC8356B4FB0088B2CFED2 
{
public:
	// System.Int32 UnityEngine.SceneManagement.Scene::m_Handle
	int32_t ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(Scene_t942E023788C2BC9FBB7EC8356B4FB0088B2CFED2, ___m_Handle_0)); }
	inline int32_t get_m_Handle_0() const { return ___m_Handle_0; }
	inline int32_t* get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(int32_t value)
	{
		___m_Handle_0 = value;
	}
};


// UnityEngine.KeyCode
struct  KeyCode_tC93EA87C5A6901160B583ADFCD3EF6726570DC3C 
{
public:
	// System.Int32 UnityEngine.KeyCode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(KeyCode_tC93EA87C5A6901160B583ADFCD3EF6726570DC3C, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Object
struct  Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.Component
struct  Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621  : public Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0
{
public:

public:
};


// UnityEngine.GameObject
struct  GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F  : public Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0
{
public:

public:
};


// UnityEngine.Behaviour
struct  Behaviour_tBDC7E9C3C898AD8348891B82D3E345801D920CA8  : public Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621
{
public:

public:
};


// UnityEngine.MonoBehaviour
struct  MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429  : public Behaviour_tBDC7E9C3C898AD8348891B82D3E345801D920CA8
{
public:

public:
};


// je_MainMenu
struct  je_MainMenu_t7E7AAC27A88A263CB4A8CB94F4C74217947756B5  : public MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429
{
public:

public:
};


// je_PauseMenu
struct  je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B  : public MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429
{
public:
	// UnityEngine.GameObject je_PauseMenu::pauseMenu
	GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * ___pauseMenu_4;

public:
	inline static int32_t get_offset_of_pauseMenu_4() { return static_cast<int32_t>(offsetof(je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B, ___pauseMenu_4)); }
	inline GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * get_pauseMenu_4() const { return ___pauseMenu_4; }
	inline GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F ** get_address_of_pauseMenu_4() { return &___pauseMenu_4; }
	inline void set_pauseMenu_4(GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * value)
	{
		___pauseMenu_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___pauseMenu_4), (void*)value);
	}
};

struct je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B_StaticFields
{
public:
	// System.Boolean je_PauseMenu::isPaused
	bool ___isPaused_5;

public:
	inline static int32_t get_offset_of_isPaused_5() { return static_cast<int32_t>(offsetof(je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B_StaticFields, ___isPaused_5)); }
	inline bool get_isPaused_5() const { return ___isPaused_5; }
	inline bool* get_address_of_isPaused_5() { return &___isPaused_5; }
	inline void set_isPaused_5(bool value)
	{
		___isPaused_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif



// System.Void UnityEngine.SceneManagement.SceneManager::LoadScene(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneManager_LoadScene_mFC850AC783E5EA05D6154976385DFECC251CDFB9 (String_t* ___sceneName0, const RuntimeMethod* method);
// System.Void UnityEngine.Application::Quit()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Application_Quit_mA005EB22CB989AC3794334754F15E1C0D2FF1C95 (const RuntimeMethod* method);
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_mEAEC84B222C60319D593E456D769B3311DFCEF97 (MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.GameObject::SetActive(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GameObject_SetActive_m25A39F6D9FB68C51F13313F9804E85ACC937BC04 (GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * __this, bool ___value0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Input::GetKeyDown(UnityEngine.KeyCode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Input_GetKeyDown_mEA57896808B6F484B12CD0AEEB83390A3CFCDBDC (int32_t ___key0, const RuntimeMethod* method);
// System.Void je_PauseMenu::ResumeGame()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_PauseMenu_ResumeGame_mF5CD313928B9CEE46AB2DDB9C442EDA2AA8B3392 (je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B * __this, const RuntimeMethod* method);
// System.Void je_PauseMenu::PauseGame()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_PauseMenu_PauseGame_mF868A258A5DBEA87097C176F988B0C67F72FD99D (je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Time::set_timeScale(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Time_set_timeScale_mAB89C3BB5DEE81934159C23F103397A77AC3F4AF (float ___value0, const RuntimeMethod* method);
// UnityEngine.SceneManagement.Scene UnityEngine.SceneManagement.SceneManager::GetActiveScene()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Scene_t942E023788C2BC9FBB7EC8356B4FB0088B2CFED2  SceneManager_GetActiveScene_mD583193D329EBF540D8AB8A062681B1C2AB5EA51 (const RuntimeMethod* method);
// System.String UnityEngine.SceneManagement.Scene::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Scene_get_name_m0E63ED0F050FCC35A4216220C584BE3D3F77B0E1 (Scene_t942E023788C2BC9FBB7EC8356B4FB0088B2CFED2 * __this, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void je_MainMenu::StartGame()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_MainMenu_StartGame_mE90199586E1F534ABC4DB757803E27B6CF66EC22 (je_MainMenu_t7E7AAC27A88A263CB4A8CB94F4C74217947756B5 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (je_MainMenu_StartGame_mE90199586E1F534ABC4DB757803E27B6CF66EC22_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		// SceneManager.LoadScene("AA_Level_Zero.unity");
		SceneManager_LoadScene_mFC850AC783E5EA05D6154976385DFECC251CDFB9(_stringLiteral522950E3314ACDF6B6C5E60CED64003A2BBD22BC, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void je_MainMenu::DisplaySettings()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_MainMenu_DisplaySettings_mD11BA28E6F0F29EA29A1042314875643EA0707A0 (je_MainMenu_t7E7AAC27A88A263CB4A8CB94F4C74217947756B5 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (je_MainMenu_DisplaySettings_mD11BA28E6F0F29EA29A1042314875643EA0707A0_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		// SceneManager.LoadScene("je_Settings");
		SceneManager_LoadScene_mFC850AC783E5EA05D6154976385DFECC251CDFB9(_stringLiteralC4003C1DAA0E5A07EAB3D1A0A983D70DAA7DF4BA, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void je_MainMenu::DisplayLevelSelect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_MainMenu_DisplayLevelSelect_mA3BFEDA938D564ED1C8E20AEDDB5BADDC4B1126B (je_MainMenu_t7E7AAC27A88A263CB4A8CB94F4C74217947756B5 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (je_MainMenu_DisplayLevelSelect_mA3BFEDA938D564ED1C8E20AEDDB5BADDC4B1126B_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		// SceneManager.LoadScene("je_LevelSelect");
		SceneManager_LoadScene_mFC850AC783E5EA05D6154976385DFECC251CDFB9(_stringLiteral90082D1552FEE7C48979F7BE2CDC6FCF9874AD38, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void je_MainMenu::DiplayMainMenu()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_MainMenu_DiplayMainMenu_m6E6B07C1B6AD68684A5D99B6FCF8B1562C676DD8 (je_MainMenu_t7E7AAC27A88A263CB4A8CB94F4C74217947756B5 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (je_MainMenu_DiplayMainMenu_m6E6B07C1B6AD68684A5D99B6FCF8B1562C676DD8_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		// SceneManager.LoadScene("je_MainMenu");
		SceneManager_LoadScene_mFC850AC783E5EA05D6154976385DFECC251CDFB9(_stringLiteralFBBE26930DFC50992D7EC4AED8D40081F9F283EA, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void je_MainMenu::ExitGame()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_MainMenu_ExitGame_m5F6BF8187E0E0F5D4DFD7C4DB1C1136A1237C55C (je_MainMenu_t7E7AAC27A88A263CB4A8CB94F4C74217947756B5 * __this, const RuntimeMethod* method)
{
	{
		// Application.Quit();
		Application_Quit_mA005EB22CB989AC3794334754F15E1C0D2FF1C95(/*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void je_MainMenu::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_MainMenu__ctor_mE6D1141D732D7949C2BAD89F082F01C3B12A6DDF (je_MainMenu_t7E7AAC27A88A263CB4A8CB94F4C74217947756B5 * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mEAEC84B222C60319D593E456D769B3311DFCEF97(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void je_PauseMenu::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_PauseMenu_Start_m15E3E1821DB43787212B1863DFEA0E7E5E953279 (je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B * __this, const RuntimeMethod* method)
{
	{
		// pauseMenu.SetActive(false);
		GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * L_0 = __this->get_pauseMenu_4();
		NullCheck(L_0);
		GameObject_SetActive_m25A39F6D9FB68C51F13313F9804E85ACC937BC04(L_0, (bool)0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void je_PauseMenu::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_PauseMenu_Update_m63FB8AC07994D253EB7383D8B473B06FC3C5992E (je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (je_PauseMenu_Update_m63FB8AC07994D253EB7383D8B473B06FC3C5992E_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(Input.GetKeyDown(KeyCode.Escape))
		bool L_0 = Input_GetKeyDown_mEA57896808B6F484B12CD0AEEB83390A3CFCDBDC(((int32_t)27), /*hidden argument*/NULL);
		if (!L_0)
		{
			goto IL_001d;
		}
	}
	{
		// if(isPaused)
		bool L_1 = ((je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B_StaticFields*)il2cpp_codegen_static_fields_for(je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B_il2cpp_TypeInfo_var))->get_isPaused_5();
		if (!L_1)
		{
			goto IL_0017;
		}
	}
	{
		// ResumeGame();
		je_PauseMenu_ResumeGame_mF5CD313928B9CEE46AB2DDB9C442EDA2AA8B3392(__this, /*hidden argument*/NULL);
		// }
		return;
	}

IL_0017:
	{
		// PauseGame();
		je_PauseMenu_PauseGame_mF868A258A5DBEA87097C176F988B0C67F72FD99D(__this, /*hidden argument*/NULL);
	}

IL_001d:
	{
		// }
		return;
	}
}
// System.Void je_PauseMenu::PauseGame()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_PauseMenu_PauseGame_mF868A258A5DBEA87097C176F988B0C67F72FD99D (je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (je_PauseMenu_PauseGame_mF868A258A5DBEA87097C176F988B0C67F72FD99D_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		// pauseMenu.SetActive(true);
		GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * L_0 = __this->get_pauseMenu_4();
		NullCheck(L_0);
		GameObject_SetActive_m25A39F6D9FB68C51F13313F9804E85ACC937BC04(L_0, (bool)1, /*hidden argument*/NULL);
		// Time.timeScale = 0f;
		Time_set_timeScale_mAB89C3BB5DEE81934159C23F103397A77AC3F4AF((0.0f), /*hidden argument*/NULL);
		// isPaused = true;
		((je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B_StaticFields*)il2cpp_codegen_static_fields_for(je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B_il2cpp_TypeInfo_var))->set_isPaused_5((bool)1);
		// }
		return;
	}
}
// System.Void je_PauseMenu::ResumeGame()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_PauseMenu_ResumeGame_mF5CD313928B9CEE46AB2DDB9C442EDA2AA8B3392 (je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (je_PauseMenu_ResumeGame_mF5CD313928B9CEE46AB2DDB9C442EDA2AA8B3392_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		// pauseMenu.SetActive(false);
		GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * L_0 = __this->get_pauseMenu_4();
		NullCheck(L_0);
		GameObject_SetActive_m25A39F6D9FB68C51F13313F9804E85ACC937BC04(L_0, (bool)0, /*hidden argument*/NULL);
		// Time.timeScale = 1f;
		Time_set_timeScale_mAB89C3BB5DEE81934159C23F103397A77AC3F4AF((1.0f), /*hidden argument*/NULL);
		// isPaused = false;
		((je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B_StaticFields*)il2cpp_codegen_static_fields_for(je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B_il2cpp_TypeInfo_var))->set_isPaused_5((bool)0);
		// }
		return;
	}
}
// System.Void je_PauseMenu::Restart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_PauseMenu_Restart_m942401B11E3322A6B89FAC53035A42CC8626DEA5 (je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B * __this, const RuntimeMethod* method)
{
	Scene_t942E023788C2BC9FBB7EC8356B4FB0088B2CFED2  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// Time.timeScale = 1f;
		Time_set_timeScale_mAB89C3BB5DEE81934159C23F103397A77AC3F4AF((1.0f), /*hidden argument*/NULL);
		// SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		Scene_t942E023788C2BC9FBB7EC8356B4FB0088B2CFED2  L_0 = SceneManager_GetActiveScene_mD583193D329EBF540D8AB8A062681B1C2AB5EA51(/*hidden argument*/NULL);
		V_0 = L_0;
		String_t* L_1 = Scene_get_name_m0E63ED0F050FCC35A4216220C584BE3D3F77B0E1((Scene_t942E023788C2BC9FBB7EC8356B4FB0088B2CFED2 *)(&V_0), /*hidden argument*/NULL);
		SceneManager_LoadScene_mFC850AC783E5EA05D6154976385DFECC251CDFB9(L_1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void je_PauseMenu::Settings()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_PauseMenu_Settings_m616BC89226440408E9C412D344EDA6296C1457EC (je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (je_PauseMenu_Settings_m616BC89226440408E9C412D344EDA6296C1457EC_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		// Time.timeScale = 1f;
		Time_set_timeScale_mAB89C3BB5DEE81934159C23F103397A77AC3F4AF((1.0f), /*hidden argument*/NULL);
		// SceneManager.LoadScene("je_Settings");
		SceneManager_LoadScene_mFC850AC783E5EA05D6154976385DFECC251CDFB9(_stringLiteralC4003C1DAA0E5A07EAB3D1A0A983D70DAA7DF4BA, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void je_PauseMenu::MainMenu()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_PauseMenu_MainMenu_m01FA222AF325787508628DC56832C1C159308D0C (je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (je_PauseMenu_MainMenu_m01FA222AF325787508628DC56832C1C159308D0C_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		// Time.timeScale = 1f;
		Time_set_timeScale_mAB89C3BB5DEE81934159C23F103397A77AC3F4AF((1.0f), /*hidden argument*/NULL);
		// SceneManager.LoadScene("je_MainMenu");
		SceneManager_LoadScene_mFC850AC783E5EA05D6154976385DFECC251CDFB9(_stringLiteralFBBE26930DFC50992D7EC4AED8D40081F9F283EA, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void je_PauseMenu::QuitGame()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_PauseMenu_QuitGame_mB390935E2C5FC0AC3A972B0A550BD2E50474CF14 (je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B * __this, const RuntimeMethod* method)
{
	{
		// Application.Quit();
		Application_Quit_mA005EB22CB989AC3794334754F15E1C0D2FF1C95(/*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void je_PauseMenu::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void je_PauseMenu__ctor_m5631143224045DFF601A542999FBB41454318E4C (je_PauseMenu_t873A11015F5872A0DA0B9A70EA573C667166F39B * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mEAEC84B222C60319D593E456D769B3311DFCEF97(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
