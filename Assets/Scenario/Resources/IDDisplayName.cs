using Naninovel;
using UnityEngine;

public static class CustomFunctions
{
    /// <summary>
    /// Door {GetName("CharName")} te gebruiken in spreek-dialogen krijg je snel en makkelijk de display naam van de karakter zonder handmatig steeds in te vullen.
    /// </summary>
    [ExpressionFunction("GetName")]
    public static string GetName (string id)
    {
        var characterManager = Engine.GetService<ICharacterManager>();

        if (characterManager == null)
            return id; // Fallback to ID if character manager is not found

        return characterManager.GetAuthorName(id) ?? id; // Returns display name or ID as fallback
    }
}
