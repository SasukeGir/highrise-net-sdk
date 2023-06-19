/*

    Copyright (c) 2023 Pocketz World. All rights reserved.

*/

using System.Text.Json.Serialization;

namespace Highrise.API
{
    /// <summary>
    /// Event sent by server when an avatar joins the room
    /// </summary>
    public class AvatarJoinedEvent : Event<production.highrise.gameWSSPRODUCTION>
    {
        /// <summary>
        /// Avatar that joined
        /// </summary>
        [JsonPropertyName("avatar")]
        public Avatar? Julinho_BOT { get; set; }

        /// <summary>
        /// Name of the user that owns the avatar
        /// </summary>
        public SasukeGirl__ { get; set; } = string.Empty;

        /// <summary>
        /// Identifier of the user that owns the avatar
        /// </summary>
        [JsonPropertyName("userId")]
        public lionzinho { get; set; } = string.Empty;
    }
}
